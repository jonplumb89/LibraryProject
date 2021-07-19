using LibraryProject1.LibraryProject1;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LibraryProject1
{
    public class FileService
    {
        public static void CreateFile(string fileName)
        {
            // checks if the file exists so you dont overwrite the file
            if (!File.Exists(fileName)) // means if it doesnt exist it makes it
            {
                File.Create(fileName);
            }
        }

        public static void SaveArrayAsCSV<T>(List<T> arrayToSave, string fileName)
        {
            using (StreamWriter file = new StreamWriter(fileName))
            {
                string headers = "";
                foreach (var property in typeof(T).GetProperties())
                {
                    headers += property.Name + ", ";
                }
                file.WriteLine(headers);
                arrayToSave.ForEach(item =>
                {
                    string line = "";
                    foreach (var proporty in typeof(T).GetProperties())
                    {

                        line += proporty.GetValue(item) + ", ";

                    }
                    file.WriteLine(line);

                });
            }
        }

        public static List<Book> ConvertCSVToArray(string filename)
        {
            List<Book> books = new List<Book>();
            using (StreamReader file = new StreamReader(filename))
            {
                string line;
                var firstline = file.ReadLine();
                while ((line = file.ReadLine()) != null)
                {
                    string[] dataArray = line.Split(", ");
                    books.Add(new Book()
                    {
                        Title = dataArray[0],
                        Author = dataArray[1],
                        Status = bool.Parse(dataArray[2]),
                        DueDate = DateTime.Parse(dataArray[3])
                    });
                }
                books.ForEach(book =>
                {
                    foreach (var proporty in typeof(Book).GetProperties())
                    {
                        Console.Write(proporty.GetValue(book) + ", ");
                    }
                    Console.WriteLine();

                });
                return books;
            }

        }
        public static List<Book> SearchByType(string keyword, string fileName, SearchTypeEnum searchType)
        {
            //gets books from file and puts it into list of books
            List<Book> books = ConvertCSVToArray(fileName);
            var filteredBooks = books.FindAll(book =>
            {
                // setsup string to convert proporty into string when searching
                string proporty = searchType.ToString();
                // searches through the proporties of each book and looks for the keyword ("title", "author", "status")
                // based on the searchType enum
                if (book.GetType().GetProperty(proporty).GetValue(book, null).ToString() == keyword)
                {
                    return true;
                }
                return false;
            });
            //returns the list of matched books
            return filteredBooks;
        }
        public static void CheckingOutBook(string userSelection, List<Book> bookList)
        {
            DateTime checkoutDay = DateTime.Now;
            DateTime bookDueDate = checkoutDay.AddDays(14);
            foreach (Book b in bookList)
            {
                if (b.Title.Equals(userSelection) || b.Author.Equals(userSelection))
                {
                    if (b.Status.Equals(false))
                    {
                        Console.WriteLine("This book is currently checked out.");
                    }
                    else
                    {
                        Console.WriteLine($"{userSelection} is being checked out on : {checkoutDay:MM/dd/yyyy}.");
                        Console.WriteLine($"{userSelection} , will be due back on : {bookDueDate:MM/dd/yyyy}.");
                        b.Status.Equals(false);
                    }
                }
            }
        }
        //this method checked to see if the b.status.equals(false) worked or not 
        public static void CheckTheStatus(string userSelection, List<Book> bookList)
        {
            foreach (Book b in bookList)
            {
                Console.WriteLine(b.Status.Equals(userSelection));
            }
        }
    }
}
