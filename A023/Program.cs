﻿using System;

namespace A023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());

            string result = input > 0 ? "양수입니다" : "음수입니다";
            Console.WriteLine("{0}는 {1}", input, result );

            Console.WriteLine("{0}는 {1}", input, (input %2 == 0) ? "짝수입니다" : "홀수입니다");

            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine("{0}{1}", i, i % 10 != 0 ? "" : "\n");
            }

        }
    }
}
