Bit Operations: Base-9

You are given a number N represented in base-10.

Find the base-9 representation of N and print it.

Notes
Decimal representation is a base-10 representation.
Base-9 is a numeral system that only uses 9 digits to make up its numbers: 0,1, 2, 3, 4, 5, 6, 7, 8.

Function Description
In the provided code snippet, implement the provided base(...) method using the variables to print the corresponding base-9 representation of N. You can write your code in the space below the phrase “WRITE YOUR LOGIC HERE”. 

There will be multiple test cases running so the Input and Output should match exactly as provided.
The base output variable result is set to a default value of -404 which can be modified. Additionally, you can add or remove these output variables.

Input Format
The first line of input contains an integer N.

Sample Input
11     -- denotes N
 
Constraints
1<= N <=1000
 
Output Format
The output contains the corresponding base-9 representation of N.

Sample Output
12
 
Explanation
The number 11 is given in the base-10 representation:
Step	Operation	Result	Remainder
1	    11 / 9	    9	    2
2	    1/9	        0	    1
Writing the remainders in the reverse order: 12
12 is the base-9 representation of 11.
Skill: Coding - Easy