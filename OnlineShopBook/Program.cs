// // Program.cs
// using System;
// using OnlineBookShop.StoreShop;

// namespace OnlineBookShop
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             OnlineShop bookShop = new OnlineShop();

//             // Sample data
//             bookShop.ImportBook();
//             bookShop.ImportBook();
//             bookShop.ImportBook();

//             while (true)
//             {
//                 Console.WriteLine("1. Admin");
//                 Console.WriteLine("2. Custom");
//                 Console.WriteLine("3. Exit");
//                 Console.Write("Choose an option: ");
//                 string choice = Console.ReadLine();

//                 switch (choice)
//                 {
//                     case "1":
//                         AdminMenu(bookShop);
//                         break;
//                     case "2":
//                         CustomMenu(bookShop);
//                         break;
//                     case "3":
//                         return;
//                     default:
//                         Console.WriteLine("Invalid option. Please try again.");
//                         break;
//                 }
//             }
//         }

//         static void AdminMenu(OnlineShop bookShop)
//         {
//             while (true)
//             {
//                 Console.WriteLine("1. Import book to the store");
//                 Console.WriteLine("2. Show the store in detail");
//                 Console.WriteLine("3. Change a book selling price");
//                 Console.WriteLine("4. Show profits");
//                 Console.WriteLine("5. Back");
//                 Console.Write("Choose an option: ");
//                 string choice = Console.ReadLine();

//                 switch (choice)
//                 {
//                     case "1":
//                         bookShop.ImportBook();
//                         break;
//                     case "2":
//                         bookShop.ShowDetail();
//                         break;
//                     case "3":
//                         bookShop.ChangeSellingPrice();
//                         break;
//                     case "4":
//                         Console.WriteLine($"Profits: {bookShop.GetProfits()}");
//                         break;
//                     case "5":
//                         return;
//                     default:
//                         Console.WriteLine("Invalid option. Please try again.");
//                         break;
//                 }
//             }
//         }

//         static void CustomMenu(OnlineShop bookShop)
//         {
//             while (true)
//             {
//                 Console.WriteLine("1. Show all books of store");
//                 Console.WriteLine("2. Buy a book");
//                 Console.WriteLine("3. Back");
//                 Console.Write("Choose an option: ");
//                 string choice = Console.ReadLine();

//                 switch (choice)
//                 {
//                     case "1":
//                         bookShop.Show();
//                         break;
//                     case "2":
//                         bookShop.SellABook();
//                         break;
//                     case "3":
//                         return;
//                     default:
//                         Console.WriteLine("Invalid option. Please try again.");
//                         break;
//                 }
//             }
//         }
//     }
// }