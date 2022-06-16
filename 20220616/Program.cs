using System;



public class Test

{

    public static int BKG1(int N, int K, int[] A)

    {

        //this is default OUTPUT. You can change it.

        int result = 0;

        //int[] sortedA = new int[N];

        //write your Logic here:

        sortDescending(A, N);
        //Console.WriteLine("Sorted Array:"+ string.Join(",", A));
        result = A[0];
        int k = 0;          // k is the number of items which are free for you to take
        for (int i=1; i<N; i++)

        {

            if (i%(k*K+K+k)==0)

            {

                k += 1;

            } else {

                result += A[i];

            }

        }



        return result;

    }

    public static void sortDescending(int[] A, int N)
    {
        for (int i=0; i<N; i++)
        {
            int maxIndex = i;
            int maxValue = A[i];
            for (int j=i+1; j<N; j++)
            {
                if (A[j] > maxValue)
                {
                    maxIndex = j;
                    maxValue = A[j];
                }
            }
            A[maxIndex] = A[i];
            A[i] = maxValue;
        }
    }

    public static void Main()

    {

        // INPUT [uncomment & modify if required]

        int N = 0;

        int K = 0;

        int i = 0;

      

        string[] t = Console.ReadLine().Split();

        N = int.Parse(t[0]);

        K = int.Parse(t[1]);



        int[] A = new int[N];

        

        string[] tokens = Console.ReadLine().Split();

        for (i = 0; i < N; i++)

        {

            A[i] = Convert.ToInt32(tokens[i]);

        }

       

        

        // OUTPUT [uncomment & modify if required]

        Console.WriteLine(BKG1(N, K, A));

    }

}