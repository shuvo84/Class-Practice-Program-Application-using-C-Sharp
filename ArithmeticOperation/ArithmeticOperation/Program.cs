using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations op = new Operations();

            int number1 = int.Parse(Console.ReadLine());
            op.Number1 = number1;

            int number2 = int.Parse(Console.ReadLine());
            op.Number2 = number2;

            Console.WriteLine("The sum is: " + op.add());
            Console.ReadLine();
        }
    }
}
