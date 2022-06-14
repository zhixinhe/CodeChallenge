using System;



public class Test

{

    public static int fertileSector(int N,int[,] A)

    {

        //this is default OUTPUT. You can change it.

        int result = 0;



        //write your Logic here:

        for (int i=0; i<N-1; i++)

        {

            for (int j=0; j<N-1; j++)

            {

                int fertility = A[i,j] + A[i+1,j] + A[i,j+1] + A[i+1,j+1];

                if (fertility % 4 == 0) result += 1;

            }

        }



        return result;

    }

    public static void Main()

    {

        // INPUT [uncomment & modify if required]

        int N = 0;

    



        N = Convert.ToInt32(Console.ReadLine());



       



        int[,] A = new int[N, N];



        for (int i = 0; i < N; i++)

        {

            string[] tokens = Console.ReadLine().Split();

            for (int j = 0; j < N; j++)

            {

                A[i, j] = Convert.ToInt32(tokens[j]);

            }

        }

        

        // OUTPUT [uncomment & modify if required]

        Console.WriteLine(fertileSector(N, A));

    }

}