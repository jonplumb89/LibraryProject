using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating library book database
            List<Book> bookList = new List<Book>();
            bookList.Add(new Book()
            {
                Title = "Amari and the Night Brothers",
                Author = "B.B. Alston",
                Status = true,
                DueDate = "Date.now"
            });
            bookList.Add(new Book()
            {
                Title = "Children of Blood and Bone",
                Author = "Tomi Adeyemi",
                Status = true,
                DueDate = "Date.now"
            });
            bookList.Add(new Book()
            {
                Title = "Children of Virtue and Vengeance",
                Author = "Tomi Adeyemi",
                Status = true,
                DueDate = "Date.now"
            });
            bookList.Add(new Book()
            {
                Title = "The Coldest Winter Ever",
                Author = "Sister Souljah",
                Status = true,
                DueDate = "Date.now"
            });
            bookList.Add(new Book()
            {
                Title = "No Disrespect",
                Author = "Sister Souljah",
                Status = true,
                DueDate = "Date.now"
            });
            bookList.Add(new Book()
            {
                Title = "Firekeeper's Daughter",
                Author = "Angeline Boulley",
                Status = true,
                DueDate = "Date.now"
            });
            bookList.Add(new Book()
            {
                Title = "Etiquette and Espionage",
                Author = "Gail Carriger",
                Status = true,
                DueDate = "Date.now"
            });
            bookList.Add(new Book()
            {
                Title = "Soulless",
                Author = "Gail Carriger",
                Status = true,
                DueDate = "Date.now"
            });
            bookList.Add(new Book()
            {
                Title = "From Here to Timbuktu",
                Author = "Milton J. Davis",
                Status = true,
                DueDate = "Date.now"
            });
            bookList.Add(new Book()
            {
                Title = "Who Fears Death",
                Author = "Nnedi Okorafor",
                Status = true,
                DueDate = "Date.now"
            });
            bookList.Add(new Book()
            {
                Title = "Song of Blood and Stone",
                Author = "L. Penelope",
                Status = true,
                DueDate = "Date.now"
            });
            bookList.Add(new Book()
            {
                Title = "Obsidian and Blood",
                Author = "Aliette de Bodard",
                Status = true,
                DueDate = "Date.now"
            });

          
            
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
    }

}
