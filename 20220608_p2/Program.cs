using System;

public class Test
{
    public static int maximumNumberOfParticipants(int N,int[] A,int[] B,int[] C)
    {
        //this is default OUTPUT. You can change it.
        int result = 0;
        
        //write your Logic here:
        for (int i=0; i<N; i++) 
        {
            int numOfEmployeesRankLessThanE = 0;
            int numOfEmployeesRankGreaterThanE = 0;
            int rankOfE = A[i];
            int maxNumOfEmployeesRankLessThanE = B[i];
            int minNumOfEmployeesRankGreaterThanE = C[i];
            
            for (int j=0; j<N; j++)
            {
                //if (i != j) 
                //{
                    if (A[j] < rankOfE) numOfEmployeesRankLessThanE++;
                    if (A[j] > rankOfE) numOfEmployeesRankGreaterThanE++;
                //}
            }
            if (numOfEmployeesRankLessThanE <= maxNumOfEmployeesRankLessThanE && numOfEmployeesRankGreaterThanE >= minNumOfEmployeesRankGreaterThanE) result++;
        }


        return result;
    }

    public static void Main()
    {
        // INPUT [uncomment & modify if required]
        int N = Convert.ToInt32(Console.ReadLine());
        
        int i;
        int[] A = new int[N];
        int[] B = new int[N];
        int[] C = new int[N];
        for(i=0;i<N;i++)
        {
            string[] tokens = Console.ReadLine().Split(' ');
            A[i] = int.Parse(tokens[0]);
            B[i] = int.Parse(tokens[1]);
            C[i] = int.Parse(tokens[2]);
        }
        
        // OUTPUT [uncomment & modify if required]
        Console.WriteLine(maximumNumberOfParticipants(N,A,B,C));
    }
}