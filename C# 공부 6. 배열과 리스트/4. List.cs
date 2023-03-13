using System;
using System.Collections.Generic;

namespace CSahrp_공부
{
    class Program
    {   
          static void Main(string[] args)
        {
            // List는 동적 배열로 이루어져있다.
            List<int> list = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                list.Add(i); // 제일 뒤에 대입
            }

            // 삽입 삭제
            list.Insert(2, 999);
            list.Remove(3);
            list.RemoveAt(0); // 첫번째 요소 삭제
            list.Clear(); // 전체 삭제

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            foreach (int num in list)
            {
                Console.WriteLine(num);
            }
          
        }
    }
}
