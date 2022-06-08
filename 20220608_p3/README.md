Algorithms: Car Collection

George wants to purchase a car from N different car showrooms in the city. Each car showroom contains only one type of car.
Given an array X, where Xi denotes the price of one car in the ith showroom, George plans to buy a car for K consecutive months.
George has been given K months and in the ith month, he can spend M[i] coins purchasing a car.
Print K-space-separated integers where ith of them should be equal to the number of showrooms where George will be able to buy a car on the ith month.  

Note:
Prices of cars in the showrooms numbered from 1 to N are in increasing order. 
George cannot use coins from the previous month. 

Function Description:
In the provided code snippet, implement the provided carCollection(...) method.
You can write your code in the space below the phrase “WRITE YOUR LOGIC HERE”.
There will be multiple test cases running so the Input and Output should match exactly as provided.
The base Output variable result is set to a default value of -404 which can be modified. Additionally, you can add or remove these output variables.

Input Format 
The first line of the input contains a single integer N, which denotes the number of showrooms in the city that sell cars. 
The second line of input contains N space-separated integers X1, X2, X3 ………Xn denoting price of the car in ith showroom in increasing order. 
The third line of input contains a single integer K, denoting the number of months George plans to purchase the car. 
The fourth line contains K space-separated integers M1, M2, M3 ………Mk, denoting the number of coins George can spend on the ith month. 

Sample Input 
5                   -- denotes N - Number of car showrooms 
3 6 8 10 11   -- denotes Xi prices of cars in showrooms from 1 to N. 
4                   -- denotes K - Number of months 
5 10 3 11      --denotes Mi the number of coins in an ith month.

Constraints 
1<= N <= 1000
1<= Xi <= 1000
1<= K <= 1000
1<= Mi <= 100000

Output Format 
The output contains K space-separated integers where ith of them should be equal to the number of different showrooms where George will be able to buy a car on the ith month.   

Sample Output 
1 4 1 5 
  
Explanation  
Given car prices are [3,6,8,10,11] and the number of coins in all months are [5,10,3,11] 
For the 1st month, the number of coins is 5. So, he can purchase a car from 1 showroom having a car price of 3.
The prices of the cars from the rest of the showrooms is greater than 5.
Thus, George has the option of 1 showroom to purchase a car. 
For the 2nd month, the number of coins is 10. So, he can purchase car from first 4 showrooms as 3<=10 ,6<=10, 8<=10, 10<=10.
Thus, George has options of 4 showrooms to purchase a car. 
For the 3rd month, the number of coins is 3. So, he can purchase a car from 1 showroom with having car price of 3. The prices of the cars from the rest of the showrooms is greater than 3.
Thus, the answer is 1. 
For the 4th month, the number of coins is 11. So, he can purchase a car from all showrooms.
Thus, the answer is 5. 
Hence, the final output becomes 1 4 1 5.


test cases:
INPUT	                                        ACTUAL OUTPUT	EXPECTED OUTPUT
5 3 6 8 10 11 4 5 10 3 11		                                1 4 1 5
5 3 6 10 11 1000 4 1 14 999 1001		                        0 4 4 5
3 309 435 482 7 245 241 909 745 980 29 521		                0 0 3 3 3 0 3
4 45 52 101 200 2 50 12		                                    1 0
6 10 20 30 40 50 60 6 35 15 25 45 55 65		                    3 1 2 4 5 6
6 10 12 13 14 15 16 7 1 1 1 1 1 1 1		                        0 0 0 0 0 0 0