using System;

public class Test
{
    public static int[] carCollection(int N,int K, int[] X,int[] M)
    {
        //this is default OUTPUT. You can change it.
        int[] result = new int[K];
        
        //write your Logic here:
        for (int i=0; i<K; i++)
        {
            for (int j=0; j<N; j++)
            {
                if (X[j] <= M[i])
                {
                    result[i] = j + 1;
                }
            }
        }
        return result;
    }

    public static void Main()
    {
        // INPUT [uncomment & modify if required]
        int N = Convert.ToInt32(Console.ReadLine());
        int[] X = new int[N];
        string[] tokens = Console.ReadLine().Trim().Split(' ');
        for (int i=0; i<N; i++)
        {
            X[i] = int.Parse(tokens[i]);
        }
        int K = Convert.ToInt32(Console.ReadLine());
        int[] M = new int[K];
        string[] tokensK = Console.ReadLine().Trim().Split(' ');
        for (int i=0; i<K; i++)
        {
            M[i] = int.Parse(tokensK[i]);
        }
        
        
        // OUTPUT [uncomment & modify if required]
        int[] result = carCollection(N,K,X,M);
        for (int i=0; i<K; i++)
        {
            Console.Write(result[i] + " ");
        }
        Console.WriteLine();
    }
}