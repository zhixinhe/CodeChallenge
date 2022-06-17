using System;



public class Test

{

    public static int Base(int N, int Base=9)

    {

        //this is default OUTPUT. You can change it.

        int result = 0;



        //WRITE YOUR LOGIC HERE:

        int b = 1;

        int x = N/Base;

        int y = N%Base;

        while (N>0) {

            

            result += y * b;

            b *= 10;

            N = x;

            x = N/Base;

            y = N%Base;

        } 



        return result;

    }

    

    public static void Main()

    {

        //INPUT [uncomment & modify if required]

        int N = 0;

        N = int.Parse(Console.ReadLine());



        //OUTPUT [uncomment & modify if required]
        
        Console.WriteLine(Base(N));
        //OUTPUT for all bases:
        // for (int i = 2; i <= 10; i++)
        // {
            // Console.WriteLine($"N:{N} base:{i} output:{Base(N, i)}");
        // }
    }

}