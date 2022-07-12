using System;

namespace chapter08.after
{
    public class ShapeOval : Shape
    {
        public ShapeOval(int startX, int startY, int endX, int endY) : base(startX, startY, endX, endY)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("DrawOval=" + this.ToString());
        }

        public override string GetName()
        {
            return "Oval";
        }

        public override int GetTypeCode()
        {
            return Shape.TYPECODE_OVAL;
        }
    }
}
