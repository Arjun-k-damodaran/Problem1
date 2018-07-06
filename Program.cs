using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_SystemProblem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Amount");
            int totalAmount = Int32.Parse(Console.ReadLine());

            int rem;
            int div;
            if(totalAmount%5!=0)
            {
                Console.WriteLine("Invalid Amount");
            }
            else
            {
                if (totalAmount >= 500)
                {
                    
                    div = totalAmount / 500;
                    totalAmount = totalAmount % 500;
                    Console.WriteLine("500 * {0}", div);
                }
                if (totalAmount >= 100)
                {
                    
                    div = totalAmount / 100;
                    totalAmount = totalAmount % 100;
                    Console.WriteLine("100 * {0}", div);
                }
                if (totalAmount >= 50)
                {
                    
                    div = totalAmount / 50;
                    totalAmount = totalAmount % 50;
                    Console.WriteLine("50 * {0}", div);
                }
                if (totalAmount >= 10)
                {
                    
                    div = totalAmount / 10;
                    totalAmount = totalAmount % 10;
                    Console.WriteLine("10 * {0}", div);
                }
                if (totalAmount >= 5)
                {
                    
                    div = totalAmount / 5;
                    rem = totalAmount % 5;
                    Console.WriteLine("5 * {0}", div);
                }
            }


            //Console.ReadKey();
        }
    }
}
