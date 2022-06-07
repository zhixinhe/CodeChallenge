Searching Algorithm: Color Pen

You have a stack of N pens numbered from top to bottom, i. e. the top pen has index 1 and the bottom pen has index N. Every ith pen has color A[i].
You should process Q queries. The jth query is described by integer t.
For each query, find the highest pen in the stack with color t, i.e. the pen with minimum index; print the position of the pen you found; take the pen and place it on top of the stack.

Note
Print the index of the number given in queries.
After printing the index, shift that number to the top of the stack.

Function Description
In the provided code snippet, implement the provided colorPen(...) method using the variables to print the answer to each query. You can write your code in the space below the phrase “WRITE YOUR LOGIC HERE”.

There will be multiple test cases running so the Input and Output should match exactly as provided.
The base Output variable result is set to a default value of -404 which can be modified. Additionally, you can add or remove these output variables.

Input Format
The first line of input contains N and Q where N is the number of elements in the array and Q is the number of queries. 
The second line of input contains N array elements.
The third line of input contains Q elements for queries.

Sample Input
7 5                              --denotes N and Q
2 1 1 4 3 3 1               --denotes N array elements.
3 2 1 1 4                     --denotes Q elements for queries.
  
Constraints
1<= N <=100.
 0<= Q <=10.

Output Format
The output contains Q space-separated integers denoting the answers for each query.

Sample Output 
5 2 3 1 5 

Explanation
The deck is [2,1,1,4,3,3,1] and the first card with color t1=3 has the position 5
The deck is [3,2,1,1,4,3,1] and the first card with color t2=2 has the position 2
The deck is [2,3,1,1,4,3,1] and the first card with color t3=1 has the position 3
The deck is [1,2,3,1,4,3,1] and the first card with color t4=1 has the position 1
The deck is [1,2,3,1,4,3,1] and the first card with color t5=4 has the position 5
So the output is 5 2 3 1 5.