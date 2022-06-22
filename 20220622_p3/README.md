Heaps: Gladiator Strength

In a fighting tournament, every gladiator fights with another gladiator, and every gladiator has a specified strength.
When two gladiators with strengths a & b fight (a <= b), there are 2 possibilities:
If a = b, both are eliminated.
Else a is eliminated and strength of b is reduced to b-a.
In every fight, two gladiators with maximum strength clash. After all the rounds, only one gladiator wins.
Find minimum strength that the winning gladiator can have. Print 0 if no gladiator is left after the final fight. 

Function Description 
In the provided code snippet, implement the provided lastGladiatorStrength(...) method using the variables to print the minimum final strength of the winning gladiator. You can write your code in the space below the phrase “WRITE YOUR LOGIC HERE”.  
 
There will be multiple test cases running so the Input and Output should match exactly as provided. 
The base Output variable result is set to a default value of -404 which can be modified. Additionally, you can add or remove these output variables. 

Input Format 
The first line contains an integer N denoting the total number of gladiators. 
The second line contains N space-separated integers A a0 a1 …. an-1. 
 
Sample Input 
5               -- denotes the total number of gladiators N
2 9 4 1 8   -- denotes the strengths of N gladiators

Constraints 
1 <= N <= 30 
1 <= Ai <= 1000. 
 
Output Format 
The output contains an integer denoting the minimum strength that the winning gladiator can have. If no gladiator is left, print 0. 

Sample Output 
0 

Explanation 
1st fight is between gladiators with strengths 9 & 8.
After the fight, the gladiator with strength 8 is eliminated and the opponent’s strength is reduced to 1.
The array becomes [2,1,4,1,0].  
2nd fight is between gladiators with strengths 4 & 2.
After the fight, the gladiator with strength 2 is eliminated and the opponent’s strength is reduced to 2.
The array becomes [0,1,2,1,0]. 
3rd fight is between gladiators with strengths 2 & 1.
After the fight, the gladiator with strength 1 is eliminated and the opponent’s strength is reduced to 1.
The array becomes [0,0,1,1,0]. 
4th fight, which is the last fight, is between gladiators with strengths 1 & 1. Both are eliminated.
The array becomes [0,0,0,0,0].
Since there are no gladiators left, the output is 0.
Skill: Coding - Medium