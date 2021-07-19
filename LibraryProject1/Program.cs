
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating library file
            var fileName = "library.txt";
            FileService.CreateFile(fileName);
            // creating library book database
            List<Book> bookList = new List<Book>();
            
            bookList.Add(new Book()
            {
                Title = "Amari and the Night Brothers",
                Author = "B.B. Alston",
                Status = true,
                DueDate = DateTime.Now
            }) ;
            bookList.Add(new Book()
            {
                Title = "Children of Blood and Bone",
                Author = "Tomi Adeyemi",
                Status = true,
                DueDate = DateTime.Now
            });
            bookList.Add(new Book()
            {
                Title = "Children of Virtue and Vengeance",
                Author = "Tomi Adeyemi",
                Status = true,
                DueDate = DateTime.Now
            });
            bookList.Add(new Book()
            {
                Title = "The Coldest Winter Ever",
                Author = "Sister Souljah",
                Status = true,
                DueDate = DateTime.Now
            });
            bookList.Add(new Book()
            {
                Title = "No Disrespect",
                Author = "Sister Souljah",
                Status = true,
                DueDate = DateTime.Now
            });
            bookList.Add(new Book()
            {
                Title = "Firekeeper's Daughter",
                Author = "Angeline Boulley",
                Status = true,
                DueDate = DateTime.Now
            });
            bookList.Add(new Book()
            {
                Title = "Etiquette and Espionage",
                Author = "Gail Carriger",
                Status = true,
                DueDate = DateTime.Now
            });
            bookList.Add(new Book()
            {
                Title = "Soulless",
                Author = "Gail Carriger",
                Status = true,
                DueDate = DateTime.Now
            });
            bookList.Add(new Book()
            {
                Title = "From Here to Timbuktu",
                Author = "Milton J. Davis",
                Status = true,
                DueDate = DateTime.Now
            });
            bookList.Add(new Book()
            {
                Title = "Who Fears Death",
                Author = "Nnedi Okorafor",
                Status = true,
                DueDate = DateTime.Now
            });
            bookList.Add(new Book()
            {
                Title = "Song of Blood and Stone",
                Author = "L. Penelope",
                Status = true,
                DueDate = DateTime.Now
            });
            bookList.Add(new Book()
            {
                Title = "Obsidian and Blood",
                Author = "Aliette de Bodard",
                Status = true,
                DueDate = DateTime.Now
            });

            string userSelection = "Aliette de Bodard";
            FileService.SearchByType("Gail Carriger", fileName, SearchTypeEnum.Author);
            //FileService.CheckingOutBook(userSelection, bookList, fileName);

            //FileService.SaveArrayAsCSV<Book>(bookList, fileName);
            //FileService.ConvertCSVToArray(fileName);
            //SearchByAuthor(userInput, bookList);

          
            //FileService.SaveArrayAsCSV<Book>(bookList, fileName);
            FileService.WriteBookToCSV(bookList, fileName);
            FileService.ConvertCSVToArray(fileName); 
            //Book newBook = new Book()
            //{
            //    Title = "jjjObsidian and Bloodsdfsdf",
            //    Author = "jjjjAliette de Bodardsdffsf",
            //    Status = false,
            //    DueDate = DateTime.Now
            //};
            //FileService.AddBook(newBook, fileName);
            //FileService.PrintBooksFile(fileName);
            FileService.SearchByType("L. Penelope", fileName, SearchTypeEnum.Author);
            

            //CheckingOutBook(fileName, "Tomi Adeyemi");
            //FileService.PrintBooksFile(fileName);
            /*
            foreach (var book in bookList)
            {
                Console.WriteLine($"Title: {book.Title} Author: {book.Author}");
            }
            */
        }

        //public static void CheckingOutBook(string fileName, string userSelection)
        //{
        //    DateTime checkoutDay = DateTime.Now;
        //    DateTime bookDueDate = checkoutDay.AddDays(14);
        //    List<Book> books = FileService.ConvertCSVToArray(fileName);

        //    foreach (Book b in books)
        //    {
        //        if (b.Title.Equals(userSelection))
        //        {
        //            if (b.Status.Equals(false))
        //            {
        //                Console.WriteLine("This book is currently checked out.");

        //            }
        //            else
        //            {
        //                Console.WriteLine($"{userSelection} {bookDueDate}");

        //            }
        //        }
        //    }
        //}

        //public static void SearchByAuthor(string userInput, List<Book> bookList)
        //{
        //    var findBookByAuthor = bookList.Where(w => w.Author.Equals(userInput));
        //    Console.WriteLine(findBookByAuthor);
        //}

      
    }

}
