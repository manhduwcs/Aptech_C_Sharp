using System;
using NSBook;

class BookTest
{
    static bool IsBlank(string str)
    {
        if (str.Length == 0) return true;
        int Count = 0;
        foreach (char c in str.ToCharArray())
        {
            if (c == ' ') Count++;
        }
        return Count < str.Length;
    }
    // static void Main(string[] args)
    // {
    //     int option = 0;

    //     // Dictionary 
    //     Dictionary<int, IBook> BookDictionary = new Dictionary<int, IBook>();

    //     while (option != 4)
    //     {
    //         try
    //         {
    //             Console.WriteLine("Please select an option : \n1.Insert new book \n2. View list of books \n3. Average Price \n4. Exit...");
    //             Console.WriteLine("Your option = ");
    //             string? inputOption = Console.ReadLine();
    //             if (inputOption == null) throw new Exception("Input cannot be null");
    //             try
    //             {
    //                 option = int.Parse(inputOption);
    //                 if (option < 1 || option > 4) throw new Exception();
    //             }
    //             catch (System.Exception)
    //             {
    //                 throw new Exception("Invalid argument : Option must be from 1 to 4");
    //             }

    //             if (option == 1)
    //             {
    //                 Book book = new Book();

    //                 // Get Name
    //                 Console.WriteLine("Input Name = ");
    //                 string? inputName = Console.ReadLine();
    //                 if (inputName == null || IsBlank(inputName)) throw new Exception("Name must not be empty !");
    //                 while (inputName == null || IsBlank(inputName))
    //                 {
    //                     Console.WriteLine("Invalid name. Please enter a non-empty name.");
    //                     inputName = Console.ReadLine();
    //                 }
    //                 book.Name = inputName;

    //                 Console.WriteLine("Publish Date = ");
    //                 DateTime inputPublishDate;
    //                 while (!DateTime.TryParse(Console.ReadLine(), out inputPublishDate))
    //                 {
    //                     Console.WriteLine("Invalid date format. Please enter a valid date (MM/dd/yyyy): ");
    //                 }
    //                 book.PublishDate = inputPublishDate;

    //                 static bool IsBlank(string str) => string.IsNullOrWhiteSpace(str);

    //                 // Get Author
    //                 string? inputAuthor;
    //                 do
    //                 {
    //                     Console.WriteLine("Author: ");
    //                     inputAuthor = Console.ReadLine();
    //                     if (inputAuthor == null || IsBlank(inputAuthor))
    //                     {
    //                         Console.WriteLine("Author must not be empty!");
    //                     }
    //                 } while (inputAuthor == null || IsBlank(inputAuthor));
    //                 book.Author = inputAuthor;

    //                 // Get Language
    //                 string? inputLanguage;
    //                 do
    //                 {
    //                     Console.WriteLine("Language: ");
    //                     inputLanguage = Console.ReadLine();
    //                     if (inputLanguage == null || IsBlank(inputLanguage))
    //                     {
    //                         Console.WriteLine("Language must not be empty!");
    //                     }
    //                 } while (inputLanguage == null || IsBlank(inputLanguage));
    //                 book.Language = inputLanguage;

    //                 // Get Prices
    //                 for (int i = 0; i < 5; i++)
    //                 {
    //                     string? inputPrice;
    //                     bool validPrice;
    //                     do
    //                     {
    //                         Console.Write($"Price {i}: ");
    //                         inputPrice = Console.ReadLine();
    //                         validPrice = true;

    //                         if (inputPrice == null || IsBlank(inputPrice))
    //                         {
    //                             Console.WriteLine("Price cannot be empty!");
    //                             validPrice = false;
    //                         }
    //                         else
    //                         {
    //                             try
    //                             {
    //                                 book.PriceList[i] = int.Parse(inputPrice);
    //                             }
    //                             catch (FormatException)
    //                             {
    //                                 Console.WriteLine("Invalid price format! Please enter a valid integer.");
    //                                 validPrice = false;
    //                             }
    //                         }
    //                     } while (!validPrice);
    //                 }

    //                 BookDictionary.Add(book.ID, book);
    //                 // 
    //             }

    //             if(option==2){
    //                 foreach(Book book in BookDictionary.Values){
    //                     book.Display();
    //                 }
    //             }

    //             if(option==3){
    //                 foreach(Book book in BookDictionary.Values){
    //                     book.Calculate();
    //                     book.Display();
    //                 }
    //             }

    //             if(option==4){
    //                 Console.WriteLine("Exit the program ...");
    //                 return;
    //             }
    //         }
    //         catch (System.Exception e)
    //         {
    //             Console.WriteLine("Error : " + e.Message);
    //             option = 0;
    //         }
    //     }
    // }
}