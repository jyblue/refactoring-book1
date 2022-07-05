using chapter07.after;
using System;

namespace chapter07
{
    class Program
    {
        static void Main(string[] args)
        {
            Item book = new Item(
                ItemType.Book,
                "History",
                4800);

            Item dvd = new Item(
                ItemType.DVD,
                "New York",
                3000);

            Item soft = new Item(
                ItemType.Software,
                "Turing",
                3200);

            Console.WriteLine(book.ToString());
            Console.WriteLine(dvd.ToString());
            Console.WriteLine(soft.ToString());
        }
    }
}
