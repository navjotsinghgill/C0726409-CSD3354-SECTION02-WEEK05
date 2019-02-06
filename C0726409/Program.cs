using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0726409
{
    class Program
    {
        static int i = 0;
        static void Main(string[] args)
        {
            MethodA();
            Console.ReadLine();
        }

        public static void MethodA()
        {
            while (peanut())
            {
                Console.WriteLine(" i is {0}", i);
                if (i > 10)
                    return;
            }


        }

        public static bool peanut()
        {
            i++;
            return true;
        }
    }


}

