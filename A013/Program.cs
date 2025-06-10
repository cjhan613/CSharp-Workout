using System;
using System.Threading.Channels;


namespace A013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 2147483647;
            long bigNum = num;
            Console.WriteLine("{0},{1}", bigNum, num);


            double x = 1234.5;
            int a;

            a = (int)x;
            Console.WriteLine(a);
        }
    }
}
