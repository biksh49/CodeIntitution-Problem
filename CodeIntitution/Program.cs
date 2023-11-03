// See https://aka.ms/new-console-template for more information
using CodeIntitution.Array;

Console.WriteLine("Hello, World!");

#region Array

#region Row-Major Traversal Problem
RowTraversal rowTraversal = new RowTraversal();
//Problem:

//Input: matrix = [[1, 2, 3], [4, 5, 6], [7, 8, 9]]
//Output: [1, 2, 3, 4, 5, 6, 7, 8, 9]
//Explanation: Above is the row-major traversal of the given matrix

int[,] matrix = new int[,]
{
    {1,2,3},
    {4,5,6},
    {7,8,9}
};
rowTraversal.rowMajorTraversal(matrix);
#endregion 

#endregion
