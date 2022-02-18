using System;
using System.Collections.Generic;
using System.Text;

namespace libraryhw
{
    public class basicUser // only to be used as a parent class
    {
        public string username;
        public string password;
        public int booksBorrowed = 0;
        public int userStatus;
        public List<int> booksBorrowedID = new List<int>(); // record the book borrowed by the ID
        public List<int> bookType = new List<int>(); // record the kind of book, 1 for normal book, 2 for protected book
        // might not add the below...?
        // public List<int> numberOfBooks = new List<int>(); // record the number of each book

        public basicUser(string username, string password, int userstatus)
        {
            this.username = username;
            this.password = password;
            this.userStatus = userstatus;
        }
        

        // borrowing an additional x books
        // returns false if still able to borrow
        public virtual bool bookLimit(int x) // has the user reached their borrowing limit?
        {
            if (booksBorrowed + x < 1) return false; // not yet, still able to borrow books
            else return true; // reached limit, no more borrowing of books
        }

        public int userLevel()
        {
            return this.userStatus;
        }

        public bool checkUser(string username, string password)
        {
            return ((username == this.username) && (password == this.password));
        }


        // on the user end, borrowing a book
        // will have checked the book clearance, the details etc. already on the library system end
        // failed to borrow
        public bool userBorrowBook(int id, int bookType) // if bookType = 1, it's a normal book, else it's a protected book
        {
            if (bookLimit(1))
            {
                // no longer able to borrow
                return false;
            }
            else
            {
                this.booksBorrowedID.Add(id);
                this.bookType.Add(bookType);
                booksBorrowed++;
                return true;
            }
        }


        // on the user end
        // need to complete the returning system on the system end
        /*
        public virtual void userReturnBook(int id)
        {
            int index = this.booksBorrowedID.IndexOf(id);

            this.booksBorrowedID.RemoveAt(index);
            this.bookType.RemoveAt(index);
            booksBorrowed--;
        }
        */


         
    }
}