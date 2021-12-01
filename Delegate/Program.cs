using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        delegate void Message(); // 1. Delegate declaration
        static void Main(string[] args)
        {
            Message mes; // 2. Create a delegate variable
            if (DateTime.Now.Hour < 12)
            {
                mes = GoodMorning; // 3. Assign the address of the method to this variable
            }
            else
            {
                mes = GoodEvening;
            }
            mes();// 4. Call the method
        }
        private static void GoodMorning()
        {
            Console.WriteLine("Good Morning");
        }
        private static void GoodEvening()
        {
            Console.WriteLine("Good Evening");
        }
    }
}
