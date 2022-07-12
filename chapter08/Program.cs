using chapter08.after;

namespace chapter08
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape line = Shape.Create(0, 0, 100, 200);
            Shape rectangle = Shape.Create(10, 20, 30, 40);
            Shape oval = Shape.Create(100, 200, 300, 400);

            Shape[] shape =
            {
                line, rectangle, oval
            };

            foreach(Shape s in shape)
            {
                s.Draw();
            }
        }
    }
}
