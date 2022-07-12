using System;

namespace chapter08.after
{
    public class ShapeLine : Shape
    {
        public ShapeLine(int startX, int startY, int endX, int endY) : base(startX, startY, endX, endY)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("DrawLine=" + this.ToString());
        }

        public override string GetName()
        {
            return "Line";
        }

        public override int GetTypeCode()
        {
            return Shape.TYPECODE_LINE;
        }
    }
}
