using chapter06.before;
using System;

namespace chapter06
{
    class Program
    {
        static void Main(string[] args)
        {
            Book refactoringBook = new Book(
                "Refactoring",
                "ISBN1234",
                "$10.00",
                "Martin Fowler",
                "m@abc.com");

            Book javaBook = new Book(
                "Java",
                "ISBN1313",
                "$12.00",
                "Goooosling",
                "g@bbb.com");

            Console.WriteLine("refactoring:");
            Console.WriteLine(refactoringBook.ToString());

            Console.WriteLine("java:");
            Console.WriteLine(javaBook.ToString());
        }
    }
}
