using System;

public class Test
{
    public static void appleTrees(int N,int M,int K,int[] H)
    {
        //this is default OUTPUT. You can change it.
        //int result = -404;
        
        //write your Logic here:
        for (int i=0; i<N; i++) {
            H[i] += K;
            if (H[i] > M) H[i] = M;
        }

        //return result;
    }

    public static void Main()
    {
        // INPUT [uncomment & modify if required]
        string[] ip = Console.ReadLine().Split(' ');
        int N = int.Parse(ip[0]);
        int M = int.Parse(ip[1]);
        int K = int.Parse(ip[2]);
        
        int[] H = new int[N];
        string[] tokens = Console.ReadLine().Split();
        int i;
        for (i = 0; i < N; i++)
        {
            H[i] = Convert.ToInt32(tokens[i]);
        }
        
        // OUTPUT [uncomment & modify if required]
        appleTrees(N, M, K, H);
        for (int j=0; j<N; j++) {
            Console.Write($"{H[j]} ");
        }
        Console.WriteLine();
    }
}