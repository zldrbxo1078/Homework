using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2_star
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.Write("반복할 숫자를 입력해주세요 : ");
            count = Int32.Parse(Console.ReadLine());
            if (count <=1)
            {
                Console.WriteLine("잘못된 값입니다.");
                return;
            }
            Console.WriteLine();
            //감소
            for (int i = count; i > 0; i--)
            {
                for (int j = 0; j <i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n--------------------\n");
            //역감소
            for (int i = count; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < count-i+1; j++)
                {
                    Console.Write("*");
                }
                    Console.WriteLine();
            }
            Console.WriteLine("\n--------------------\n");
            //홀수
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < 2*i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n--------------------\n");

            //피라미드
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count-i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2*i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n--------------------\n");


        }
    }
}
