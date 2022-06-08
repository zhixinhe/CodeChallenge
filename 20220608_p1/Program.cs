using System;



public class Test

{

    public static char equalSums(string S)

    {

        //this is default OUTPUT. You can change it.
        S = S.Trim();   //
        char result = ' ';

        for (int i=1; i<S.Length; i++) {

            string s1 = S.Substring(0, i);

            string s2 = S.Substring(i+1);

            if (sumString(s1) == sumString(s2)) result = S[i];

        }

        //write your Logic here:

        



        return result;

    }



    public static int sumString(string s)

    {

        int result = 0;

        foreach ( var c in s) {

            result += c - 'a' + 1;

        }

        return result;

    }



    public static void Main()

    {

        // INPUT [uncomment & modify if required]

        string S = Console.ReadLine();

    //    Console.WriteLine($"{sumString("happyd")} = {sumString("ssehra")}");
    //    Console.WriteLine($"{sumString("yuv")} = {sumString("ajsingh")}");

        // OUTPUT [uncomment & modify if required]

        Console.WriteLine(equalSums(S));

    }

}