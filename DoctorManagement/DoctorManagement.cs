using System;
namespace CSharpTraining{
    class DoctorManagement{
        private List<IDoctor> doctorList;

        public void Add(IDoctor doctor){
            doctorList.Add(doctor);
        }
        public void Remove(IDoctor doctor){
            foreach(Doctor doc in doctorList){
                if(doc.ID == doctor.ID){
                    doctorList.Remove(doctor);
                    Console.WriteLine($"Doctor {doctor.Name} removed successfully !");
                    return;
                }
            }
            Console.WriteLine("Cannot find this doctor ! Try again.");
        }

        // public void Sort(IComparer<String> comp){
        //     doctorList.Sort()
        // }
    }
}