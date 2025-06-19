using System;
using System.Diagnostics;

namespace A025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = " Hello, World ";

            string t;

            Console.WriteLine(s.Length);
            Console.WriteLine(s[8]);
            Console.WriteLine(s.Insert(8, "C# "));
            Console.WriteLine(s.PadLeft(20, '.'));
            Console.WriteLine(s.PadRight(20, '.'));
            Console.WriteLine(s.Remove(6));
            Console.WriteLine(s.Remove(6,2));
            Console.WriteLine(s.Replace('l','m'));
            Console.WriteLine(s.ToLower());
            Console.WriteLine(s.ToUpper());
            Console.WriteLine('/' + s.TrimStart() + '/');
            Console.WriteLine('/' + s.TrimEnd() + '/');

            string[] a = s.Split('-');
            foreach(var i in a) Console.WriteLine('/' + i + '/');
            Console.WriteLine(a[0]);

            char[] destination = new char[10];
            s.CopyTo(8, destination, 0, 5);
            Console.WriteLine(destination);
            
            Console.WriteLine(('/'+s.Substring(8) + '/'));
            Console.WriteLine(('/' + s.Substring(8, 2) + '/'));

            Console.WriteLine(s.Contains("ll"));
            Console.WriteLine(s.IndexOf('o'));
            Console.WriteLine(s.CompareTo("abc"));

            Console.WriteLine(t= String.Copy(s));

            String[] val = { "apple", "orang" };
            String result = String.Join(" ", val);
            Console.WriteLine(result);

        }
    }
}
