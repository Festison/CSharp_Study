using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C샵_공부_4.객체지향_여행
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Festion";

            // 1. 찾기 
            bool found = name.Contains("Festison"); 
            int index = name.IndexOf("t"); // t라는 문자가 몇번째에있는지 찾아준다.

            // 2. 변형
            name = name + "Artrox"; // 문자열 뒤에 문자열추가

            string loweCaseName = name.ToLower(); // 문자열을 전부 소문자로 변경
            string upperCaseName = name.ToUpper(); // 문자열을 전부 대문자로 변경
            string newName = name.Replace('i','y'); // 문자 i를 y로변경

            // 3. 분할 
            string[] names = name.Split(new char[] { ' ' });
            string substringNmae = name.Substring(5); // 5번째부터 짤라서 새로운 문자열로 인식

        }
    }
}
