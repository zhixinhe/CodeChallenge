using System;



public class Test

{

    public static int maxSum(int beginRow, int beginCol, int N, int M, int[,] matrix)

    {

        //this is default OUTPUT. You can change it.
        if (beginCol == M-1) return matrix[beginRow, beginCol];
        int result = matrix[beginRow, beginCol];
        int maxOfRight = maxSum(beginRow, beginCol + 1, N, M, matrix);
        if (beginRow-1 >=0 ) {
            int rightUpSam = maxSum(beginRow - 1, beginCol + 1, N, M, matrix);
            if (rightUpSam > maxOfRight) maxOfRight = rightUpSam;
        }
        if (beginRow+1 < N) {
            int rightDownSam = maxSum(beginRow + 1, beginCol + 1, N, M, matrix);
            if (rightDownSam > maxOfRight) maxOfRight = rightDownSam;
        }

        

        //write your Logic here:

        





        



        return result+maxOfRight;

    }

    

    public static void Main()

    {

        // INPUT [uncomment & modify if required]

        int N = 0;

        int M = 0;



        N = Convert.ToInt32(Console.ReadLine());



        M = Convert.ToInt32(Console.ReadLine());



        int[,] matrix = new int[N, M];



        for (int i = 0; i < N; i++)

        {

            string[] tokens = Console.ReadLine().Split();

            for (int j = 0; j < M; j++)

            {

                matrix[i, j] = Convert.ToInt32(tokens[j]);

            }

        }



        // OUTPUT [uncomment & modify if required]
        int max = maxSum(0, 0, N, M, matrix);
        for (int i = 1; i < N; i++)
        {
            int maxOfRow = maxSum(i, 0, N, M, matrix);
            if (maxOfRow > max) max = maxOfRow;
        }
        Console.WriteLine(max);

    }

}