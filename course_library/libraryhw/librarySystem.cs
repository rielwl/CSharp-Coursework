using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace libraryhw
{
    public class librarySystem
    {
        public List<normalUser> normalUserAccounts = new List<normalUser>();
        public List<highLevelUser> highLevelUserAccounts = new List<highLevelUser>();
        public libraryBooks allBooks = new libraryBooks();
        string fname = @"..\..\..\UsersAccounts.txt";
        string normalbooksfname = @"..\..\..\BorrowedBooksNormal.txt";
        string protectedbooksfname = @"..\..\..\BorrowedBooksHighLevel.txt";

        public librarySystem(libraryBooks books)
        {
            this.allBooks = books;
        }
        public string loadedAccountUsername(int x, int userLevel)
        {
            if (userLevel == 1)
            {
                return this.normalUserAccounts[x].username;
            }
            else
            {
                return this.highLevelUserAccounts[x].username;
            }
        }

        public string loadedAccountPassword(int x, int userLevel)
        {
            if (userLevel == 1)
            {
                return this.normalUserAccounts[x].password;
            }
            else
            {
                return this.highLevelUserAccounts[x].password;
            }
        }

        // if there is already a user with that name, return false
        // cannot create two users with the same username (regardless of account type)
        public bool usernameOverlap(string username)
        {
            foreach (normalUser account in normalUserAccounts)
            {
                if (username == account.username)
                {
                    return false;
                }
            }
            foreach (highLevelUser account in highLevelUserAccounts)
            {
                if (username == account.username)
                {
                    return false;
                }
            }
            return true;
        }

        // returns true if account is opened successfully
        // checking if there is username overlap
        public bool openAccount(string username, string password, int accntType)
        {
            if (usernameOverlap(username))
            {
                if (accntType == 1)
                {
                    normalUser newUser = new normalUser(username, password);
                    normalUserAccounts.Add(newUser);
                    return true;
                }
                else
                {
                    highLevelUser newUser = new highLevelUser(username, password);
                    highLevelUserAccounts.Add(newUser);
                    return true;
                }
            }
            else return false;

        }

        public void closeAccount(normalUser account)
        {
            normalUserAccounts.Remove(account);
            int bookType;
            foreach (int bookIndex in account.booksBorrowedID)
            {
                bookType = account.bookType[bookIndex];
                // returning a normal book
                if(bookType == 1)
                {
                    allBooks.returnBook(allBooks.listOfNormalBooks[bookIndex], account.userLevel(), 1);
                }
                // returning a protected book
                else
                {
                    allBooks.returnBook(allBooks.listOfProtectedBooks[bookIndex], account.userLevel(), 2);
                }
            }
        }
        public void closeAccount(highLevelUser account)
        {
            highLevelUserAccounts.Remove(account);
            int bookType;
            foreach (int bookIndex in account.booksBorrowedID)
            {
                bookType = account.bookType[bookIndex];
                // returning a normal book
                if (bookType == 1)
                {
                    allBooks.returnBook(allBooks.listOfNormalBooks[bookIndex], account.userLevel(), 1);
                }
                // returning a protected book
                else
                {
                    allBooks.returnBook(allBooks.listOfProtectedBooks[bookIndex], account.userLevel(), 2);
                }
            }
        }

        // search for normal account
        public normalUser findNormalAccount(string username, string password)
        {
            foreach(normalUser account in normalUserAccounts)
            {
                if(account.checkUser(username, password))
                {
                    return account;
                }
            }
            return null;
        }

        // search for the account
        public highLevelUser findHighLevelAccount(string username, string password)
        {
            foreach (highLevelUser account in highLevelUserAccounts)
            {
                if (account.checkUser(username, password))
                {
                    return account;
                }
            }
            return null;
        }

        // retrieve accounts from UserAccounts
        public void initializeAccounts()
        {
            StreamReader reader = new StreamReader(fname, Encoding.Default);
            string content = reader.ReadToEnd();
            string[] line = content.Split('\n');
            for(int i = 0; i < line.Length; i++)
            {
                string[] accountDetails = line[i].Split('\t');
                if (accountDetails.Length < 3) continue;
                //Console.WriteLine(accountDetails[2]);
                if (int.Parse(accountDetails[2]) == 1)
                {
                    normalUser user = new normalUser(accountDetails[0], accountDetails[1]);
                    normalUserAccounts.Add(user);
                    //Console.WriteLine("added normal user");
                    
                }
                else
                {
                    highLevelUser user = new highLevelUser(accountDetails[0], accountDetails[1]);
                    highLevelUserAccounts.Add(user);
                    //Console.WriteLine("added high level user");
                }
            }
            reader.Close();
        }

        // do this before closing
        // rewrite the UserAccounts.txt to save all current accounts
        public void saveAccounts()
        {
            StreamWriter writer = new StreamWriter(fname, false, System.Text.Encoding.Default);
            foreach (normalUser user in normalUserAccounts)
            {
                writer.WriteLine(user.username + '\t' + user.password + "\t" + "1");
            }
            foreach(highLevelUser user in highLevelUserAccounts)
            {
                writer.WriteLine(user.username + '\t' + user.password + "\t" + "2");
            }
            writer.Close();
        }

        // take note that it records 
        public void saveBorrowedBooks()
        {
            StreamWriter protectedWriter = new StreamWriter(protectedbooksfname, false, System.Text.Encoding.Default);
            StreamWriter normalWriter= new StreamWriter(normalbooksfname, false, System.Text.Encoding.Default);
            foreach (normalUser user in normalUserAccounts)
            {
                normalWriter.Write(user.booksBorrowed.ToString());
                foreach (int x in user.booksBorrowedID)
                {
                    normalWriter.Write('\t' + x.ToString() + '\t' + user.bookType[user.booksBorrowedID.IndexOf(x)]);
                }
                normalWriter.Write('\n');
                //normalWriter.WriteLine(user.username + '\t' + user.password + "1");
            }
            foreach (highLevelUser user in highLevelUserAccounts)
            {
                protectedWriter.Write(user.booksBorrowed.ToString());
                foreach (int x in user.booksBorrowedID)
                {
                    protectedWriter.Write('\t' + x.ToString()+ '\t' +user.bookType[user.booksBorrowedID.IndexOf(x)]);
                }
                protectedWriter.Write('\n');
                //protectedWriter.WriteLine(user.username + '\t' + user.password + "2");
            }
            protectedWriter.Close();
            normalWriter.Close();
        }

        // BorrowedBooksNormal is the books borrowed for normal users
        // BorrowedBooksProtected is the books borrowed for high level users
        public void initializeBorrowedBooks()
        {
            StreamReader readerNormal = new StreamReader(normalbooksfname, Encoding.Default);
            StreamReader readerHighLevel = new StreamReader(protectedbooksfname, Encoding.Default);
            string contentNormal = readerNormal.ReadToEnd();
            string contentHighLevel = readerHighLevel.ReadToEnd();
            string[] lineNormal = contentNormal.Split('\n');
            string[] lineHighLevel = contentHighLevel.Split('\n');
            int i = 0;
            //int lengthNormal = lineNormal.Length;
            //int lengthHighLevel = lineHighLevel.Length;
            foreach (normalUser user in normalUserAccounts)
            {

                string[] booksBorrowed = lineNormal[i].Split('\t');
                if (booksBorrowed.Length < 3) { i++; continue; }
                user.booksBorrowed = int.Parse(booksBorrowed[0]);
                int l = user.booksBorrowed * 2;
                for (int j = 1; j < l + 1; j += 2)
                {
                    user.booksBorrowedID.Add(int.Parse(booksBorrowed[j]));
                    user.bookType.Add(int.Parse(booksBorrowed[j + 1]));
                }
                i++;
                

            }
            readerNormal.Close();
            i = 0;
            foreach (highLevelUser user in highLevelUserAccounts)
            {
                string[] booksBorrowed = lineHighLevel[i].Split('\t');
                if (booksBorrowed.Length < 3) { i++; continue; }
                
                user.booksBorrowed = int.Parse(booksBorrowed[0]);
                Console.WriteLine(user.booksBorrowed);
                int l = user.booksBorrowed * 2;
                for (int j = 1; j < l + 1; j += 2)
                {
                    user.booksBorrowedID.Add(int.Parse(booksBorrowed[j]));
                    user.bookType.Add(int.Parse(booksBorrowed[j + 1]));
                    //Console.WriteLine(j);
                }
                i++;
            }
            readerHighLevel.Close();
        }

    }
}