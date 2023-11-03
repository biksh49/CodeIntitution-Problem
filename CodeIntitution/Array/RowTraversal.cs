using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeIntitution.Array
{
    internal class RowTraversal
    {
        

        public int[] RowMajorTraversal(int[,] matrix)
        {
            
            // always check the parameter is null or not in any problem
            if (matrix.Length == 0)
            {
                return new int[0];
            }

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int totalElements= rows * cols;

            int[] path = new int[totalElements];

            int index = 0;
            
            for(int i=0; i<rows; i++)
            {
                for(int j=0; j<cols; j++)
                {
                    path[index++]= matrix[i,j];
                }
            }
            return path;

        }
    }
}
