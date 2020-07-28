using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10_sizeof运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The size of short is {0}", sizeof(short));
            Console.WriteLine("The size of int is {0}", sizeof(int));
            Console.WriteLine("The size of long is {0}", sizeof(long));
        }
    }
}
