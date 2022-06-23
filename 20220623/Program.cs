using System;



public class Test

{

    public static int sumDigits(int a, int b)

    {

        //this is default OUTPUT. You can change it.

        int result = 0;

        

        //write your Logic here:

        int fAtoB = 1;

        for (int i=b+1; i<=a; i++) {

            fAtoB *= i;

        }

        //Console.WriteLine(fAtoB);

        while (fAtoB > 0) {

            result += fAtoB % 10;

            fAtoB /= 10;

        }



        return result;

    }



    public static void Main()

    {

        int a = Int32.Parse(Console.ReadLine());

        int b = Int32.Parse(Console.ReadLine());

        Console.WriteLine(sumDigits(a, b));

    }

}