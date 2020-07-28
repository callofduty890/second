using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_布尔类型变量
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b1 = true;
            //bool b2 = 0;    //编译错误：常量值0无法转换为bool
            char c = '0';
            bool b3 = (c > 64 && c < 123);
            Console.WriteLine("{0}\t{1}", b1, b3); Console.ReadKey();
        }
    }
}
