using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09_逻辑运算符
{
    class Program
    {
        static bool Method1()
        {
            Console.WriteLine("调用Method1，返回False"); return false;
        }
        static bool Method2()
        {
            Console.WriteLine("调用Method2，返回True"); return true;
        }

        static void Main(string[] args)
        {
            //逻辑“非”
            Console.WriteLine("!true={0}, !false={1}", !true, !false);
            //逻辑“与”&条件“与”
            Console.WriteLine("逻辑“与”(&):");
            Console.WriteLine("Method1()&Method2()结果是{0}", Method1() & Method2());
            Console.WriteLine("条件“与”(&&):");
            Console.WriteLine("Method1()&&Method2()结果是{0}", Method1() && Method2());

            //二元逻辑"与”(＆)运算符是为整型和bool类型预定义的。对于整型，&计算操作数的逻辑按位"与"。对于bool操作数，＆计算操作数的逻辑。与-：也就是说，当且仅当两个操作数均为true时，结果才为True。&运算符既可作为一元运算符也可作为二元运算符。
            //条件“与”(＆＆)执行其bool操作数的逻辑“与”运算，但仅在必要时才计算第二个操作数。即："x＆&y"对应于操作"x&y"。不同的是，如果x为false，则不计算y(因为不论y为何值，”与”操作的结果都为False)。这被称作"短路"计算。



            //逻辑“或”&条件“或”
            Console.WriteLine("逻辑“或”(|):");
            Console.WriteLine("Method2()|Method1()结果是{0}", Method2() | Method1());
            Console.WriteLine("条件“或”(||):");
            Console.WriteLine("Method2()||Method1()结果是{0}", Method2() || Method1());
            //逻辑“异或”
            Console.WriteLine("true^false={0}, false^false={1}", true ^ false, false ^ false);
            //混合逻辑运算
            Console.WriteLine("true^!false&false|false={0}", true ^ !false & false | false);
            Console.ReadKey();
        }
    }
}
