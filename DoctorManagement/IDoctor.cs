using System;
namespace CSharpTraining
{
    interface IDoctor
    {
        int ID { get; set; }
        string Name { get; set; }
        DateTime BirthDay { get; set; }
        string Speciality { get; set; }
        string Email { get; set; }
        int Rank { set; }

        string this[int index] { get; set; }

        void showInfo();

    }
}
