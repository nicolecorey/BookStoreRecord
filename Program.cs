using System;
using System.Security.Cryptography.X509Certificates;

namespace BookStoreRecord
{
    class Program
    {
        public record bookstore (int ID, string Author, string Title, double Price);

        public static void Main()
        {

            bookstore bookstore = new(1,"Jane", "Doe", 20);
            Console.WriteLine(bookstore);

            bookstore bookstore2 = new(2, "Bill", "Nye", 25);
            Console.WriteLine(bookstore2);

            bookstore bookstore3 = new(3, "John", "Smith", 30);
            Console.WriteLine(bookstore3);
        }
    }
}