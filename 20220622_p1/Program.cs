using System;

public class Test
{
    public static int[] tomAndJerry(int N, int T, int J, int[] A)
    {
        //this is default OUTPUT. You can change it.
        int[] result = new int[2];
        result[0] = 0;
        result[1] = 0;
        //write your Logic here:
        for (int i=0; i<N; i++) {
            int min = A[i];
            int idx = i;
            for (int j=i+1; j<N; j++) {
                if (min > A[j]) {
                    idx = j;
                    min = A[j];
                }
            }
            int temp = A[i];
            A[i] = min;
            A[idx] = temp;
        }
        int tCost = 0;
        int jCost = 0;
        for (int i=0; i<N; i++) {
            if (A[i] % 2 == 0) {
                tCost += A[i];
                if (tCost <= T) result[0] += 1;
            } else {
                jCost += A[i];
                if (jCost <= J) result[1] += 1;
            }
        }

        return result;
    }

    public static void Main()
    {
        // INPUT [uncomment & modify if required]                                                                                                                                                                                                                                                                           
        string[] ip = Console.ReadLine().Split(' ');
        int N = int.Parse(ip[0]);
        int T = int.Parse(ip[1]);
        int J = int.Parse(ip[2]);
        
        int[] A = new int[N];
        string[] tokens = Console.ReadLine().Split();
        int i;
        for (i = 0; i < N; i++)
        {
            A[i] = Convert.ToInt32(tokens[i]);
        }
        
        // OUTPUT [uncomment & modify if required]
        int[] r = tomAndJerry(N, T, J, A);
        Console.WriteLine($"{r[0]} {r[1]}");
    }
}