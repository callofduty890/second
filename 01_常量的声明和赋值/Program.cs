using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_常量的声明和赋值
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = 10000;     //声明变量amount(金额)并赋值为10000
            const double TAXRATE = 0.17;//声明常量TAXRATE(增值税率)为17%
            //TAXRATE = 0.05;         //编译错误
            double tax = amount * TAXRATE;//计算增值税
            Console.WriteLine("金额={0}; 税={1}", amount, tax);
            Console.ReadKey();
        }
    }
}
