Searching Algorithms: Equal Sums

A string S containing lowercase alphabets only is given.
The alphabets are assigned numeric values from 1 to 26 from "a" to "z" respectively.
Search an element of the string such that the sum of numeric values of all the elements to its left is equal to the sum numeric values of all elements to its right.

Note
String S contains at least one element.

Function Description
In the provided code snippet, implement the provided equalSums(...) method using the parameters to return the character from the string such that the sum of NUMERIC values of all elements to the left is equal to the sum NUMERIC values of all elements to the right. You can write your code in the space below the phrase “WRITE YOUR LOGIC HERE”.

There will be multiple test cases running so the Input and Output should match exactly as provided.
The base Output variable result is set to a default value of -404 which can be modified. Additionally, you can add or remove these output variables.

Input Format
The only line of each test case contains a string S.

Sample Input
abec   -- String S
 
Constraints
1<= S.length() <= 105

Output Format
The output should contain the element in string S such that the sum of numeric values of all elements to the left is equal to the sum numeric values of all elements to the right.

Sample Output
e
 
Explanation
S =”abec”
Numeric values of :
a = 1 ; b = 2 ; e = 5 ; c = 3 ;
Hence, a+b=c  (i.e. 1 + 2 = 3)
As the sum of numeric values of elements towards the left of element e is equal to the sum of numeric values of elements towards the right, return "e".

test cases:
INPUT	                ACTUAL OUTPUT	EXPECTED OUTPUT
abec	                e	            e
avengers	            g	            g
happydussehra		                    u
saippuakivikauppias	    v	            v
unitedarabemirates	    a	            a
yuvrajsingh		                        r