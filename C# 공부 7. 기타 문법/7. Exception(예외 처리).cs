using System;
using System.Collections.Generic;
using System.Text;

namespace _7._기타_문법
{
    class exception
    {
        class TestException : Exception
        {

        }

        static void Main(string[] args)
        {
            try
            {
                // 1. 0으로 나눌 떄
                // 2. 잘못된 메모리를 참조 (null)
                // 3. 오버플로우
                int a = 10;
                int b = 0;
                int result = a / b;

                int c = 0;

                throw new TestException();
            }
            catch (DivideByZeroException e)
            {

               
            }
            catch (Exception e)
            {

            }
            finally // 무조건 한번 실행되는 부분
            {
                // DB, 파일 정리 할때 사용
            }
        }
    }
}
