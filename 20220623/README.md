Mathematics: Digits in Factorial Division

Oliver and James are playing with numbers. Each time they play, they take two numbers a and b (where a >= b).
They try to find factorials of both the numbers and then divide the bigger factorial by the smaller factorial.
Find the sum of digits in the quotient of the division performed.

Note
An integer a is a positive integer.
An integer b is a positive integer.

Function Description
In the provided code snippet, implement the provided sumDigits(...) method using the variables to print the sum of digits in the quotient of the division performed. You can write your code in the space below the phrase “WRITE YOUR LOGIC HERE”.

There will be multiple test cases running so the Input and Output should match exactly as provided.
The base Output variable result is set to a default value of -404 which can be modified. Additionally, you can add or remove these output variables.

Input Format
The first line contains an integer a.
The second line contains an integer b.

Sample Input
5    -- denotes an integer a
3    --denotes an integer b

Constraints
0 <= a <= 12.
0 <= b <= 12.
a >= b

Output Format
The output contains the sum of digits in the quotient of factorial of a divided by the factorial of b.

Sample Output
2

Explanation
a=5
b=3
Factorial of a = 5! = 1*2*3*4*5 = 120
Factorial of b = 3! = 1*2*3 = 6
Division = 120/6 = 20
Sum of digits in quotient i.e. = 2+0 = 2.
Hence, the output is 2.
Skill: Coding - Easy