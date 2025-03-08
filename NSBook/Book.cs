namespace NSBook
{
    class Book : IBook
    {
        private static int Count = 0;
        private string _ID;
        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private string _AuthorName;
        public string AuthorName
        {
            get { return _AuthorName; }
            set { _AuthorName = value; }
        }

        private string _Subject;
        public string Subject {
            get {return _Subject;}
            set {_Subject = value;}
        }

        private double _SellingPrice;
        public double SellingPrice{
            get { return _SellingPrice;}
            set {_SellingPrice = value;}
        }

        private double _BuyingPrice;
        public double BuyingPrice {
            get { return _BuyingPrice;}
            set{ _BuyingPrice = value;}
        }

        public Book(){
            _ID = "B00".Substring(0,4 - Count.ToString().Length) + Count++;
            Name = "";
            AuthorName = "";
            Subject = "";
            BuyingPrice = 0;
            SellingPrice = 0;
        }

        public void ShowDetail(){
            Console.WriteLine($"Book ID : {_ID}, Name : {_Name}, AuthorName : {_AuthorName}, Subject : {_Subject}, BuyingPrice : {_BuyingPrice}, SellingPrice : {_SellingPrice}");
        }

        public void SetDetail(string name, string authorName, string subject, double buyingPrice){
            _Name = name;
            _AuthorName = authorName;
            _Subject = subject;
            _BuyingPrice = buyingPrice;
        }

        public void setSellingPrice(double sellingPrice){
            _SellingPrice = sellingPrice;
        }
    }
}

