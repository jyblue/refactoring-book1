using System;

namespace chapter08.after
{
    public abstract class Shape
    {
        public const int TYPECODE_LINE = 0;
        public const int TYPECODE_RECTANGLE = 1;
        public const int TYPECODE_OVAL = 2;

        private readonly int startX;
        private readonly int startY;
        private readonly int endX;
        private readonly int endY;

        protected Shape(
            int startX,
            int startY,
            int endX,
            int endY)
        {
            this.startX = startX;
            this.startY = startY;
            this.endX = endX;
            this.endY = endY;
        }

        public abstract int GetTypeCode();

        public abstract string GetName(); 

        public override string ToString()
        {
            return "[ "
                + GetName() + ", "
                + "(" + startX + ", " + startY + ")-"
                + "(" + endX + ", " + endY + ") ]";
        }

        public abstract void Draw();

      

        private void DrawOval()
        {
            
        }

        public static Shape Create(
            int typeCode,
            int startX,
            int startY,
            int endX,
            int endY)
        {
            switch (typeCode)
            {
                case TYPECODE_LINE: return new ShapeLine(startX, startY, endX, endY);
                case TYPECODE_RECTANGLE: return new ShapeRectangle(startX, startY, endX, endY);
                case TYPECODE_OVAL: return new ShapeOval(startX, startY, endX, endY);
                default: throw new ArgumentOutOfRangeException(nameof(typeCode));
            }
        }
    }
}
