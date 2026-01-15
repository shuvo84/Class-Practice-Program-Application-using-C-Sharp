using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /*byte c = 10;
            int a = c;
            byte b = (byte)a;
            string s = "1234";
            int ab = Convert.ToInt32(s);
            string str = Convert.ToString(c);
            Console.WriteLine("My First Program...."+ b);
            Console.WriteLine("{0} {1} {2} {3}", s, ab, c,str);

            Console.ReadLine();*/

            /*string firstName = "";
            string lastName = "";
            Console.WriteLine("Enter First Name: ");
            firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name: ");
            lastName = Console.ReadLine();

            Console.WriteLine("Your Name is: {0} {1}", firstName, lastName);

            Console.ReadLine();*/

            Console.WriteLine("Enter First Num: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Num: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum: {0}", num1+num2);

            Console.ReadLine();
        }
    }
}
