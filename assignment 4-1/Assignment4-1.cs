using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4_1
{
    class Program
    {
 
        static void Main(string[] args)
        {
            Console.WriteLine("\tFirst Test");
            int studentNumber = 0001234567;
            string firstName = "John";
            string lastName = "Logan";
            double gpa = 3.6;
            string classification = "Senior";
            string major = "English";
            Student newStudent = new Student(studentNumber,firstName,lastName,gpa,classification,major);
            Console.WriteLine(newStudent);
            Console.WriteLine("\n\t Another Test");
            Student student2 = new Student(0001222876, "Chin", "Chang", 3.7, "Junior", "CS");
            Console.WriteLine(student2);
        }
    }
}
