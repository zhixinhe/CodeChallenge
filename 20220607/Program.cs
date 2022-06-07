using System;

public class Test
{
    public static int[] colorPen(int N,int Q,int[] A, int[] queries)
    {
        //this is default OUTPUT. You can change it.
        int[] result = new int[Q];
        int[] deck = new int[N];
        for (int i=0; i<N; i++) {
            deck[i] = A[i];
        }
        //write your Logic here:
        for (int j=0; j<Q; j++) {
            int pos=-1;
            for (int i=0; i<N; i++) {
                if (A[i] == queries[j]) {
                    deck[0] = A[i];
                    pos = i;
                    break;
                } else {
                    if (pos == -1) {
                        deck[i+1] = A[i];
                    } else {
                        deck[i] = A[i];
                    }
                }
            }
            for (int k=0; k<=pos; k++) {
                A[k] = deck[k];
            }
            result[j] = pos + 1;
        }

        return result;
    }

    public static void Main()
    {
        // INPUT [uncomment & modify if required]
        string[] ip = Console.ReadLine().Split(' ');
        int N = int.Parse(ip[0]);
        int Q = int.Parse(ip[1]);
        
        int[] A = new int[N];
        string[] tokens = Console.ReadLine().Split();
        int i;
        for (i = 0; i < N; i++)
        {
            A[i] = Convert.ToInt32(tokens[i]);
        }
        
        int[] queries = new int[Q];
        string[] tokens_1 = Console.ReadLine().Split();
        for (i = 0; i < Q; i++)
        {
            queries[i] = Convert.ToInt32(tokens_1[i]);
        }
        
        // OUTPUT [uncomment & modify if required]
        int[] result = colorPen(N,Q,A,queries);
        for (int j=0; j<Q; j++) {
            Console.Write(result[j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}