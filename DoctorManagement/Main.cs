// using System;
// using System.Collections;
// using DoctorManagement;

// namespace DoctorManagementSystem
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             DoctorManagement doctorManagement = new DoctorManagement();
//             int idCounter = 0; // ID auto-incrementer

//             while (true)
//             {
//                 Console.WriteLine("PLEASE CHOOSE AN OPTION:");
//                 Console.WriteLine("1. Add new Doctor");
//                 Console.WriteLine("2. View list of Doctor");
//                 Console.WriteLine("3. Sort Doctor by Rank");
//                 Console.WriteLine("4. Delete a Doctor");
//                 Console.WriteLine("5. Search Doctor By Email");
//                 Console.WriteLine("6. Exit");

//                 string option = Console.ReadLine();

//                 switch (option)
//                 {
//                     case "1":
//                         // Add new Doctor
//                         Console.Write("Enter Name: ");
//                         string name = Console.ReadLine();

//                         Console.Write("Enter BirthDay (yyyy-mm-dd): ");
//                         DateTime birthDay;
//                         while (!DateTime.TryParse(Console.ReadLine(), out birthDay))
//                         {
//                             Console.Write("Invalid format. Please enter BirthDay (yyyy-mm-dd): ");
//                         }

//                         Console.Write("Enter Speciality: ");
//                         string speciality = Console.ReadLine();

//                         Console.Write("Enter Email: ");
//                         string email = Console.ReadLine();

//                         Console.Write("Enter Rank: ");
//                         int rank = int.Parse(Console.ReadLine());

//                         // Create a new Doctor instance
//                         Doctor doctor = new Doctor
//                         {
//                             ID = idCounter++, // Auto-increment ID
//                             Name = name,
//                             BirthDay = birthDay,
//                             Speciality = speciality,
//                             Email = email,
//                             Rank = rank,
//                         };

//                         // Input 3 phone numbers
//                         for (int i = 0; i < 3; i++)
//                         {
//                             Console.Write($"Enter Phone {i + 1}: ");
//                             string phone = Console.ReadLine();
//                             doctor[i] = phone; // Using indexer to add phone
//                         }

//                         doctorManagement.Add(doctor);
//                         Console.WriteLine("Doctor added successfully!");
//                         break;

//                     case "2":
//                         // View list of Doctor
//                         foreach (var doc in doctorManagement.doctorList)
//                         {
//                             if (doc is IDoctor)
//                             {
//                                 ((IDoctor)doc).ShowInfo();
//                             }
//                         }
//                         break;

//                     case "3":
//                         // Sort Doctor by Rank
//                         doctorManagement.Sort(new SortByRank());
//                         Console.WriteLine("Doctors sorted by Rank!");
//                         break;

//                     case "4":
//                         // Delete a Doctor
//                         Console.Write("Enter Doctor ID to delete: ");
//                         int deleteId = int.Parse(Console.ReadLine());
//                         var doctorToRemove = doctorManagement.doctorList.Find(d => ((IDoctor)d).ID == deleteId) as IDoctor;
//                         if (doctorToRemove != null)
//                         {
//                             doctorManagement.Remove(doctorToRemove);
//                             Console.WriteLine("Doctor deleted successfully!");
//                         }
//                         else
//                         {
//                             Console.WriteLine("Doctor not found!");
//                         }
//                         break;

//                     case "5":
//                         // Search Doctor By Email
//                         Console.Write("Enter Email to search: ");
//                         string searchEmail = Console.ReadLine();
//                         var foundDoctor = doctorManagement.doctorList.Find(d => ((IDoctor)d).Email.Equals(searchEmail, StringComparison.OrdinalIgnoreCase)) as IDoctor;
//                         if (foundDoctor != null)
//                         {
//                             foundDoctor.ShowInfo();
//                         }
//                         else
//                         {
//                             Console.WriteLine("Doctor not found!");
//                         }
//                         break;

//                     case "6":
//                         // Exit
//                         Console.WriteLine("Exiting...");
//                         return;

//                     default:
//                         Console.WriteLine("Invalid option. Please try again.");
//                         break;
//                 }

//                 Console.WriteLine(); // New line for better readability
//             }
//         }
//     }
// }