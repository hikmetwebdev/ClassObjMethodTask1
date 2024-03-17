
using ClassHomeT1.Modes;
using System;

class Program
{
    static void Main(string[] args)
    {
        Book[] books = new Book[2];

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine($"Add element {i+1} : ");
            string element=Console.ReadLine();

            while (element.Length<3)
            {
                Console.WriteLine("Book length should be minimun 3 characters");
                element = Console.ReadLine();
            }

            Console.WriteLine($"Add page count {i+1}: ");
            int pageCount=int.Parse(Console.ReadLine());
            while (pageCount<10)
            {
                Console.WriteLine("Pagecount should be more than 10 !  Try again: ");
                pageCount=int.Parse(Console.ReadLine());
            }

            Book book = new Book();
            book.Name = element;
            book.PageCount = pageCount;
            books[i] = book;

            Console.WriteLine("Books: ");

        
        }
        foreach (var item in books)
        {
            Console.WriteLine($"Book Name: {item.Name}+ PageCount: {item.PageCount}");
        }
    }
}









