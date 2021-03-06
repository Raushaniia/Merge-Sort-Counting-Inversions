# Merge-Sort-Counting-Inversions

In an array, the elements at indices  and  (where ) form an inversion if . In other words, inverted elements  and  are considered to be "out of order". To correct an inversion, we can swap adjacent elements.

For example, consider . It has two inversions:  and . To sort the array, we must perform the following two swaps to correct the inversions:

Given  datasets, print the number of inversions that must be swapped to sort each dataset on a new line.

Input Format

The first line contains an integer, , denoting the number of datasets. 
The  subsequent lines describe each respective dataset over two lines:

The first line contains an integer, , denoting the number of elements in the dataset.
The second line contains  space-separated integers describing the respective values of .
Constraints

Output Format

For each of the  datasets, print the number of inversions that must be swapped to sort the dataset on a new line.

Sample Input

2  
5  
1 1 1 2 2  
5  
2 1 3 1 2
Sample Output

0  
4   
