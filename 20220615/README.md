Array Operations: Multiplication

Given an array A of size N and the values of L and R (1 <= L <= R <= N).
Find max(AL1,AL2,…..AR) x min(AL1,AL2,….,AR).

Function Description
In the provided code snippet, implement the provided MinMaxMul() to print the max(AL1,AL2,…..AR) x min(AL1,AL2,….,AR). You can write your code in the space below the phrase “WRITE YOUR LOGIC HERE”.

There will be multiple test cases running so the Input and Output should match exactly as provided.
The base Output variable result is set to a default value of -404 which can be modified. Additionally, you can add or remove these output variables.

Input Format
The first line of input contains three space-separated integers N, L, and R.
The second line of input contains N space-separated integers.

Constraints
1 <= L <= R <= N <= 1000
1 <= A[i] <= 100

Sample Input
5 1 3                              --denotes N, L, and R
1 2 3 4 5                        --denotes N space-separated integers

Output Format
The output contains a single integer denoting the value of max(AL1, AL2,…..AR)xmin(AL1, AL2,…., AR).

Sample Output
3
 
Explanation
Min(1,2,3) X max(1,2,3) = 1x3.
Hence, the output is 3.
Skill: Coding - Easy