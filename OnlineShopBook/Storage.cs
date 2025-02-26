// Storage.cs
using System;
using OnlineBookShop.BookShop;

namespace OnlineBookShop.StoreShop
{
    public class Storage : IStorage
    {
        private int _count = 0;
        private Book[] _bookStore = new Book[100];

        public int Count
        {
            get => _count;
            set => _count = value;
        }

        public Book this[int index]
        {
            get
            {
                if (index >= 0 && index < _count)
                {
                    return _bookStore[index];
                }
                throw new IndexOutOfRangeException("Index must be between 0 and Count - 1.");
            }
            set
            {
                if (index >= 0 && index < _count)
                {
                    _bookStore[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index must be between 0 and Count - 1.");
                }
            }
        }

        public void AddANewBook()
        {
            if (_count >= 100)
            {
                Console.WriteLine("Book store is full.");
                return;
            }

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
                return;
            }

            Book newBook = new Book();
            newBook.SetDetail(name, authorName, subject, buyingPrice);
            _bookStore[_count++] = newBook;
            Console.WriteLine("Book added successfully.");
        }

        public void RemoveABook(string id)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_bookStore[i].ID == id)
                {
                    for (int j = i; j < _count - 1; j++)
                    {
                        _bookStore[j] = _bookStore[j + 1];
                    }
                    _count--;
                    Console.WriteLine("Book removed successfully.");
                    return;
                }
            }
            Console.WriteLine("Book not found.");
        }

        public bool IsBook(string id)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_bookStore[i].ID == id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}