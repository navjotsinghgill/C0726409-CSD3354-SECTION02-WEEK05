using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0726409
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodA();
        }

        public static void MethodA()
        {
            while (peanut())
            {
                Console.WriteLine("Help ! i am stuck in an infinite loop!");
            }


        }

        public static bool peanut()
        {
            return true;
        }

    }
}
