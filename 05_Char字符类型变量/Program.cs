using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_Char字符类型变量
{
    class Program
    {
        static void Main(string[] args)
        {
            //char char0 = "Z";    //使用双引号会产生编译错误
            char ch1 = 'X';        //字符常量  蝉蛹的这里就可以了
            char ch2 = (char)88;   //从整型转换

            Console.WriteLine("{0}\t{1}", ch1, ch2);
            Console.WriteLine("{0}的小写字母是：{1}", ch1, Char.ToLower(ch1));
            Console.WriteLine("{0}是字母吗？{1}", ch1, Char.IsLetter(ch1));
            Console.ReadKey();
        }
    }
}
