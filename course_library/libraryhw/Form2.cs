using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace libraryhw
{
    public partial class Form2 : Form
    {
        Random rnd = new Random();
        
        public Form2()
        {
            InitializeComponent();
            this.Text = "Welcome!";
            btnCheckout.Click += new EventHandler(btnCheckout_Click);
            
        }
        List<string> checkoutCounterBooks = new List<string>();
        List<int> checkoutCounterBooksType = new List<int>();
        
        

        static void systemFailCheck(int x)
        {
            if (x < 1)
            {
                throw new systemFailException("The system has crashed! Please re-login");
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            int bookIndex;
            try
            {
                systemFailCheck(rnd.Next(5));

            }
            catch(systemFailException err)
            {
                MessageBox.Show(err.Message);
                this.Close();
                return;
            }
            if(checkoutCounterBooks.Count != 0)
            {
                if (Form1.library.allBooks.bookAvailable(checkoutCounterBooks[0], Form1.loggedInAccountType, checkoutCounterBooksType[0]) != -1) {
                    if (Form1.loggedInAccountType == 1)
                    {
                        // don't need to check if it's available as that has already been checked
                        bookIndex = Form1.library.allBooks.findNormalBook(checkoutCounterBooks[0]);
                        if(Form1.loggedInNormalUser.userBorrowBook(bookIndex, 1) == false)
                        {
                            MessageBox.Show("You have reached your borrowing limit!" + Environment.NewLine + "Please return a book to continue borrowing");
                        }
                        else
                        {
                            Form1.library.allBooks.borrowBook(checkoutCounterBooks[0], Form1.loggedInAccountType, checkoutCounterBooksType[0]);
                        }

                    }
                    else
                    {
                        // can borrow both protected books and normal books
                        if ((bookIndex = Form1.library.allBooks.findNormalBook(checkoutCounterBooks[0])) != -1)
                        {
                            // the book being borrowed is a normal book
                            if(Form1.loggedInHighLevelUser.userBorrowBook(bookIndex, 1) == false)
                            {
                                MessageBox.Show("You have reached your borrowing limit!" + Environment.NewLine + "Please return a book to continue borrowing");
                            }
                            else
                            {
                                Form1.library.allBooks.borrowBook(checkoutCounterBooks[0], Form1.loggedInAccountType, checkoutCounterBooksType[0]);
                            }
                        }
                        else
                        {
                            // the book being borrowed is a protected book
                            bookIndex = Form1.library.allBooks.findProtectedBook(checkoutCounterBooks[0]);
                            if(Form1.loggedInHighLevelUser.userBorrowBook(bookIndex, 2) == false)
                            {
                                MessageBox.Show("You have reached your borrowing limit!" + Environment.NewLine + "Please return a book to continue borrowing");
                            }
                            else
                            {
                                Form1.library.allBooks.borrowBook(checkoutCounterBooks[0], Form1.loggedInAccountType, checkoutCounterBooksType[0]);
                            }

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error! Cannot borrow this book!" + Environment.NewLine + "Removing from checkout counter...");
                }
                checkoutCounterBooks.RemoveAt(0);
                checkoutCounterBooksType.RemoveAt(0);
                reprintCheckout();
                reprintCurrentBookList();
            }
            else
            {
                MessageBox.Show("You have checked out all the books on the counter!");
            }
            
        }
        private void reprintCheckout()
        {
            txtCheckoutCounter.Text = "";
            foreach(string name in checkoutCounterBooks)
            {
                txtCheckoutCounter.AppendText(name + Environment.NewLine );
            }
        }
        private void reprintCurrentBookList()
        {
            // add code to reprint current borrowed books list
            // normal user
            txtCurrentBooks.Text = "";
            if (Form1.loggedInAccountType == 1) {
                for (int i = 0; i < Form1.loggedInNormalUser.booksBorrowed; i++)
                {
                    int bookID = Form1.loggedInNormalUser.booksBorrowedID[i];
                    txtCurrentBooks.AppendText(Form1.library.allBooks.listOfNormalBooks[bookID] + Environment.NewLine);
                }
            }
            else
            {
                // can borrow both normal and protected books
                for (int i = 0; i < Form1.loggedInHighLevelUser.booksBorrowedID.Count; i++)
                {
                    // normal books
                    if (Form1.loggedInHighLevelUser.bookType[i] == 1)
                    {
                        int bookID = Form1.loggedInHighLevelUser.booksBorrowedID[i];
                        txtCurrentBooks.AppendText(Form1.library.allBooks.listOfNormalBooks[bookID] + Environment.NewLine);
                    }
                    // protected books
                    else
                    {
                        int bookID = Form1.loggedInHighLevelUser.booksBorrowedID[i];
                        txtCurrentBooks.AppendText(Form1.library.allBooks.listOfProtectedBooks[bookID] + Environment.NewLine);
                    }
                }
            }
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (string bookname in Form1.library.allBooks.listOfNormalBooks)
            {
                txtNormalBooks.AppendText(bookname + Environment.NewLine);
            }
            foreach (string bookname in Form1.library.allBooks.listOfProtectedBooks)
            {
                txtProtectedBooks.AppendText(bookname + Environment.NewLine);
            }
            reprintCurrentBookList();
        }
        // if there is already a book being checked out with the same name, return true (there is an overlap)!
        // else return false
        private bool checkOutCounterOverlap(string currentBookName)
        {
            foreach(string book in checkoutCounterBooks)
            {
                if(currentBookName == book)
                {
                    return true;
                }
            }

            return false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(Form1.loggedInAccountType == 1)
            {
                MessageBox.Show("Sad to see you go " + Form1.loggedInNormalUser.username + Environment.NewLine + 
                    "Feel free to create a new account sometime!");
                Form1.library.closeAccount(Form1.loggedInNormalUser);
                this.Close();
            }
            else
            {
                MessageBox.Show("Sad to see you go " + Form1.loggedInHighLevelUser.username + Environment.NewLine +
                                    "Feel free to create a new account sometime!");
                Form1.library.closeAccount(Form1.loggedInHighLevelUser);
                this.Close();
            }
        }

        private void txtCheckoutCounter_KeyDown(object sender, KeyEventArgs e)
        {
            string checkOutBookName;
            if(e.KeyCode == Keys.Enter)
            {
                checkOutBookName = txtPlaceCheckout.Text;
                // normal book
                if (Form1.library.allBooks.findNormalBook(checkOutBookName) != -1)
                {
                    if (Form1.library.allBooks.bookAvailable(checkOutBookName, Form1.loggedInAccountType, 1) != -1)
                    {
                        if (checkOutCounterOverlap(checkOutBookName))
                        {
                            MessageBox.Show("Already checking out this book" + Environment.NewLine + "Please checkout another book.");
                        }
                        else
                        {
                            checkoutCounterBooks.Add(checkOutBookName);
                            checkoutCounterBooksType.Add(1);
                            txtCheckoutCounter.AppendText(checkOutBookName + Environment.NewLine);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Wrong book name/Book unavailable");
                    }
                }
                // is a protected book
                else if(Form1.library.allBooks.findProtectedBook(checkOutBookName) != -1)
                {
                    if (Form1.library.allBooks.bookAvailable(checkOutBookName, Form1.loggedInAccountType, 2) != -1)
                    {
                        if (checkOutCounterOverlap(checkOutBookName))
                        {
                            MessageBox.Show("Already checking out this book" + Environment.NewLine + "Please checkout another book.");
                        }
                        else
                        {
                            checkoutCounterBooks.Add(checkOutBookName);
                            checkoutCounterBooksType.Add(2);
                            txtCheckoutCounter.AppendText(checkOutBookName + Environment.NewLine);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Wrong book name/Book unavailable");
                    }
                }
                else
                {
                    // if the book name is wrong
                    // if you don't have the correct level to borrow it (not high level and wanting to borrow protected books)
                    // if there aren't anymore copies of the book left
                    MessageBox.Show("Wrong book name/Book unavailable");
                }
                txtPlaceCheckout.Text = "";

            }
        }
        private void textReturnBooks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int bookIndex;
                string bookname;
                bookname = txtReturnBooks.Text;
                // normal user
                if (Form1.loggedInAccountType == 1)
                {
                    // can only borrow normal books
                    if ((bookIndex = Form1.allBooks.findNormalBook(bookname)) != -1)
                    {
                        int x = Form1.loggedInNormalUser.booksBorrowedID.IndexOf(bookIndex);
                        if (x == -1)
                        {
                            MessageBox.Show("Book not borrowed!");
                        }
                        else
                        {
                            Form1.loggedInNormalUser.booksBorrowedID.RemoveAt(x);
                            Form1.loggedInNormalUser.booksBorrowed--;
                            Form1.library.allBooks.returnBook(bookname, 1, 1);
                            reprintCurrentBookList();
                        }
                    }
                    else MessageBox.Show("Book does not exist!");
                }
                // is a high level user
                else
                {
                    // is a normal book
                    if((bookIndex = Form1.allBooks.findNormalBook(bookname)) != -1)
                    {
                        int x = Form1.loggedInHighLevelUser.booksBorrowedID.IndexOf(bookIndex);
                        if (x == -1)
                        {
                            MessageBox.Show("Book not borrowed!");
                        }
                        else if (Form1.loggedInHighLevelUser.bookType[x] == 1)
                        {
                            Form1.loggedInHighLevelUser.booksBorrowedID.RemoveAt(x);
                            Form1.loggedInHighLevelUser.booksBorrowed--;
                            Form1.library.allBooks.returnBook(bookname, 2, 1);
                            reprintCurrentBookList();
                        }
                        else
                        {
                            // the second book is the correct one since the first book type is not correct
                            // x is getting the value of the normal book with the same index
                            int y = Form1.loggedInHighLevelUser.booksBorrowedID.IndexOf(bookIndex, x + 1);
                            Form1.loggedInHighLevelUser.booksBorrowedID.RemoveAt(y);
                            Form1.loggedInHighLevelUser.booksBorrowed--;
                            Form1.library.allBooks.returnBook(bookname, 2, 1);
                            reprintCurrentBookList();
                        }
                    }
                    // is a protected book
                    else if((bookIndex = Form1.allBooks.findProtectedBook(bookname))!=-1)
                    {
                        int x = Form1.loggedInHighLevelUser.booksBorrowedID.IndexOf(bookIndex);
                        if (x == -1)
                        {
                            MessageBox.Show("Book not borrowed!");
                        }
                        // correct book in the list
                        else if (Form1.loggedInHighLevelUser.bookType[x] == 2)
                        {
                            Form1.loggedInHighLevelUser.booksBorrowedID.RemoveAt(x);
                            Form1.loggedInHighLevelUser.booksBorrowed--;
                            Form1.library.allBooks.returnBook(bookname, 2, 2);
                            reprintCurrentBookList();
                        }
                        else
                        {
                            // the second book is the correct one since the first book type is not correct
                            // x is getting the value of the normal book with the same index
                            int y = Form1.loggedInHighLevelUser.booksBorrowedID.IndexOf(bookIndex, x+1);
                            Form1.loggedInHighLevelUser.booksBorrowedID.RemoveAt(y);
                            Form1.loggedInHighLevelUser.booksBorrowed--;
                            Form1.library.allBooks.returnBook(bookname, 2, 2);
                            reprintCurrentBookList();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Book does not exist!");
                    }
                }
                txtReturnBooks.Text = "";
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Form1.library.saveBorrowedBooks();
        }

        
    }
}
