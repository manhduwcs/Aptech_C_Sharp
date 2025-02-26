// Book.cs
using System;
using System.Linq;

namespace NSBook2
{
    public class Book : IBook
    {
        private static int _idCounter = 0;

        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime PublishDate { get; set; }
        public string Author { get; set; }
        public string Language { get; set; }
        public float AveragePrice { get; private set; }
        public int?[] PriceList { get; set; }

        public Book()
        {
            ID = ++_idCounter;
            PriceList = new int?[5];
        }

        public void Display()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Publish Date: {PublishDate.ToShortDateString()}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Language: {Language}");
            Console.WriteLine($"Average Price: {AveragePrice}");
        }

        public int? this[int index]
        {
            get
            {
                if (index >= 0 && index < PriceList.Length)
                {
                    return PriceList[index];
                }
                throw new IndexOutOfRangeException("Index must be between 0 and 4.");
            }
            set
            {
                if (index >= 0 && index < PriceList.Length)
                {
                    PriceList[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index must be between 0 and 4.");
                }
            }
        }

        public void Calculate()
        {
            var prices = PriceList.Where(p => p.HasValue).Select(p => p.Value);
            if (prices.Any())
            {
                AveragePrice = (float)prices.Average();
            }
            else
            {
                AveragePrice = 0;
            }
        }
    }
}