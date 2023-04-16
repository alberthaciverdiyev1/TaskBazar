
using Static_Repeat.Models;

namespace Static_Repeat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Butun Qruplar:");


            Student student1 = new Student("Albert", "Hajiverdiyev");
            Student student2 = new Student("Sekine", "Allahverdiyeva");
            Student student3 = new Student("Alyona", "Haciverdiyeva");
            Student student4 = new Student("Arif", "Abdulla");
            Student student6 = new Student("Nahid", "Memmedov");
            Student student7 = new Student("Saleh ", "Nebiyev");
            Student student8 = new Student("Nahid ", "Emrahov");
            Student student9 = new Student("Royal ", "Memmedov");
            Student student0 = new Student("Tofiq", "Yusifli");
            Student student10 = new Student("Samir", "Xankisiyev");



            Group group1 = new Group("AB103");
            Group group2 = new Group("AP107");
            Group group3 = new Group("AP333");
            Group group4 = new Group("559a");

            group1.AddStudent(student1);
            group1.AddStudent(student2);
            group1.AddStudent(student3);
            group1.AddStudent(student4);
            group1.AddStudent(student6);
            //------------------------------//
            group2.AddStudent(student0);
            //-----------------------------//
            group3.AddStudent(student7);
            group3.AddStudent(student8);
            group3.AddStudent(student9);
            //----------------------------//
            //group3.GetStudent(8);
            //group3.AddStudent(student10);
            //group3.GetGroupInfo();
            //group1.Search("sekine", "allahVERdiyeva");
            group3.ShowStudents();


        }
    }
}