using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace libraryhw
{
    public partial class Form1 : Form
    {
        public delegate void checkEventHandler();
        public event checkEventHandler failedLogin;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Simple Library System";
            failedLogin += new checkEventHandler(Initiate);
            

        }
        public static libraryBooks allBooks = new libraryBooks();
        public static librarySystem library = new librarySystem(allBooks);
        public static normalUser loggedInNormalUser;
        public static highLevelUser loggedInHighLevelUser;
        public static int loggedInAccountType;
        bool LoginCreate = true; // true for login
        public void Initiate()
        {
            MessageBox.Show("Username or password is invalid" + Environment.NewLine + "Failed to login! Please try again.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // used to pull up the console for debugging
            //AllocConsole();
            library.initializeAccounts();
            library.allBooks.initializeBooks();
            library.initializeBorrowedBooks();
            txtLoginPassword.PasswordChar = '*';

        }
        // used to pull up the console
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void btnSwitchToCreate_Click(object sender, EventArgs e)
        {
            // right now is true, after you click, it becomes false and show the create account page
            if (LoginCreate == true)
            {
                // create account page
                LoginCreate = false;
                btnNewAccnt.Visible = true;
                btnLogin.Visible = false;
                btnSwitchToCreate.Text = "Login Page";
                txtLoginUsername.Text = "";
                txtLoginPassword.Text = "";
            }
            else
            {
                // login page
                LoginCreate = true;
                btnNewAccnt.Visible = false;
                btnLogin.Visible = true;
                btnSwitchToCreate.Text = "Create New Account";
                txtLoginUsername.Text = "";
                txtLoginPassword.Text = "";
            }


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtLoginUsername.Text;
            string password = txtLoginPassword.Text;
            if (radioNormalUser.Checked)
            {
                loggedInNormalUser = library.findNormalAccount(username, password);
                if (loggedInNormalUser == null)
                {
                    failedLogin();
                    txtLoginUsername.Text = "";
                    txtLoginPassword.Text = "";
                }
                else
                {
                    loggedInAccountType = 1;
                    txtLoginUsername.Text = "";
                    txtLoginPassword.Text = "";
                    new Form2().Show();
                }
            }
            else if (radioHighLeveluser.Checked)
            {
                loggedInHighLevelUser = library.findHighLevelAccount(username, password);
                if (loggedInHighLevelUser == null)
                {
                    failedLogin();
                    txtLoginUsername.Text = "";
                    txtLoginPassword.Text = "";
                }
                else
                {
                    loggedInAccountType = 2;
                    txtLoginUsername.Text = "";
                    txtLoginPassword.Text = "";
                    new Form2().Show();
                }
            }
        }

        // note that need to change and add a way to check if the username already exists
        private void btnNewAccnt_Click(object sender, EventArgs e)
        {
            string username = txtLoginUsername.Text;
            string password = txtLoginPassword.Text;
            // check if any field is empty
            if(String.IsNullOrEmpty(username) && String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password");
            }
            else if (String.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter username");
            }
            else if (String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter password");
            }
            else
            {
                // check the user level
                if (radioNormalUser.Checked)
                {
                    if (library.openAccount(username, password, 1) == true)
                    {
                        MessageBox.Show("Account created!" + Environment.NewLine + "Welcome " + username);
                    }
                    else
                    {
                        MessageBox.Show("Username already in use, please choose another username");
                    }

                }
                else if (radioHighLeveluser.Checked)
                {
                    if (library.openAccount(username, password, 2) == true)
                    {
                        MessageBox.Show("Account created!" + Environment.NewLine + "Welcome " + username);
                    }
                    else
                    {
                        MessageBox.Show("Username already in use, please choose another username");
                    }

                }
                txtLoginUsername.Text = "";
                txtLoginPassword.Text = "";
                // change back to login page
                LoginCreate = true;
                btnNewAccnt.Visible = false;
                btnLogin.Visible = true;
                btnSwitchToCreate.Text = "Create New Account";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            library.saveAccounts();
            library.allBooks.saveBookNumbers();
            library.saveBorrowedBooks();
        }
    }
}
