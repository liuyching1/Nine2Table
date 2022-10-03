using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nine2Table
{
    class Program
    {
        static void Main(string[] args)
        {
            //執行主程式
            demo01();
        }
        private static void demo01() //僅有本身可以存取
        {

            string title = new String('*', 10);
            Console.WriteLine(title);
            Console.WriteLine("九九乘法表 for C#");
            Console.WriteLine(title);
            int r;

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    r = i * j;
                    // .
                    Console.Write("{0}x{1}={2} ", i, j, r);
                    if (i * j < 10)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
            Console.Write("請按任意鍵結束....");
            Console.ReadKey();
        }
    }
}
