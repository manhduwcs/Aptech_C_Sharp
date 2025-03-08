// using System;

// namespace NSBook
// {
//     public class OnlineShopBook
//     {
//         Storage BookStorage = new Storage();
//         double Profits = 0;
//         public void ImportBook()
//         {
//             Console.Write("How many Books do you want to put in ? : ");
//             int n;
//             while (!int.TryParse(Console.ReadLine(), out n))
//             {
//                 Console.Write("Invalid books number. Try input again : ");
//             }

//             for (int i = 0; i < n; i++)
//             {
//                 Console.WriteLine($"Enter Book details for Book number {i + 1}");
//                 Book theBook = new Book();
//                 Console.Write("Enter name : ");
//                 string name = Console.ReadLine();
//                 Console.Write("Enter Authorname : ");
//                 string authorName = Console.ReadLine();
//                 Console.Write("Enter Subject : ");
//                 string subject = Console.ReadLine();
//                 Console.Write("Enter BuyingPrice : ");
//                 double buyingPrice;
//                 while (!double.TryParse(Console.ReadLine(), out buyingPrice))
//                 {
//                     Console.Write("Invalid Buying Price. Try to enter again : ");
//                 }

//                 theBook.SetDetail(name, authorName, subject, buyingPrice);
//                 theBook.ShowDetail();
//                 BookStorage.BookStore[i].SetDetail(name, authorName, subject, buyingPrice);
//             }
//         }

//         public void ShowDetail()
//         {
//             foreach (Book b in BookStorage.BookStore)
//             {
//                 b.ShowDetail();
//             }
//         }

//         public void Show()
//         {
//             foreach (Book b in BookStorage.BookStore)
//             {
//                 Console.WriteLine("Book ID : " + b.ID);
//                 Console.WriteLine("Name : " + b.Name);
//                 Console.WriteLine("AuthorName : " + b.AuthorName);
//                 Console.WriteLine("Subject : " + b.Subject);
//                 Console.WriteLine("SellingPrice : " + b.SellingPrice);
//             }
//         }

//         public void SellABook()
//         {
//             Show();
//             Console.WriteLine("Enter Book ID you want to buy : ");
//             int id;
//             while (!int.TryParse(Console.ReadLine(), out id))
//             {
//                 Console.WriteLine("We cannot find book with this ID. Please try again !");
//             }

//             bool sold = false;
//             while (!sold)
//             {
//                 Show();
//                 Console.Write("Enter Book ID you want to buy : ");
                

//                 foreach (Book b in BookStorage.BookStore)
//                 {
//                     if (b.ID.Equals(id))
//                     {
//                         Profits += b.SellingPrice - b.BuyingPrice;
//                         sold = true;
//                     }
//                 }
//                 if (!sold) Console.WriteLine("We cannot find book with this ID. Please try again !");
//             }
//         }
//     }
// }