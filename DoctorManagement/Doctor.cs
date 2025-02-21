using System;
namespace CSharpTraining
{
    class Doctor : IDoctor
    {
        public string[] PhoneList = new string[3];
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public string Speciality { get; set; }
        public string Email { get; set; }
        public int Rank { private get; set; }

        public string this[int index]{
            get => PhoneList[index];
            set => PhoneList[index] = value;
        }

        public void showInfo(){
            Console.WriteLine($"ID : {ID}, Name : {Name}, Birthday : {BirthDay}, Speciality : {Speciality}, Email : {Email}, Rank : {Rank}");
        }
    }
}