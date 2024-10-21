using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

//2.Create a Bank class, assign balance in constructor, create deposit & withdraw method & display methods
//Deposit will add amount in balance
//Withdraw will remove the amount from balance . amount should be remove if its less than balance
//Display will show balance

namespace MethodConstrcutorProgram
{
    public class Bank
    {
        private double balance;

        public Bank(double bal)
        {
            this.balance = bal;
        }

        public void Deposit(double amount) 
        {
            if (amount > 0)
            {
                balance = balance + amount;
                Console.WriteLine($"Succesfully deposit {amount}");
            }
            else {
                Console.WriteLine("Deposit amount must be positive");
            }

           
        }

        public void Withdraw(double amount) {
            if (amount > 0 && amount <= balance)
            {
                balance = balance - amount;
                Console.WriteLine($"Succesfully withdraw {amount}");
            }
            else {
                Console.WriteLine("Invalid amount");
            }
        
        }

        public String DisplayAmount() {

            return $"Account balance is : {balance}";
        }
    }
    

    
}
