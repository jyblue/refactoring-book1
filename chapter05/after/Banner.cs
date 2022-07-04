using System;

namespace chapter05.after
{
    public class Banner
    {
        private readonly string _content;

        public Banner(string content)
        {
            this._content = content;
        }

        public void Print(int times)
        {
            PrintBorder();

            PrintContent(times);

            PrintBorder();
        }

        private void PrintContent(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("|" + _content + "|");
            }
        }

        private void PrintBorder()
        {
            Console.Write("+");
            for (int i = 0; i < _content.Length; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
        }
    }
}
