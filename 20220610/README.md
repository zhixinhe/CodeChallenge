Medicine of Patients

A hospital has N numbers of patients.
Given an array, med[i] of N elements, med[i] describes the amount of medicine required by the ith patient. Initially, all the patients have zero amount of medicine and you want to provide them with medicines.
You can perform two types of operations :
In the 1st operation, you can choose any patient and increase the amount of medicine by 1.
In 2nd operation, you can multiply the amount of medicine of all the N patients by 2.
Calculate the minimum number of operations required to give exactly med[i] amount of medicine to all patients.
 
Function Description
In the provided code snippet, implement the provided medicineOfPatients(...) method using the variables to find the minimum number of operations required to give the exactly med[] amount of medicine to all patients. You can write your code in the space below the phrase “WRITE YOUR LOGIC HERE”.

There will be multiple test cases running so the Input and Output should match exactly as provided.
The base Output variable result is set to a default value of -404 which can be modified. Additionally, you can add or remove these output variables.
 
Input Format
The first line of the input contains one integer N ( 1 ≤ N ≤ 200000 ) denoting the size of an array.
The second line of the input contains N elements of the array med[].

Constraints
1 ≤ N ≤ 200000
0 ≤ med[ i ] <= 200000
 
Sample Input
3         -- denotes N the size of an array
2 1 2   -- denotes N elements of an array med[]

Output Format
The output contains the minimum number of operations required to give the exactly med[i] amount of medicine to all patients.
 
Sample Output
4
 
Explanation
1.  Type 1 operation for index=2,
      [0, 0, 0] -> [0, 0, 1]
2. Type 1 operation for index=0,
     [0, 0, 1] -> [1, 0, 1]
3. Type 2 operation, [1, 0, 1] -> [2, 0, 2]
4. Type 1 operation for index=1,
    [2, 0, 2] -> [2, 1, 2]
The minimum number of operations required to give the exactly med[] amount of medicine to all patients is 4.
Hence, the output is 4.
Skill: Coding - Medium