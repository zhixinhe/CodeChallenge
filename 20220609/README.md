Dynamic Programming: Maximum Sum

You are given a N*M matrix. N denotes the number of rows and M denotes the number of columns.
You can be in any row but you have to start in the first column.
Initially, the sum is 0.
You can move only (right->, right up /, and right down\).
You have to add each number to the sum as you move in the array.
Find the maximum sum that can be obtained.

Note
From a given cell, you can move to the cell at the right or diagonally up towards the right or diagonally down towards the right.


Function Description
In the provided code snippet, implement the provided maxSum(...) method using the variables to print the maximum sum that can be obtained. You can write your code in the space below the phrase “WRITE YOUR LOGIC HERE”. 

There will be multiple test cases running so the Input and Output should match exactly as provided.
The base output variable result is set to a default value of -404 which can be modified. Additionally, you can add or remove these output variables.

Input Format
The first line contains the number of rows N.
The second line contains the number of columns M.
The next N lines contain M space-separated integers.

Sample Input
3         -- denotes N
3         -- denotes M
1 3 3   -- denotes M integers
2 1 4   -- denotes M integers
0 6 4   -- denotes M integers

Constraints
1 ≤ N, M ≤ 102
0 ≤ cell[i][j] ≤ 105

Output Format
The output contains a single integer denoting the maximum sum that can be obtained.

Sample Output
12

Explanation
The path with which you can travel:
2 (1,0)-> 6 (2,1)-> 4 (2,2)
2 + 6 + 4 = 12
Hence, the output is 12.