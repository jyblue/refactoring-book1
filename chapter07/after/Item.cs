namespace chapter07.after
{
    public class Item
    {
        private readonly ItemType itemType;
        private readonly string title;
        private readonly int price;

        public Item(
            ItemType itemType,
            string title,
            int price)
        {
            this.itemType = itemType;
            this.title = title;
            this.price = price;
        }

        public int GetTypeCode() { return itemType.GetTypeCode(); }
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
