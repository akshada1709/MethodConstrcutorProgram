using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodConstrcutorProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Student std = new Student(101, "Akshada", 78, 65, 88);
            //std.CalculateTotalMarks();
            //std.CalculatePercentage();
            //Console.WriteLine(std.displaResult()); 


            //Bank bk = new Bank(25000);
            //bk.Deposit(2000);
            //bk.Withdraw(5000);

            //Console.WriteLine(bk.DisplayAmount());

            PProduct p1 = new PProduct(111, "shirt", 1200);
            p1.ProductDetails();
        }
    }
}
