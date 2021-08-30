using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            decimal c = 3.5m;
            decimal d = 1.2m;
            int e = 4;
            int f = 5;
            int g = 1;
            int h = 0;
            bool isMoney = true;
            bool isNotMoney = false;

            Console.WriteLine(Add(a , b));
            Console.WriteLine(Add(c, d));
            Console.WriteLine(Add(e, f, isMoney));
            Console.WriteLine(Add(g, h, isMoney));
            Console.WriteLine(Add(e, f, isNotMoney));
        }
        static int Add(int x, int y)
        {
            return (x + y);
        }
        static decimal Add(decimal x, decimal y)
        {
            return (x + y);
        }
        static string Add(int x, int y, bool isMoney)
        {
            int sum = x + y;
            string answer;
            if (isMoney)
            {
                if (sum == 1) { answer = ($"{sum} dollar"); }
                else {answer = ($"{sum} dollars"); }
            }
            else { answer = ($"{sum}"); }

            return answer;
        }
    }
}
