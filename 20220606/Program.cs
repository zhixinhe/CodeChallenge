
using System;

public class Test
{
    public static long lastSum(int N,int[] A)
    {
        //this is default OUTPUT. You can change it.
        long result = 0;
        
        //write your Logic here:
        for (int i=0; i<N; i++) {
            int lastDigit = A[i] % 10;
            result += lastDigit;
        }

        return result;
    }

    public static void Main()
    {
        // INPUT [uncomment & modify if required]                                                                                                                                                                                                                                                                           
        int N = Convert.ToInt32(Console.ReadLine());
        
        int[] A = new int[N];
        string[] tokens = Console.ReadLine().Split();
        int i;
        for (i = 0; i < N; i++)
        {
            A[i] = Convert.ToInt32(tokens[i]);
        }
        
        // OUTPUT [uncomment & modify if required]
        long r = lastSum(N, A);
        Console.WriteLine(r % 1000000000L );
    }
}
