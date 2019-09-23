using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Ulysses", "James Joyce", "Modernist novel", "English", 730, new DateTime(1922, 2, 2));
            Console.WriteLine(book1.ToString());
        }
    }
}
