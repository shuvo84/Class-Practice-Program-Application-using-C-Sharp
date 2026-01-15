using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Please Enter a number: ");
            number = int.Parse(Console.ReadLine());
            

            if(number>10)
            {
                Console.WriteLine("The number is greater than 10");
            }
            else if(number<10)
            {
                Console.WriteLine("The number is less than 10");
            }
            else
            {
                Console.WriteLine("The number is equal to 10");
            }
            while (number<5)
            {
                Console.WriteLine(number);
                Console.WriteLine("\n");
                number++;
            }
            Console.ReadLine();
        }
    }
}
