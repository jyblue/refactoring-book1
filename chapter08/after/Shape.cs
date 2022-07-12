using System;

namespace chapter08.after
{
    public class Shape
    {
        public const int TYPECODE_LINE = 0;
        public const int TYPECODE_RECTANGLE = 1;
        public const int TYPECODE_OVAL = 2;

        private readonly int typeCode;
        private readonly int startX;
        private readonly int startY;
        private readonly int endX;
        private readonly int endY;

        public Shape(
            int typeCode,
            int startX,
            int startY,
            int endX,
            int endY)
        {
            this.typeCode = typeCode;
            this.startX = startX;
            this.startY = startY;
            this.endX = endX;
            this.endY = endY;
        }

        public int GetTypeCode()
        {
            return typeCode;
        }

        public string GetName()
        {
            switch (typeCode)
            {
                case TYPECODE_LINE:
                    return "LINE";
                case TYPECODE_RECTANGLE:
                    return "REACTANGLE";
                case TYPECODE_OVAL:
                    return "OVAL";
                default:
                    return "NULL";
            }
        }

        public override string ToString()
        {
            return "[ "
                + GetName() + ", "
                + "(" + startX + ", " + startY + ")-"
                + "(" + endX + ", " + endY + ") ]";
        }

        public void Draw()
        {
            switch (typeCode)
            {
                case TYPECODE_LINE:
                    DrawLine();
                    break;
                case TYPECODE_RECTANGLE:
                    DrawRectangle();
                    break;
                case TYPECODE_OVAL:
                    DrawOval();
                    break;
                default:
                    break;
            }
        }

        private void DrawLine()
        {
            Console.WriteLine("DrawLine=" + this.ToString());
        }

        private void DrawRectangle()
        {
            Console.WriteLine("DrawRectangle=" + this.ToString());
        }

        private void DrawOval()
        {
            Console.WriteLine("DrawOval=" + this.ToString());
        }
    }
}
