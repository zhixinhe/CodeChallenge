Household Income

A city has N families, and every family has 2 members. 
If two families have equal income, we compare the incomes of the second members of both families. 
If the second member's income is greater, then will be given less priority, i.e., they will come first in the order. 
If the incomes of the second members are also equal, then the house-id will be compared. 
The family whose house-id is less will be given less priority, i.e., they will come first in the order. 

Find the total incomes of the families and their house-ids, sorted in ascending order of their income. 

Note
House-id will be the index of the array (0-based).

Function Description
In the provided code snippet, implement the provided householdIncome(...) method using the variables to print the pattern for each line from 1 to i. You can write your code in the space below the phrase “WRITE YOUR LOGIC HERE”.

There will be multiple test cases running so the Input and Output should match exactly as provided.
The base Output variable result is set to a default value of -404 which can be modified. Additionally, you can add or remove these output variables.

Input Format
The first line contains an integer N, denoting the size of an array.
The second line contains N elements of array A, denoting the income of the first member.
The third line contains N elements of array B, denoting the income of the second member.

Sample Input
5                                                       -- denotes N, the size of an array
14 12 10 12 11                               -- denotes income of the first member
10 14 14 10 10                               -- denotes income of the second member

Constraints
1<= N <=100
1<= Ai,Bi <=10000

Output Format
The output contains the total incomes of the families and their house-ids, sorted in ascending order of their income, each on a new line. 

Sample Output
21 4
22 3
24 2
24 0
26 1

Explanation
For house-id 0, income is 10+14 = 24.
For house-id 1, income is 12+14 = 26.
For house-id 2, income is 10+14 = 24.
For house-id 3, income is 12+10 = 22.
For house-id 4, income is 11+10 = 21.
House-ids 0 and 2 have equal income.
Check the income of the second member a2[0] and a2[2].
Since the value of a2[2] > a2[0], house-id 2 will come before house-id 0.
Skill: Coding - Easy