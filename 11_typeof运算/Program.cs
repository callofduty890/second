using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11_typeof运算
{
    class Program
    {
        static void Main(string[] args)
        {
            //type类型
            Type t1 = typeof(bool);
            Console.WriteLine("typeof(bool) is {0}", t1);
            int radius = 5; Type t2 = radius.GetType();
            Console.WriteLine("radius.GetType() is {0}", t2);
            Console.WriteLine("Area = {0}", radius * radius * Math.PI);
            Console.WriteLine("The type of Area is {0}", (radius * radius * Math.PI).GetType());
            Console.ReadKey();
        }
    }
}
