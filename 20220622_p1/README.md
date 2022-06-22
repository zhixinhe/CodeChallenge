Sorting: Tom and Jerry

Tom and Jerry decide to buy some toys with the money they have. All the toys are different but their cost can be the same.
Tom only buys the toys whose cost is even, and Jerry buys the toys whose cost is odd.
Find the maximum number of toys Tom and Jerry can buy respectively.

Note
Every toy can be bought only once.

Function Description
In the provided code snippet, implement the provided tomAndJerry(...) method using the variables to print the maximum number of toys Tom and Jerry can buy respectively. You can write your code in the space below the phrase “WRITE YOUR LOGIC HERE”. 

There will be multiple test cases running so the Input and Output should match exactly as provided.
The base Output variable result is set to a default value of -404 which can be modified. Additionally, you can add or remove these output variables.

Input Format
The first line of input contains three space-separated integers N, T, and J denoting the number of toys in the shop, money with Tom, and money with Jerry respectively.
The second line of input contains N space-separated integers denoting the cost of the toys.

Sample Input
10 54 75                                                   --denotes N, T, J
12 34 25 32 10 15 20 39 29 30               --denotes cost of N toys

Output Format
The output contains two space-separated integers denoting the maximum number of toys Tom and Jerry can buy respectively.

Sample Output
3 3

Explanation
Tom can buy toys costing 10, 34, 32, 10, 20, 30.
Jerry can buy toys costing 25, 15, 39, 29.
To buy the maximum number of toys, they will buy the toys which cost low.
Hence, Tom will buy the toys costing 10, 10, 20.
He cannot buy the next one because he has only 54 as the total amount.
Jerry will buy the toys costing 15, 25, 29. He cannot buy the remaining ones because he has only 75 as the total amount.
Hence, the answer is 3 3.
Skill: Coding - Easy