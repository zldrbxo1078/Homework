using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw4_Team_
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0, com = 0 ;

            Boolean auto = true;
            while (auto)
            {
                Console.WriteLine("************************************");
                Console.WriteLine("1. 가위 | 2. 바위 | 3. 보 | 4. 종료");
                Console.WriteLine("************************************");
                Console.WriteLine("선택");
                input = Int32.Parse(Console.ReadLine());
                com = (new Random()).Next(1, 4);
                //Console.WriteLine(com);
                if (input == com)
                {
                    Console.WriteLine("비겼습니다!");
                }
                else
                {
                    switch (input)
                    {
                        case 1:
                            {
                                Console.WriteLine((com==3)? "승":"패");
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine((com == 1) ? "승" : "패");
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine((com == 2) ? "승" : "패");
                                break;
                            }
                        case 4:
                            Console.WriteLine("프로그램을 종료합니다.");
                            return;
                        default:
                            Console.WriteLine("잘못된 입력입니다.");
                            break;
                    }
                }
            }

        }
    }
}
