Binary Search: Maximum Employees        // this is wierd. I can't clearly understand it.

A typing competition is going to be organized in company X.
Each employee E is given three numbers A, B, and C where A denotes the rank of the employee in the typing test of the previous year.
Employee E can take part in competition only if there are at most B employees whose rank is less than E and at most C employees whose rank is greater than E.
Find the maximum number of employees who can participate in the competition.

Note
The rank greater in number is considered as higher rank and rank with a smaller number is considered as lower rank.

Function Description
 In the provided code snippet, implement the provided maximumNumberOfParticipants(...) method using the variables to print the maximum number of employees who can participate in the competition. You can write your code in the space below the phrase “WRITE YOUR LOGIC HERE”.

There will be multiple test cases running so the Input and Output should match exactly as provided.
The base Output variable result is set to a default value of -404 which can be modified. Additionally, you can add or remove these output variables.

 

Input Format
The first line contains an integer N denoting the number of employees in company X.
Next N line of input contains three numbers A, B and C.

Sample Input

4
1 2 3
2 1 2
3 2 1
4 3 1

Constraints
1 <= N <= 100005
1 <= A <= N
0<= B,C <=100005

Output Format
The output contains the maximum number of employees who can take part in the typing competition.

Sample Output

4

Explanation
All the employees can take part in the competition.
Let E1, E2, E3, and E4 be the four employees.
E1 ->  A= 1 , B=2 and C=3 :
There is no employee whose rank is less than 1, and 3 employees have a higher rank than 1. Hence E1 can participate in the competition.
E2 -> A=2 , B= 1 , C=2 :
The rank of E2 is 2 and B=1, which means only 1 employee whose rank is less than E2 can sit in the competition and there is only one employee E1 whose rank is less than E2 and C=2 means a maximum of 2 employees whose rank is higher than E2 can participate.
E3 -> A=3, B=2 , C=1 :
The rank of E3 is 3 and E3 can participate in the competition because there are at most 2 people below E3 and at most 1 person above E3.
E4-> A=4, B=3 , C=1 :
If E4 will participate, then at most 3 employees below E4 can take part and at most 1 employee above him can take part. As E1, E2 and E3 are taking part in it and are below E4 and no one above E4 is participating, E4 can also take part in it.

test case:
INPUT	                                ACTUAL OUTPUT	EXPECTED OUTPUT
4 1 2 3 2 1 2 3 2 1 4 3 1	            3	            4
5 1 3 2 2 1 2 3 1 2 4 3 1 1 2 4	        3	            3
6 1 3 2 2 3 1 3 1 2 1 2 3 1 2 4 1 4 2	2	            2
3 1 2 3 3 2 1 2 3 1	                    1	            3
5 1 2 3 2 3 4 3 4 5 1 4 5 1 5 2	        2	            3
7 4 6 8 1 2 3 2 5 7 3 4 5 5 3 1 1 5 2	Unhandled Exception: System.NullReferenceException: Object reference not set to an instance of an object at Test.Main () [0x0002d] in <164f05b8552948989fab92f23134bee8>:0 [ERROR] FATAL UNHANDLED EXCEPTION: System.NullReferenceException: Object reference not set to an instance of an object at Test.Main () [0x0002d] in <164f05b8552948989fab92f23134bee8>:0	      4