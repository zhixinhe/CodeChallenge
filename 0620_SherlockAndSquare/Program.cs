// See https://aka.ms/new-console-template for more information
using System;

namespace Solution;
class Program
{
    public static int squares(int a, int b) {
        //int count = 0;
        // for (int i = 0; i*i <= b; i++) {
            // if (i * i <= b && i * i >= a) {
                // count++;
            // }
        // }
        int sq = (int)Math.Ceiling(Math.Sqrt(a));
        int bq = (int)Math.Floor(Math.Sqrt(b));
        return bq - sq + 1;
    }
    public static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int result = squares(a, b);
        Console.WriteLine(result);
    }
}
