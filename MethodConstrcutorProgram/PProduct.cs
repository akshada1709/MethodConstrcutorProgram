using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3. Create Product class, add code, name, price . Accept product details, if price >1000 give 10 % discount on
//product . & display discounted price.
namespace MethodConstrcutorProgram
{
   public class PProduct
    {
        private int code;
        private String name;
        private double price;
     

        public PProduct(int pcode, String pname, double pprice) { 
            
            code= pcode;
            name= pname;
            price= pprice;
        }

        public void ProductDetails() {
            if (price > 1000)
            {
                double discount = price * 0.10; 
                double discountedPrice = price - discount; 
                Console.WriteLine($" Discounted Price: {discountedPrice}");
            }
            else
            {
                
                Console.WriteLine($"Product Code: {code}, Name: {name}, Price: {price}");
            }
        }

    }

    
}
