using System;
using System.Collections.Generic;

public class Test{

    public static int lastGladiatorStrength(int N,int[] A){
        //this is default OUTPUT. You can change it.
        int result = 0;
        int nzcount = nzeroCount(N, A);
        //Console.WriteLine(nzcount);
        while (nzcount > 1) {
            //Console.WriteLine(nzcount);
            sortArray(N, A);
            //Console.WriteLine(A);
            A[0] = A[0] - A[1];
            A[1] = 0;
            nzcount = nzeroCount(N, A);
            //Console.WriteLine(A);
        }

        for (int i=0; i<N; i++) {
            if (A[i] != 0) result = A[i];
        }
        
        return result;
    }
    public static int nzeroCount(int N, int[] A)
    {
        int r = 0;
        for (int i=0; i<N; i++) {
            if (A[i] != 0) r++;
        }
        return r;
    }
    public static void sortArray(int N, int[] A)
    {
        for (int i=0; i<N; i++) {
            int idx = i;
            int maxV = A[i];
            for (int j=i+1; j<N; j++) {
                if (A[j] > maxV) {
                    maxV = A[j];
                    idx = j;
                }
            }
            int temp = A[i];
            A[i] = maxV;
            A[idx] = temp;
        }
    }


    // INPUT [uncomment & modify if required]
    public static void Main(){
        string line = "All the Best!";
        List<string> temp = new List<string> { };
        
        while ( ! string .IsNullOrEmpty (line)){
            line = Console.ReadLine();
            
            if (line!=null){
                string[] elements = line.Split(' ');
                
                foreach (string element in elements)
                {
                    temp.Add(element);
                }

            }
        }

        int N = Convert.ToInt32(temp[0]);
        int[] A = new int[N];
        for(int i = 1; i < 1+N; i++) {
            A[i-(1)] = Convert.ToInt32(temp[i]);
        }
        
        
        // OUTPUT [uncomment & modify if required]
        
        Console.WriteLine(lastGladiatorStrength(N,A));
    }

}