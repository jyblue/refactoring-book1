namespace chapter07.after
{
    public class ItemType
    {
        public static readonly ItemType Book = new ItemType(0);
        public static readonly ItemType DVD = new ItemType(1);
        public static readonly ItemType Software = new ItemType(2);

        private int typeCode;

        private ItemType(int typeCode)
        {
            this.typeCode = typeCode;
        }

        public int GetTypeCode()
        {
            return typeCode;
        }

        public static ItemType GetItemType(int typeCode)
        {
            switch (typeCode)
            {
                case 0: return Book;
                case 1: return DVD;
                case 2: return Software;
                default: return null;
            }
        }
    }
}
