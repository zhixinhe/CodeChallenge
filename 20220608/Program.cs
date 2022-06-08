using System;
using System.Collections.Generic;

public class Test{

    public static int[] cubeSquare(int T,int[] N){
        //this is default OUTPUT. You can change it.
        int[] result = new int[T];
        //write your Logic here:
        for (int i=0;i<T;i++)
        {
            result[i] = numCandS(N[i]);
        }
        
        return result;
    }
    public static int numCandS(int N)
    {
        
        HashSet<int> sc = new HashSet<int>();
        for (int i=1; i<N; i++)
        {
            int s = i * i;
            int c = i * i * i;
            //Console.WriteLine($"{i}: s={s} c={c}");
            if (s > N) break;
            if (s <= N) sc.Add(s);
            if (c <= N) sc.Add(c);
        }
        return sc.Count();
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

        int T = Convert.ToInt32(temp[0]);
        int[] N = new int[T];
        for(int i = 1; i < 1+T; i++) {
            N[i-(1)] = Convert.ToInt32(temp[i]);
        }
        
        
        // OUTPUT [uncomment & modify if required]
        int[] answer = cubeSquare(T, N);
        for (int i=0;i<T;i++)
        {
            Console.WriteLine(answer[i]);
        }
    }

}
