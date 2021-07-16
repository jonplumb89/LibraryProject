using System;
using System.Collections.Generic;

namespace LibraryProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating library file
           // text = text.PadLeft(35);
            var fileName = "library.txt";
            FileService.CreateFile(fileName);
            // creating library book database
            List<Book> bookList = new List<Book>();

            bookList.Add(new Book()
            {
                BookID = "1:",
                Title = "Amari and the Night Brothers",
                Author = "B.B. Alston",
                Status = true,
                DueDate = DateTime.Now
            }); ;
            bookList.Add(new Book()
            {
                BookID = "2:",
                Title = "Children of Blood and Bone",
                Author = "Tomi Adeyemi",
                Status = true,
                DueDate = DateTime.Now
            });
            bookList.Add(new Book()
            {
                BookID = "3:",
                Title = "Children of Virtue and Vengeance",
                Author = "Tomi Adeyemi",
                Status = true,
                DueDate = DateTime.Now
            });
            bookList.Add(new Book()
            {
                BookID = "4:",
                Title = "The Coldest Winter Ever",
                Author = "Sister Souljah",
                Status = true,
                DueDate = DateTime.Now
            });
            bookList.Add(new Book()
            {
                BookID = "5:",
                Title = "No Disrespect",
                Author = "Sister Souljah",
                Status = true,
                DueDate = DateTime.Now
            });
            bookList.Add(new Book()
            {
                BookID = "6:",
                Title = "Firekeeper's Daughter",
                Author = "Angeline Boulley",
                Status = true,
                DueDate = DateTime.Now
            });
            bookList.Add(new Book()
            {
                BookID ="7:",
                Title = "Etiquette and Espionage",
                Author = "Gail Carriger",
                Status = true,
                DueDate = DateTime.Now
            });
            bookList.Add(new Book()
            {
                BookID = "8:",
                Title = "Soulless",
                Author = "Gail Carriger",
                Status = true,
                DueDate = DateTime.Now
            });
            bookList.Add(new Book()
            {
                BookID ="9:",
                Title = "From Here to Timbuktu",
                Author = "Milton J. Davis",
                Status = true,
                DueDate = DateTime.Now
            });
            bookList.Add(new Book()
            {
                BookID ="10:",
                Title = "Who Fears Death",
                Author = "Nnedi Okorafor",
                Status = true,
                DueDate = DateTime.Now
            });
            bookList.Add(new Book()
            {
                BookID ="11:",
                Title = "Song of Blood and Stone",
                Author = "L. Penelope",
                Status = true,
                DueDate = DateTime.Now
            });
            bookList.Add(new Book()
            {
                BookID="12:",
                Title = "Obsidian and Blood",
                Author = "Aliette de Bodard",
                Status = true,
                DueDate = DateTime.Now
            });

            foreach (var Book in bookList)
            {
                Console.WriteLine($"{Book.BookID,5}  {Book.Title,8} \t by\t {Book.Author}");
            }

            

           // FileService.SaveArrayAsCSV<Book>(bookList, fileName);
           // FileService.ConvertCSVToArray(fileName);
        }
    }
}
