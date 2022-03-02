using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            //1번 문제
            Console.WriteLine("문제1)");
            for (char i = 'A'; i <= 'Z'; i++)
            {
                Console.Write(i);
            }
            //2번 문제
            Console.WriteLine("\n\n문제2)");
            int count = 0;
            for (int i = 0; i<10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(++count);
                }
                Console.WriteLine();
            }
            //3번 문제
            Console.WriteLine("\n문제3) 합해서 6이 나오는 경우");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (i + j == 6) Console.WriteLine($"{i} + {j} = {i+j}");
                }
            }
        }
    }
}
