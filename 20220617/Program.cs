using System;



public class Test

{

    public static int Base(int N)

    {

        //this is default OUTPUT. You can change it.

        int result = 0;



        //WRITE YOUR LOGIC HERE:

        int b = 1;

        int x = N/9;

        int y = N%9;

        while (N>0) {

            

            result += y * b;

            b *= 10;

            N = x;

            x = N/9;

            y = N%9;

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

    }

}