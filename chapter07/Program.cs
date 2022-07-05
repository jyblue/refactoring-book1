using chapter07.before;
using System;

namespace chapter07
{
    class Program
    {
        static void Main(string[] args)
        {
            Item book = new Item(
                Item.TYPECODE_BOOK,
                "History",
                4800);

            Item dvd = new Item(
                Item.TYPECODE_DVD,
                "New York",
                3000);

            Item soft = new Item(
                Item.TYPECODE_SOFTWARE,
                "Turing",
                3200);

            Console.WriteLine(book.ToString());
            Console.WriteLine(dvd.ToString());
            Console.WriteLine(soft.ToString());
        }
    }
}
