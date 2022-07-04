using chapter05.before;

namespace chapter05
{
    class Program
    {
        static void Main(string[] args)
        {
            Banner banner = new Banner("Extract Method");
            banner.print(3);
        }
    }
}
