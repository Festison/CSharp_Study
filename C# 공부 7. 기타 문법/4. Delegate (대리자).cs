using System;
using System.Collections.Generic;
using System.Text;

namespace _7._기타_문법
{
    class Delegate
    {
        delegate int OnClicked(); 
        // delegate란 형식은 형식인데, 함수 자체를 인자로 넘겨주는 형식이다.
        // 반환 : int 입력: void
        // OnClicked이 delegate 형식의 이름이다.

        static void ButtonPressed(OnClicked clickedFunction)
        {
            clickedFunction();
        }

        static int TestDelegate()
        {
            Console.WriteLine("Hello Delegate");

            return 0;
        }

        static int TestDelegate2()
        {
            Console.WriteLine("Hello Delegate 2");

            return 0;
        }

        static void Main(string[] args)
        {
            OnClicked clicked = new OnClicked(TestDelegate);
            clicked += TestDelegate2;

            ButtonPressed(clicked);
        }
    }
}
