using System;

namespace chapter08.after
{
    public class ShapeRectangle : Shape
    {
        public ShapeRectangle(int startX, int startY, int endX, int endY) : base(startX, startY, endX, endY)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("DrawRectangle=" + this.ToString());
        }

        public override string GetName()
        {
            return "Rectangle";
        }

        public override int GetTypeCode()
        {
            return Shape.TYPECODE_RECTANGLE;
        }
    }
}
