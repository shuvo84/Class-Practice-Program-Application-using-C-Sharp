using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperation
{
    class Operations
    {
        private int number1;
        private int number2;
        private int result;

        public int Number1
        {
            set { number1 = value; }
            get { return number1; }
        }
        public int Number2
        {
            set { number2 = value; }
            get { return number2; }
        }
        public int Result
        {
            set { result = value; }
            get { return result; }
        }
        public int add()
        {
            this.result = number1 + number2;
            return Result;
        }
    }
}
