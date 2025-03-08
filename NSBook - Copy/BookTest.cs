using System;
using NSBook;

class BookTest
{
    static void Main(string[] args){
        Book theBook = new Book();
        Console.Write("Enter name : ");
        string name = Console.ReadLine();
        Console.Write("Enter Authorname : ");
        string authorName = Console.ReadLine();
        Console.Write("Enter Subject : ");
        string subject = Console.ReadLine();
        Console.Write("Enter BuyingPrice : ");
        double buyingPrice;
        while(!double.TryParse(Console.ReadLine(), out buyingPrice)){
            Console.Write("Invalid Buying Price. Try to enter again : ");
        }

        theBook.SetDetail(name,authorName,subject,buyingPrice);
        theBook.ShowDetail();
        if(Console.Read().Equals("x")) return;
    }
}