Searching Algorithm: Fertile Sectors

Mitchell has a large piece of land. His land is divided into multiple square-shaped sectors. Some sectors are fertile, while some sectors are infertile.
He wants to find out the total number of fertile sectors.
You will be given a 2-D array A. Each cell contains an integer value.
The dimensions of one sector will be 2 cells*2 cells. The sum of all four elements of the sector is called the "fertility index".
If the "fertility index" of the sector is divisible by 4, then the sector will be considered fertile, otherwise, it is infertile.

Print total number of fertile sectors. If there is no fertile sector, print 0.

Note
Consider the land given below:
1	2	3
4	5	6
7	8	9
The formed sectors are:



The 2-D array will be N*N (square-shaped).

Function Description
In the provided code snippet, implement the provided fertileSector(...) method to print the total number of fertile sectors. You can write your code in the space below the phrase “WRITE YOUR LOGIC HERE”.

There will be multiple test cases running so the Input and Output should match exactly as provided.
The base Output variable result is set to a default value of -404 which can be modified. Additionally, you can add or remove these output variables.

Input Format
The first line contains an integer N, denoting the number of rows and columns.
Next N lines contain N space-separated integers denoting A[i][j] denoting the cell values.

Sample Input
3
1 3 5
4 8 2
7 9 6
 
Constraints
3<=N<=10
0<=A[i][j]<1000

Output Format
The output contains a single integer denoting the total number of fertile sectors.

Sample Output
2
 
Explanation
The first sector contains 1 3 whose fertility index is 16. It is a fertile sector.
The second sector is 3 5 whose fertility index is 18, which is not divisible by 4. Hence, it is an infertile sector.
The third sector is 4 8 whose fertility index is 28. It is a fertile sector.
The remaining sectors are infertile.
Hence, the output is 2 (total number of fertile sectors).