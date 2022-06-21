using System;

public class Test
{
    public static int[] householdIncome(int N, int[] A, int[] B)
    {
        //this is default OUTPUT. You can change it.
        //int result = -404;
        int[] idx = new int[N];
        for (int i=0; i<N; i++) {
            A[i] += B[i];
            idx[i] = i;
        }
        
        for (int i=0; i<N; i++) {
            int currIdx = i;
            int minIdx = currIdx;
            int minVal = A[idx[minIdx]];
            for (int j=currIdx+1; j<N; j++) {
                int cmprIdx = j;
                int cmprVal = A[idx[cmprIdx]];
                if (cmprVal < minVal) {
                    minVal = cmprVal;
                    minIdx = cmprIdx;
                } else if (cmprVal == minVal) {
                    if (B[cmprIdx] > B[minIdx]) minIdx = cmprIdx;
                }
            }
            int temp = idx[currIdx];
            idx[currIdx] = idx[minIdx];
            idx[minIdx] = temp;
        }

        return idx;
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
        
        int[] B = new int[N];
        string[] tokens_1 = Console.ReadLine().Split();
        for (i = 0; i < N; i++)
        {
            B[i] = Convert.ToInt32(tokens_1[i]);
        }
        
        // OUTPUT [uncomment & modify if required]
        int[] idx = householdIncome(N,A,B);
        for (i = 0; i < N; i++) {
            Console.WriteLine($"{A[idx[i]]} {idx[i]}");
        }
    }
}