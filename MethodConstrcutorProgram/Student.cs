using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//WAP to create a class Student, accept the rollno, name & 3 subjects marks from
//constructor, create a method to calculate total marks & percentage. Print the details
//of students.
namespace MethodConstrcutorProgram
{
    public class Student
    {
        private int rollno;
        private String name;
        private int totalmarks,per, sub1, sub2, sub3;

        public Student(int rollnum,String sname,int subject1,int subject2, int subject3) {
            rollno= rollnum;
            name= sname;
            sub1= subject1;
            sub2 = subject2;
            sub3 = subject3;
        }

        public void CalculateTotalMarks() { 
           totalmarks=sub1 + sub2+sub3;
        }
        public void CalculatePercentage() {
            per = totalmarks / 3;
        }
        public String displaResult() {

            return $"Name of student:{name},rollNo is :{rollno},Total Marks:{totalmarks},and percentage:{per}";   
            
        }

    }
}
