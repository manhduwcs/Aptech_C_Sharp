// IBook.cs
using System;

namespace NSBook2
{
    public interface IBook
    {
        int ID { get; set; }
        string Name { get; set; }
        DateTime PublishDate { get; set; }
        string Author { get; set; }
        string Language { get; set; }
        float AveragePrice { get; }
        int?[] PriceList { get; set; }
        void Display();
        void Calculate();
    }
}