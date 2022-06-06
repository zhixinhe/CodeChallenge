Recursion: Last Sum

Given N numbers, print the sum of the last digits of all the numbers using recursion.
Since the sum can be very large, print its modulo 109 + 7.  

Function Description 
In the provided code snippet, implement the provided lastSum(...) method to print the sum of the last digits of all numbers. You can write your code in the space below the phrase “WRITE YOUR LOGIC HERE”.
  
There will be multiple test cases running so the Input and Output should match exactly as provided. The base Output variable result is set to a default value of -404 which can be modified. Additionally, you can add or remove these output variables.  

Input Format
The first line contains N.
The second line contains N space-separated integers.

Constraints
0 <= N <= 10**5
0 <= Each number <= 10**18

Sample Input
3                       -- denotes number of elements N.
123 324 2133   -- denotes N space separated integers.

Output Format 
The output contains the sum of the last digits of the N numbers.
  
Sample Output 
10  

Explanation 
The last digit of 123 is 3.
The last digit of 324 is 4.
The last digit of 2133 is 3.
Hence, the output is (3+4+3)%(10**9) + 7 = 10.