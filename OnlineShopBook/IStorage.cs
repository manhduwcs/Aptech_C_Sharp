// IStorage.cs
namespace OnlineBookShop.StoreShop
{
    using OnlineBookShop.BookShop;

    public interface IStorage
    {
        int Count { get; }
        Book this[int index] { get; set; }
        void AddANewBook();
        void RemoveABook(string id);
        bool IsBook(string id);
    }
}