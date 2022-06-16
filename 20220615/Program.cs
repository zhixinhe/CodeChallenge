// See https://aka.ms/new-console-template for more information


using System;



public class Test

{

    public static int MinMaxMul(int n, int l, int r, int[] a)

    {

        //this is default OUTPUT. You can change it.

        //int result = 1;

        int maxval = int.MinValue;
        int minval = int.MaxValue;

        //write your Logic here:

        for (int i=l-1; i<r; i++) {

            if (a[i] > maxval) maxval = a[i];

            if (a[i] < minval) minval = a[i];

        }



        return maxval * minval;

    }



    public static void Main()

    {

        string[]? tokens = Console.ReadLine().Split();

        int n = Convert.ToInt32(tokens[0]);

        int l = Convert.ToInt32(tokens[1]);

        int r = Convert.ToInt32(tokens[2]);

        int[] a = new int[n];

        string[]? tokens_line2 = Console.ReadLine().Split();

        for(int i = 0; i < n; i++)

        {

            a[i] = Convert.ToInt32(tokens_line2[i]);

        }

        Console.WriteLine(MinMaxMul(n, l, r, a));

    }

}