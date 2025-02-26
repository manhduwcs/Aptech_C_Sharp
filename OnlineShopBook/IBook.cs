// IBook.cs
namespace OnlineBookShop.BookShop
{
    public interface IBook
    {
        string ID { get; }
        string Name { get; set; }
        string AuthorName { get; set; }
        string Subject { get; set; }
        double BuyingPrice { get; set; }
        double SellingPrice { get; set; }
        void ShowDetail();
        void SetDetail(string name, string authorname, string subject, double buyingprice);
        void SetSellingPrice(double newSellingPrice);
    }
}