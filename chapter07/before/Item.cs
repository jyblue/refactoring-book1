namespace chapter07.before
{
    public class Item
    {
        public static readonly int TYPECODE_BOOK = 0;
        public static readonly int TYPECODE_DVD = 1;
        public static readonly int TYPECODE_SOFTWARE = 2;

        private readonly int typecode;
        private readonly string title;
        private readonly int price;

        public Item(
            int typecode,
            string title,
            int price)
        {
            this.typecode = typecode;
            this.title = title;
            this.price = price;
        }

        public int GetTypeCode() { return typecode; }
        public string GetTitle() { return title; }
        public int GetPrice() { return price; }
        public override string ToString()
        {
            return "[" 
                + GetTypeCode() + ","
                + GetTitle() + ","
                + GetPrice() + "]";
        }
    }
}
