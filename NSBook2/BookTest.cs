// BookTest.cs
using System;
using System.Collections.Generic;

namespace NSBook2
{
    public class BookTest
    {
        private Dictionary<int, IBook> _books = new Dictionary<int, IBook>();

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("1. Add a new book");
                Console.WriteLine("2. List all books");
                Console.WriteLine("3. Calculate and display average prices");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddBook();
                        break;
                    case "2":
                        ListBooks();
                        break;
                    case "3":
                        CalculateAndDisplay();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        private void AddBook()
        {
            Book book = new Book();

            Console.Write("Enter book name: ");
            book.Name = Console.ReadLine();

            Console.Write("Enter publish date (dd/MM/yyyy): ");
            if (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime publishDate))
            {
                Console.WriteLine("Invalid date format. Book not added.");
                return;
            }
            book.PublishDate = publishDate;

            Console.Write("Enter author: ");
            book.Author = Console.ReadLine();

            Console.Write("Enter language: ");
            book.Language = Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter price {i + 1} (or leave empty if not available): ");
                string priceInput = Console.ReadLine();
                if (!string.IsNullOrEmpty(priceInput) && int.TryParse(priceInput, out int price))
                {
                    book[i] = price;
                }
            }

            _books.Add(book.ID, book);
            Console.WriteLine("Book added successfully.");
        }

        private void ListBooks()
        {
            if (_books.Count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }

            foreach (var book in _books.Values)
            {
                book.Display();
                Console.WriteLine();
            }
        }

        private void CalculateAndDisplay()
        {
            if (_books.Count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }

            foreach (var book in _books.Values)
            {
                book.Calculate();
                book.Display();
                Console.WriteLine();
            }
        }
    }
}