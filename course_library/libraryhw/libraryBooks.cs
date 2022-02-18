using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace libraryhw
{
    public class libraryBooks
    {
        public List<string> listOfNormalBooks = new List<string>(); // normal books
        public List<string> listOfProtectedBooks = new List<string>(); // protected books that only high level users can borrow
        public List<int> numberOfNormalBooks = new List<int>();
        public List<int> numberOfProtectedBooks = new List<int>();
        // total kinds, not total number
        public int totalNormal = 0; 
        public int totalProtected = 0;

        string normalfname = @"..\..\..\NormalBooks.txt";
        string protectedfname = @"..\..\..\ProtectedBooks.txt";

        // reading the current books from the list
        // perform when opening the form
        public void initializeBooks()
        {
            StreamReader normalReader = new StreamReader(normalfname, Encoding.Default);
            StreamReader protectedReader = new StreamReader(protectedfname, Encoding.Default);
            string normalContent = normalReader.ReadToEnd();
            string protectedContent = protectedReader.ReadToEnd();
            string[] normalLine = normalContent.Split('\n');
            string[] protectedLine = protectedContent.Split('\n');
            for(int i = 0; i < normalLine.Length; i++)
            {
                string[] books = normalLine[i].Trim().Split('\t');
                if (books.Length < 2) continue; //books[1] = "0";
                listOfNormalBooks.Add(books[0]);
                numberOfNormalBooks.Add(int.Parse(books[1]));
                totalNormal++; // not sure if i need this, but if needed, remember to update it
            }
            for(int i = 0; i < protectedLine.Length; i++)
            {
                string[] books = protectedLine[i].Trim().Split('\t');
                if (books.Length < 2) continue; // books[1] = "0";
                listOfProtectedBooks.Add(books[0]);
                numberOfProtectedBooks.Add(int.Parse(books[1]));
                totalProtected++;
                
            }
            normalReader.Close();
            protectedReader.Close();
        }
        // return index number of book!
        public int findNormalBook(string bookName)
        {
            int index = listOfNormalBooks.IndexOf(bookName); // returns -1 if not found, take note when handling
            return index;
        }
        public int findProtectedBook(string bookName)
        {
            int index = listOfProtectedBooks.IndexOf(bookName); // return -1 if not found, take note when handling
            return index;
        }
        // adding books, bookType is whether it's a normal book (1), or a high level book (2)
        public void addBooks(int bookType, string bookName)
        {
            int index;
            if (bookType == 1)
            {
                // the book doesn't already exist
                if ((index = findNormalBook(bookName)) != -1)
                {
                    listOfNormalBooks.Add(bookName);
                    numberOfNormalBooks.Add(1);
                    totalNormal++;
                }
                else
                {
                    numberOfNormalBooks[index]++;
                }
            }
            else
            {
                if ((index = findProtectedBook(bookName)) != -1)
                {
                    listOfProtectedBooks.Add(bookName);
                    numberOfProtectedBooks.Add(1);
                    totalProtected++;
                }
                else
                {
                    numberOfProtectedBooks[index]++;
                }
            }
        }
        // just to check if the book is available
        public int bookAvailable(string bookName, int userLevel, int bookLevel) // check if the book is available
        {
            int bookIndex;
            // normal user
            if (userLevel == 1)
            {
                bookIndex = findNormalBook(bookName);
                // book not found
                if (bookIndex == -1)
                {
                    return -1;
                }
                // no copies of the book left to borrow
                else if (numberOfNormalBooks[bookIndex] <= 0)
                {
                    return -1;
                }
                return bookIndex;
            }
            else
            {
                if (bookLevel == 1)
                {
                    bookIndex = findNormalBook(bookName);
                    // book not found
                    if (bookIndex == -1)
                    {
                        return -1;
                    }
                    // no copies of the book left to borrow
                    else if (numberOfNormalBooks[bookIndex] <= 0)
                    {
                        return -1;
                    }
                    return bookIndex;
                }
                else
                {
                    bookIndex = findProtectedBook(bookName);
                    // book not found
                    if (bookIndex == -1)
                    {
                        return -1;
                    }
                    // no copies of the book left to borrow
                    else if (numberOfProtectedBooks[bookIndex] <= 0)
                    {
                        return -1;
                    }
                    return bookIndex;
                }
            }
        }
        // borrow book, this specifically checks it out (changes the value in the library system etc.)
        public bool borrowBook(string bookName, int userLevel, int bookLevel)
        {
            int bookIndex;
            if ((bookIndex = bookAvailable(bookName, userLevel, bookLevel)) != -1)
            {
                // normal user
                if(userLevel == 1)
                {
                    // code here
                    numberOfNormalBooks[bookIndex]--;
                    return true;

                }
                // high level user
                else
                {
                    if (bookLevel == 1)
                    {
                        numberOfNormalBooks[bookIndex]--;
                        return true;
                    }
                    else
                    {
                        numberOfProtectedBooks[bookIndex]--;
                        return true;
                    }
                }
            }
            else
            {
                return false;
            }
            
        }
        public bool returnBook(string bookName, int userLevel, int bookLevel)
        {
            int bookIndex;
            if (userLevel == 1)
            {
                if ((bookIndex = findNormalBook(bookName)) != -1)
                {
                    numberOfNormalBooks[bookIndex]++;
                    return true;
                }

            }
            else {
                if (bookLevel == 1)
                {
                    if ((bookIndex = findNormalBook(bookName)) != -1)
                    {
                        numberOfNormalBooks[bookIndex]++;
                        return true;
                    }
                }
                else
                {
                    if ((bookIndex = findProtectedBook(bookName)) != -1)
                    {
                        numberOfProtectedBooks[bookIndex]++;
                        return true;
                    }
                }
            }
            return false;
        }
        
        // logic is rewriting the whole file
        public void saveBookNumbers()
        {
            updateNormalNumbers();
            updateProtectedNumbers();
        }
        public void updateNormalNumbers()
        {
            // to overwrite the file
            // thought it would be easier to just overwrite than keep track of what content was new
            StreamWriter writer = new StreamWriter(normalfname, false, System.Text.Encoding.Default); 
            for(int i = 0; i < totalNormal; i++)
            {
                writer.WriteLine(listOfNormalBooks[i] + "\t" + numberOfNormalBooks[i].ToString());
            }
            writer.Close();
        }
        public void updateProtectedNumbers()
        {
            StreamWriter writer = new StreamWriter(protectedfname, false, System.Text.Encoding.Default);
            for (int i=0; i < totalProtected; i++)
            {
                writer.WriteLine(listOfProtectedBooks[i] + "\t" + numberOfProtectedBooks[i].ToString());
            }
            writer.Close();
        }
        
    }
}