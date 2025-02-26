// OnlineShop.cs
using System;
using OnlineBookShop.BookShop;

namespace OnlineBookShop.StoreShop
{
    public class OnlineShop
    {
        private Storage _bookStorage = new Storage();
        private double _profits = 0;

        public void ImportBook()
        {
            Console.Write("Enter the number of books to import: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Invalid number of books.");
                return;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter details for book {i + 1}:");
                Console.Write("Enter book name: ");
                string name = Console.ReadLine();

                Console.Write("Enter author name: ");
                string authorName = Console.ReadLine();

                Console.Write("Enter subject: ");
                string subject = Console.ReadLine();

                Console.Write("Enter buying price: ");
                if (!double.TryParse(Console.ReadLine(), out double buyingPrice))
                {
                    Console.WriteLine("Invalid buying price. Book not added.");
                    continue;
                }

                Book newBook = new Book();
                newBook.SetDetail(name, authorName, subject, buyingPrice);
                _bookStorage.AddANewBook();
            }
        }

        public void ShowDetail()
        {
            if (_bookStorage.Count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }

            for (int i = 0; i < _bookStorage.Count; i++)
            {
                _bookStorage[i].ShowDetail();
                Console.WriteLine();
            }
        }

        public void Show()
        {
            if (_bookStorage.Count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }

            for (int i = 0; i < _bookStorage.Count; i++)
            {
                Console.WriteLine($"ID: {_bookStorage[i].ID}");
                Console.WriteLine($"Name: {_bookStorage[i].Name}");
                Console.WriteLine($"Author Name: {_bookStorage[i].AuthorName}");
                Console.WriteLine($"Subject: {_bookStorage[i].Subject}");
                Console.WriteLine($"Selling Price: {_bookStorage[i].SellingPrice}");
                Console.WriteLine();
            }
        }

        public void SellABook()
        {
            Show();
            Console.Write("Enter the ID of the book to buy: ");
            string id = Console.ReadLine();

            if (_bookStorage.IsBook(id))
            {
                for (int i = 0; i < _bookStorage.Count; i++)
                {
                    if (_bookStorage[i].ID == id)
                    {
                        _profits += _bookStorage[i].SellingPrice - _bookStorage[i].BuyingPrice;
                        _bookStorage.RemoveABook(id);
                        Console.WriteLine("Book sold successfully.");
                        return;
                    }
                }
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        public void ChangeSellingPrice()
        {
            ShowDetail();
            Console.Write("Enter the ID of the book to change selling price: ");
            string id = Console.ReadLine();

            if (_bookStorage.IsBook(id))
            {
                Console.Write("Enter the new selling price: ");
                if (!double.TryParse(Console.ReadLine(), out double newSellingPrice))
                {
                    Console.WriteLine("Invalid selling price.");
                    return;
                }

                for (int i = 0; i < _bookStorage.Count; i++)
                {
                    if (_bookStorage[i].ID == id)
                    {
                        _bookStorage[i].SetSellingPrice(newSellingPrice);
                        Console.WriteLine("Selling price updated successfully.");
                        return;
                    }
                }
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        public double GetProfits()
        {
            return _profits;
        }
    }
}