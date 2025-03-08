namespace NSBook
{
    class Storage : IStorage
    {
        private int _Count;
        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }

        public Book[] BookStore { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Book this[int index]
        {
            get { return BookStore[index]; }
            set { BookStore[index] = value; }
        }

        public Storage(){
            Count = 0;
            BookStore = new Book[100];
        }

        public void AddANewBook()
        {
            Book theBook = new Book();
            Console.Write("Enter name : ");
            string name = Console.ReadLine();
            Console.Write("Enter Authorname : ");
            string authorName = Console.ReadLine();
            Console.Write("Enter Subject : ");
            string subject = Console.ReadLine();
            Console.Write("Enter BuyingPrice : ");
            double buyingPrice;
            while (!double.TryParse(Console.ReadLine(), out buyingPrice))
            {
                Console.Write("Invalid Buying Price. Try to enter again : ");
            }

            theBook.SetDetail(name, authorName, subject, buyingPrice);
            Count++;
            theBook.ShowDetail();
        }

        public void RemoveABook(string id)
        {
            foreach(Book b in BookStore){
                if(b.ID.Equals(id)){
                    BookStore.ToList().Remove(b);
                }
            }
        }

        public bool IsABook(string id)
        {
            foreach(Book b in BookStore){
                if(b.ID.Equals(id)) return true;
            }
            return false;
        }
    }
}