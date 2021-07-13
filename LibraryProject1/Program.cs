using System;
using System.Collections.Generic;

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
        }
    }
}
