using System;

namespace C샵_공부_2.코드의_흐름_제어
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0; // 0:가위 1:바위 2:보

            if (choice == 0)
                Console.WriteLine("가위입니다.");
            else if (choice == 1)
                Console.WriteLine("바위입니다.");
            else if (choice == 2)
                Console.WriteLine("보입니다.");

        }
    }
}
