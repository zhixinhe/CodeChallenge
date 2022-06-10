using System;
using System.Collections.Generic;

public class Test{

    public static int medicineOfPatients(int N,int[] med){
        //this is default OUTPUT. You can change it.
        int result = 0;
        //write your Logic here:
        
        while (NumOfNonZero(N, med) != 0)
        {
            int numOfOdd = NumOfOdd(N, med);
            if (numOfOdd != 0) 
            {
                for (int i=0; i<N; i++)
                {
                    if (IsOdd(med[i])) med[i] -= 1;
                }
                result += numOfOdd;
            }
            int numOfNonZero = NumOfNonZero(N, med);
            if (numOfNonZero != 0)
            {
                result += 1;
                for (int j=0; j<N; j++)
                {
                    if (!IsOdd(med[j])) med[j] = med[j] / 2;
                }
            }
        }
        
        return result;
    }
    public static int NumOfNonZero(int N, int[] med)
    {
        int count = 0;
        for (int i=0; i<N; i++)
        {
            if (med[i] != 0) count++;
        }
        return count;
    }
    public static int NumOfOdd(int N, int[] med)
    {
        int count = 0;
        for (int i=0; i<N; i++)
        {
            if (med[i] % 2 != 0) count++;
        }
        return count;
    }
    public static bool IsOdd(int x)
    {
        return x % 2 == 1 ? true : false;
    }

    // INPUT [uncomment & modify if required]
    public static void Main(){
        int N = Convert.ToInt32(Console.ReadLine());
        int[] med = new int[N];
        string[] tokens = Console.ReadLine().Trim().Split(' ');
        for (int i=0; i<N; i++)
        {
            med[i] = int.Parse(tokens[i]);
        }

        
        // OUTPUT [uncomment & modify if required]
        Console.WriteLine(medicineOfPatients(N,med));
    }

}