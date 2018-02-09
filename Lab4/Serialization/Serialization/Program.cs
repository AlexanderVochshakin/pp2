using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
    class Program
    {
        static void F1()
        {
            Student a = new Student("Dave", 1);
            a.gpa = 3.2;
            StreamWriter sw = new StreamWriter(@"student.txt");
            sw.WriteLine(a.name);
            sw.WriteLine(a.gpa);
            sw.WriteLine(a.course);
            sw.Close();
        }

        static void F2()
        {
            StreamReader sr = new StreamReader(@"student.txt");
            Student b = new Student();
            string name = sr.ReadLine();
            int course = int.Parse(sr.ReadLine());
            double gpa = double.Parse(sr.ReadLine());
            b.name = name;
            b.gpa = gpa;
            sr.Close();
            Console.WriteLine(b.name);
            Console.ReadKey();
        }

        static void F3()
        {
            FileStream fs = new FileStream(@"data.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Student));

            Student a = new Student("Alexander", 2.7);
            Subject s1 = new Subject("PP II");
            Subject s2 = new Subject("Physics I");
            Subject s3 = new Subject("Calculus II");
            Subject s4 = new Subject("Linear Algebra");
            Subject s5 = new Subject("History");
            a.subjects.Add(s1);
            a.subjects.Add(s2);
            a.subjects.Add(s3);
            a.subjects.Add(s4);
            a.subjects.Add(s5);

            try
            {
                xs.Serialize(fs, a);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                fs.Close();
            }
        }

        static void F4()
        {
            FileStream fs = new FileStream(@"data.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Student));
            Student b = xs.Deserialize(fs) as Student;
            Console.WriteLine(b.subjects[1].name);
            Console.ReadKey();
        }

        static void F5()
        {
            BinaryFormatter bf = new BinaryFormatter();
            Student a = new Student("Michael", 2);
            Subject s1 = new Subject("PP1");
            Subject s2 = new Subject("Algorithms and Data Structres");
            Subject s3 = new Subject("OOP");
            a.subjects.Add(s1);
            a.subjects.Add(s2);
            a.subjects.Add(s3);

            FileStream fs = new FileStream(@"data.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            bf.Serialize(fs, a);
            fs.Close();
        }

        static void F6()
        {
            FileStream fs = new FileStream("data.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            Student b = bf.Deserialize(fs) as Student;
            Console.WriteLine(b.subjects[2].name);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            F6();
        }
    }
}