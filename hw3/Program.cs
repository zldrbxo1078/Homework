using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            int unit = 10000, num =0, sw = 0;
            Console.WriteLine("금액을 입력하시오.");
            int money = Int32.Parse(Console.ReadLine());
            while(unit > 1)
            {
                num = money / unit;
                Console.WriteLine($"{unit} {num}개");
                money -= unit * num;
                if (sw == 0)
                {
                    unit /= 2;
                    sw = 1;
                }
                else
                {
                    unit /= 5;
                    sw = 0;
                }
            }
        }
    }
}
