using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_浮点类型变量
{
    class Program
    {
        static void Main(string[] args)
        {
            //float x0 = 3.5;       //编译错误:不能隐式地将double类型转换为float类型
            float x1 = 3.5F;       //使用后缀f或F初始化float浮点型变量
            double x2 = 3.0;      //双精度浮点型变量
            double x3 = 30D;     //使用后缀d或D初始化double浮点型变量
            Console.WriteLine("x1={0:0.00}; x2={1:0.00}; x3={2:0.00};", x1, x2, x3);
            Console.ReadKey();
        }
    }
}
