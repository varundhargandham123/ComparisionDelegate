using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace IComparabledemo
{
    class Student : IComparable<Student>
    {
        public int id { get; set; }
        public string name { get; set; }
        /// <summary>
        /// this is the method of IComparable
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Student other)
        {
            if (this.id > other.id)
                return 1;
            else if (this.id < other.id)
                return -1;
            else
                return 0;
        }
        public static int CompareStudent(Student x, Student y)

        {

            return x.name.CompareTo(y.name);

        }
    
   
     /// this contains creating a list and adding elements into the list
     /// by using different Interfaces sorting is being done
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {
            Student s1 = new Student() { id = 123, name = "varun" };
            Student s2 = new Student() { id = 124, name = "vnr" };
            Student s3 = new Student() { id = 125, name = "ramu" };
            Student s4 = new Student() { id = 126, name = "nitin" };
            List<Student> list = new List<Student>() { s1, s2, s3, s4 };
            Console.WriteLine("By using IComparable");
            list.Sort();
            foreach (Student s in list)
                Console.WriteLine(s.id + " " + s.name);
            Comparison<Student> mydel = new Comparison<Student>(CompareStudent);        
            Console.WriteLine("sorted by name");
            list.Sort(mydel);
            foreach (Student s in list)
            Console.WriteLine(s.id + " " + s.name);
            
        }
    }
}