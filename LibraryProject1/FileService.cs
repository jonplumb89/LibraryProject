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
    }
}
