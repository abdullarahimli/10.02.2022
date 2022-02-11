using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    class Book
    {
        public string Name;
        public string Author;
        public int PageCount;

       
        public Book (string name, int pageCount)
        {
            Name = name;
            PageCount = pageCount;

            if (pageCount <= 10)
            {
                Console.WriteLine("Sehife azdir");
            }
            else if (name.Length <= 3)
            {
                Console.WriteLine("Duzgun daxil et");
            }
        }

       
    }
}
