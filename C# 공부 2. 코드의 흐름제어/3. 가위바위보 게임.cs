using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C샵_공부_2.코드의_흐름_제어
{
    class _3
    {
        static void Main(string[] args)
        {
            // 0:가위 1:바위 2:보

            Random rand = new Random();
            int aiChoice = rand.Next(0, 3); // 0~2사이의 랜덤 값을 가지게 된다.

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Console.WriteLine("당신의 선택은 가위입니다.");
                    break;
                case 1:
                    Console.WriteLine("당신의 선택은 바위입니다.");
                    break;
                case 2:
                    Console.WriteLine("당신의 선택은 보입니다.");
                    break;
            }

            switch (aiChoice)
            {
                case 0:
                    Console.WriteLine("당신의 선택은 가위입니다.");
                    break;
                case 1:
                    Console.WriteLine("당신의 선택은 바위입니다.");
                    break;
                case 2:
                    Console.WriteLine("당신의 선택은 보입니다.");
                    break;
            }

            // 승리 무승부 패배 
            if (choice == 0) //가위
            {
                if (aiChoice == 0)
                {
                    Console.WriteLine("무승부 입니다.");
                }

                else if (aiChoice == 1)
                {
                    Console.WriteLine("패배 입니다.");
                }

                else if (aiChoice == 2)
                {
                    Console.WriteLine("승리 입니다.");
                }
            }

            if (choice == 1) //바위
            {
                if (aiChoice == 0)
                {
                    Console.WriteLine("승리 입니다.");
                }

                else if (aiChoice == 1)
                {
                    Console.WriteLine("무승부 입니다.");
                }

                else if (aiChoice == 2)
                {
                    Console.WriteLine("패배 입니다.");
                }
            }

            if (choice == 2) //보
            {
                if (aiChoice == 0)
                {
                    Console.WriteLine("패배입 입니다.");
                }

                else if (aiChoice == 1)
                {
                    Console.WriteLine("승리 입니다.");
                }

                else if (aiChoice == 2)
                {
                    Console.WriteLine("무승부 입니다.");
                }
            }
        }
    }
}
