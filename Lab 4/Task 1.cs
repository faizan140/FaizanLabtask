
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class factorial
    {
        public static int facto(int fact)
        {
            int result;
            result = fact;
            for (int i = 1; i < fact; i++)
            {
                result = result * i;
            }
                return result;
            
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(factorial.facto(5));
            Console.ReadLine();   
        }
    }
}
