using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4_1
{
    class Student
    {
        int studentNumber;
        string firstName;
        string lastName;
        double gpa;
        string classification;
        string major;

        public Student()
        {
        }

        public Student(int id, string fName, string lName, double grade_Point_Average, string grade, string maj)
        {
            studentNumber = id;
            firstName = fName;
            lastName = lName;
            gpa = grade_Point_Average;
            classification = grade;
            major = maj;
        }

        public override string ToString()
        {
            return "Student Number: " + studentNumber + "\nFirst Name: " + firstName + "\nLast Name: " + lastName + "\nGPA: " + gpa +
                "\nClassification: " + classification + "\nMajor: " + major;
            //return base.ToString();
        }
    }
}
