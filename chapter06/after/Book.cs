namespace chapter06.after
{
    public class Book
    {
        private string title;
        private string isbn;
        private string price;

        private Author author;

        public Book(string title, string isbn, string price, string authorName, string authorMail)
        {
            this.title = title;
            this.isbn = isbn;
            this.price = price;

            author = new Author(authorName, authorMail);
        }
        public string GetTitle() { return title; }
        public string GetIsbn() { return isbn; }
        public string GetPrice() { return price; }
        public string GetAuthorName() { return author.GetName(); }
        public string GetAuthorMail() { return author.GetMail(); }
        public void SetAuthorName(string name) { author.SetName(name); }
        public void SetAuthorMail(string mail) { author.SetMail(mail); }
        public override string ToString()
        {
            string author = Tag("author", Tag("name", this.author.GetName()) + Tag("mail", this.author.GetMail()));
            string book = Tag("book", Tag("title", title) + Tag("isbn", isbn) + Tag("price", price) + author);

            return book;
        }
        private string Tag(string element, string content)
        {
            return "<" + element + ">" + content + "</" + element + ">";
        }

        public IImmutableAuthor GetAuthor()
        {
            return author;
        }
    }
}
