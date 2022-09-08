using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C샵_공부_2.코드의_흐름_제어
{
    class _2
    {
        static void Main(string[] args)
        {
            int choice = 0;

            switch (choice)
            {
                case 0:
                    Console.WriteLine("가위입니다.");
                    break;
                case 1:
                    Console.WriteLine("바위입니다.");
                    break;
                case 2:
                    Console.WriteLine("보입니다.");
                    break;
                default:
                    Console.WriteLine("실패했습니다.");
                    break;
            }

            // 삼항연산자 : (조건 ? 맞을때 : 틀릴떄);

            int number = 25;

            bool isPair = ((number % 2) == 0 ? true : false);
            
        }
    }
}
