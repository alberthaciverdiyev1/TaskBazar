using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Static_Repeat.Models
{
    internal class Group
    {

        static int GroupCount = 0;
        private int GroupId;
        private string GroupName;
        private Student[] Students;
        public static Group[] Groups = new Group[0];

        public static void AddGroup(Group group)
        {
            Array.Resize(ref Groups, Groups.Length + 1);
            Groups[Groups.Length - 1] = group;

            Console.WriteLine(group.GroupName);

        }

        public Group(string groupName)
        {
            GroupCount++;
            GroupId = GroupCount;
            GroupName = groupName;
            Students = new Student[0];
            AddGroup(this);
        }


        public static int groupCount;
        public void GetGroupInfo()
        {
            groupCount++;
            groupCount = GroupId;
            Console.WriteLine($"Qrupun Adi: {GroupName}");
            Console.WriteLine($"Qrupda Olan Telebe Sayi: {GroupId}");
        }
        public void GetStudent(int id)
        {
            bool found = false;

            foreach (Student item in Students)
            {
                if (item.Id == id)
                {
                    Console.WriteLine($"Axtardiginiz ID Uzre Tapilmis Telebe: {item}");
                    found = true;
                    break;
                }

            }
            if (!found)
            {
                Console.WriteLine("Bele Bir Telebe Tapilmadi");
            }


        }
        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
        }
        public void Search(string name, string surname)
        {
            bool found = false;
            foreach (Student item in Students)
            {
                if (item.Name.ToLower() == name.ToLower() || item.Surname.ToLower() == surname.ToLower())
                {
                    Console.WriteLine(item);
                    found = true;
                    break;
                }


            }
            if (!found)
            {
                Console.WriteLine("Bele Telebe Tapilmadi");
            }
        }
       
        public void ShowStudents()
        {

            //for
            //     (int i = 0; i < Students.Length; i++)
            //{
            //    Console.WriteLine(Students[i]);
            //}  

            foreach (Student item in Students)
            {
                Console.WriteLine(item);
            }
        }
    }
}
