using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    public class Student
    {
        public string name;
        public int course;
        public double gpa;
        public List<Subject> subjects;


        public Student() { }

        public Student(string _name, double _gpa)
        {
            name = _name;
            gpa = _gpa;
            subjects = new List<Subject>();
        }

        public Student(string _name, int _course)
        {
            name = _name;
            course = _course;
            subjects = new List<Subject>();
        }
    }
}