namespace chapter06.after
{
    class Author : IImmutableAuthor
    {
        private string name;
        private string mail;

        public Author(string name, string mail)
        {
            this.name = name;
            this.mail = mail;
        }

        public string GetName()
        {
            return name;
        }

        public string GetMail()
        {
            return mail;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetMail(string mail)
        {
            this.mail = mail;
        }
    }
}
