Array Operations: Buy K Get 1

You are given an integer array A of length N, representing the cost of N objects. You are also given an integer K.
If you buy K objects having costs C1, C2, … CK, then you can take one object having cost <= Minimum(C1, C2, … CK) for free.
Find the minimum amount of money required to buy all the objects.

Function Description
In the provided code snippet, implement the provided BKG1(...) method using the variables to print the minimum amount of money required to buy all the objects. You can write your code in the space below the phrase “WRITE YOUR LOGIC HERE”.
There will be multiple test cases running so the Input and Output should match exactly as provided.
The base Output variable result is set to a default value of -404 which can be modified. Additionally, you can add or remove these output variables.

Input Format
The first line contains two integers N and K denoting the number of objects and the value of K respectively.
The second line contains N space-separated integers denoting the cost of the objects.

Constraints
1 <= N, K <= 105
0 <= A[i] <= 109

Sample Input
5 2            -- denotes the number of objects N and the value of K.
2 9 6 5 2   -- denotes N space-separated integers denoting the cost of the objects.

Output Format
The output contains the minimum amount of money required to buy all the objects.

Sample Output

19

Explanation
A = [2, 9, 6, 5, 2] and K = 2
The best way to buy all the 5 objects is:
1)     Buy objects with costs 6 and 9 → Get the object with cost 5 for free
2)     Buy objects with costs 2 and 2
Total cost incurred is 6 + 9 + 2 + 2 = 19.
Hence, the minimum amount of money required is 19.

Skill: Coding - Easy

INPUT	                                            ACTUAL OUTPUT	EXPECTED OUTPUT
5 2 
2 9 6 5 2	                                        19	            19

4 3 
23874 2375 923754 33345	                            980973	        980973

3 1 
3939494 243523 409903	                            4183017         4183017

10 5 
0 0 0 0 0 0 0 0 0 0	                                0	            0

9 4 
34 27 42375 902375 29475 34 2 414 0	                974702          974702

11 3 
3434 45 3425 24 524562 45 425 90378940 234 235 9900	90917601        90917601