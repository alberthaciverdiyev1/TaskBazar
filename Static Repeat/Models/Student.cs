using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Static_Repeat.Models
{
    internal class Student
    {
        static int _count = 0;
        private int _id;
        private string _name;
        private string _surname;

        public int Id { get; }
        public string Name { get { return _name; } set { if (value.Length >= 0) { _name = value; } } }
        public string Surname { get { return _surname; } set { if (value.Length >= 0) { _surname = value; } } }
        public Student(string name, string surname)
        {
            _count++;
            Id = _count;
            Name = name;
            Surname = surname;
        }
        public override string ToString()
        {
            return $"{Id}: {Name} {Surname}";
        }


    }
}
