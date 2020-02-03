using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json_Exercise
{
    class Student
    {
        public string Name { get; set; }
        public string Status { get; set; }
        [IgnoreProperty]
        public string LastName { get; set; }
        public int Age { get; set; }
        public Student(string name, string lastName, string status, int age)
        {
            Name = name;
            Status = status;
            LastName = lastName;
            Age = age;
        }
    }
}
