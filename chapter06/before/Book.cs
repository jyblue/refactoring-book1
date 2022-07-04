namespace chapter06.before
{
    public class Book
    {
        private string title;
        private string isbn;
        private string price;
        private string authorName;
        private string authorMail;
        
        public Book(string title, string isbn, string price, string authorName, string authorMail)
        {
            this.title = title;
            this.isbn = isbn;
            this.price = price;
            this.authorName = authorName;
            this.authorMail = authorMail;
        }

        public string GetTitle() { return title; }

        public string GetIsbn() { return isbn; }

        public string GetPrice() { return price; }

        public string GetAuthorName() { return authorName; }

        public string GetAuthorMail() { return authorMail; }

        public override string ToString()
        {
            string author = Tag("author", Tag("name", authorName) + Tag("mail", authorMail));
            string book = Tag("book", Tag("title", title) + Tag("isbn", isbn) + Tag("price", price) + author);

            return book;
        }

        private string Tag(string element, string content)
        {
            return "<" + element + ">" + content + "</" + element + ">";
        }
    }
}
