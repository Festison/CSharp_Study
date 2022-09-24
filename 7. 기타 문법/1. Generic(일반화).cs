using System;

namespace _7._기타_문법
{
    class Program
    {
        class MyList<T> where T : struct // 조건 추가 T는 반드시 값형식
        {
            T[] arr = new T[10];

            public T GetItem(int i)
            {
                return arr[i];
            }
        }

        class Monster
        {

        }

        static void Test<T>(int input)
        {

        }

        static void Main(string[] args)
        {
            MyList<int> myIntList = new MyList<int>();
            int item = myIntList.GetItem(0);

            MyList<short> myShortList = new MyList<short>();
            MyList<Monster> myMonsterList = new MyList<Monster>();

            Test<int>(3);

        }
    }
}
