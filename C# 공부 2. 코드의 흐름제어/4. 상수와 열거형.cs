using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C샵_공부_2.코드의_흐름_제어
{
    class _4
    {
        enum Choice // enum 열거형을 통해 가위바위보 구현
        {
            Rock=1,
            Scissors = 0,
            Paper=2
        }
        static void Main(string[] args)
        {
            const int Scissors = 0;
            const int Rock = 1;
            const int Paper = 2;

            Random rand = new Random();
            int aiChoice = rand.Next(0, 3); // 0~2사이의 랜덤 값을 가지게 된다.

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case (int)Choice.Scissors:
                    Console.WriteLine("당신의 선택은 가위입니다.");
                    break;
                case (int)Choice.Rock:
                    Console.WriteLine("당신의 선택은 바위입니다.");
                    break;
                case (int)Choice.Paper:
                    Console.WriteLine("당신의 선택은 보입니다.");
                    break;
            }

            switch (aiChoice)
            {
                case Scissors:
                    Console.WriteLine("컴퓨터의 선택은 가위입니다.");
                    break;
                case Rock:
                    Console.WriteLine("컴퓨터의 선택은 바위입니다.");
                    break;
                case Paper:
                    Console.WriteLine("컴퓨터의 선택은 보입니다.");
                    break;
            }

            // 승리 무승부 패배 
            if (choice == Scissors) //가위
            {
                if (aiChoice == Scissors)
                {
                    Console.WriteLine("무승부 입니다.");
                }

                else if (aiChoice == Rock)
                {
                    Console.WriteLine("패배 입니다.");
                }

                else if (aiChoice == Paper)
                {
                    Console.WriteLine("승리 입니다.");
                }
            }

            if (choice == Rock) //바위
            {
                if (aiChoice == Scissors)
                {
                    Console.WriteLine("승리 입니다.");
                }

                else if (aiChoice == Rock)
                {
                    Console.WriteLine("무승부 입니다.");
                }

                else if (aiChoice == Paper)
                {
                    Console.WriteLine("패배 입니다.");
                }
            }

            if (choice == Paper) //보
            {
                if (aiChoice == Scissors)
                {
                    Console.WriteLine("패배입 입니다.");
                }

                else if (aiChoice == Rock)
                {
                    Console.WriteLine("승리 입니다.");
                }

                else if (aiChoice == Paper)
                {
                    Console.WriteLine("무승부 입니다.");
                }
            }
        }
    }
}
