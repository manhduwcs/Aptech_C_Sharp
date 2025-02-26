// Book.cs
using System;

namespace OnlineBookShop.BookShop
{
    public class Book : IBook
    {
        private static int _count = 0;
        private string _id;
        private string _name;
        private string _authorName;
        private string _subject;
        private double _buyingPrice;
        private double _sellingPrice;

        public Book()
        {
            _count++;
            _id = "B" + _count.ToString("D3");
        }

        public string ID => _id;
        public string Name { get => _name; set => _name = value; }
        public string AuthorName { get => _authorName; set => _authorName = value; }
        public string Subject { get => _subject; set => _subject = value; }
        public double BuyingPrice { get => _buyingPrice; set => _buyingPrice = value; }
        public double SellingPrice { get => _sellingPrice; set => _sellingPrice = value; }

        public void ShowDetail()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Author Name: {AuthorName}");
            Console.WriteLine($"Subject: {Subject}");
            Console.WriteLine($"Buying Price: {_buyingPrice}");
            Console.WriteLine($"Selling Price: {_sellingPrice}");
        }

        public void SetDetail(string name, string authorname, string subject, double buyingprice)
        {
            Name = name;
            AuthorName = authorname;
            Subject = subject;
            BuyingPrice = buyingprice;
            SellingPrice = buyingprice * 1.3; // Selling price is 30% more than buying price
        }

        public void SetSellingPrice(double newSellingPrice)
        {
            SellingPrice = newSellingPrice;
        }
    }
}