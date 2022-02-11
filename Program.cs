using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kitabi daxil edin");
            string Name = Console.ReadLine();
            Console.WriteLine("Ikinci Kitabi daxil edin");
            string Name1 = Console.ReadLine();
            Console.WriteLine("Sehifeni daxil edin");
            int PageCount = int.Parse(Console.ReadLine());
            
            string[] arr = new string[10];
           
            Book book1 = new Book(Name, PageCount);

            //book1.Name = "";
            //book1.Author = "";
            //book1.PageCount = 2;

            //Book book2 = new Book("Psikoloji", 650);

            //book2.Name = "Psikoloji";
            //book2.Author = "Anonyms";
            //book2.PageCount = 650;

            Console.WriteLine(book1.Name);
            Console.WriteLine(book1.PageCount);
        }
    }
}
