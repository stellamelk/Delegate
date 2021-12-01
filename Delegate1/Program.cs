using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate1
{
    class Program
    {
        delegate int Operation(int x, int y);
        static void Main(string[] args)
        {
            //Assignment of method address via constructor
            Operation del = Add;// Delegate points to the Add method
            Operation del1 = new Operation(Add); //Method reference assignment
            int result = del(4,5);// actually Add(4,5)
            Console.WriteLine(result);

            Math math = new Math();
            Operation del2 = math.Sum;
            int result1 = del2(2, 3);// math.Sum(2,3)
            Console.WriteLine(result1); // 5 

            Console.Read();
        }
        private static int Add(int x, int y)
        {
            return x + y;
        }
        private static int Multyply(int x, int y)
        {
            return x * y;
        }
    }
    class Math
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
