using System;
using System.Threading.Channels;

namespace A015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x,y;

            /*Console.WriteLine("첫번째 숫자를 입력하세요");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("두번째 숫자를 입력하세요");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}+{1} = {2}", x, y ,x+y);*/

            short value = short.MaxValue;
            Console.WriteLine("\n 이진수 팔진수 16진수 출력하기");

            int baseNum = 2;

            string s = Convert.ToString(value, baseNum);
            int i = Convert.ToInt32(s, baseNum);
            
            Console.WriteLine("i = {0}, {1,2}진수 = {2,8}", i, baseNum, s);

        }
    }
}
