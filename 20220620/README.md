Array Operations: Height of Apple Trees

Olivia has N apple trees in her garden, each having height of H[i] meters.
An apple tree grows 1 meter in height in 1 year.
The maximum height that an apple tree can attain is M meters.
Determine the height of all the apple trees after K years.

Function Description
In the provided code snippet, implement the provided appleTrees(...) method using the variables to print the height of all the apple trees after K years. You can write your code in the space below the phrase “WRITE YOUR LOGIC HERE”.

There will be multiple test cases running so the Input and Output should match exactly as provided.
The base Output variable result is set to a default value of -404 which can be modified. Additionally, you can add or remove these output variables. 

Input Format
The first line of input contains three integers: N denotes the number of trees, M denotes the maximum possible height of a tree, and K denotes the number of years.
The next line of input contains N space-separated integers denoting the height of the trees.

Sample Input
3 3 1           --denotes N, M, K.
1 2 3           --denotes the heights of the trees. 

Constraints
1 <= N <= 100, 1 <= M <=109, 1<= K <=109
1 <= H[i]<= M

Output Format
The output contains N space-separated integers, denoting the height of all the apple trees after K years.

Sample Output
2 3 3
 
Explanation
The first and second trees will grow 1 meter in height after 1 year.
The third tree won’t grow any further as it has already attained the maximum possible height.
Hence, after 1 year the height of the trees will be 1+1=2, 2+1=3, and 3+0=3 respectively.
Hence, the output is:
2 3 3
Skill: Coding - Easy

INPUT	ACTUAL OUTPUT	EXPECTED OUTPUT
3 3 1 
1 2 3	2 3 3	        2 3 3