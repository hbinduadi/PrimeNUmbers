using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNUmbers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrm = true;
            Console.WriteLine(" The Prime Numbers are : ");
            for (int counter1 = 2; counter1 <= 100; counter1++)
            {
                for (int counter2 = 2; counter2 <= 100; counter2++)
                {
                    if ((counter1 != counter2) && (counter1 % counter2 == 0))
                    {
                        isPrm = false;
                        break;
                    }
                }
                if (isPrm)
                {
                    Console.WriteLine(counter1);
                }
                isPrm = true;
            }
            Console.ReadLine();
        }
        
    }
        
    
}
