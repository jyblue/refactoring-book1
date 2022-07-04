using System;

namespace chapter05.before
{
    public class Banner
    {
        private readonly string _content;

        public Banner(string content)
        {
            this._content = content;
        }

        public void print(int times)
        {
            // 테두리 출력
            Console.Write("+");
            for (int i = 0; i < _content.Length; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");

            // 내용 출력
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("|" + _content + "|");
            }

            // 테두리 출력
            Console.Write("+");
            for (int i = 0; i < _content.Length; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
        }
    }
}
