using System;
using System.Threading.Channels;

namespace A004_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("이름을 입력하세요");
            string name = Console.ReadLine();
            Console.Write("나이를 입력하세요");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("키를 입력하세요");
            float Height = float.Parse(Console.ReadLine());

            Console.WriteLine($"안녕하세요{name}님!");
            Console.WriteLine($"나이는 : {age}");
            Console.WriteLine($"키는 : {Height}cm");      
            
        }
    }
}
