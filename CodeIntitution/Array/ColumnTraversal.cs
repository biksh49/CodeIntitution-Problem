using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeIntitution.Array
{
    internal class ColumnTraversal
    {
        public int[] ColumnMajorTraversal(int[,]matrix) {
            if(matrix.Length ==0)
                return new int[0];

            var rows= matrix.GetLength(0);
            var cols= matrix.GetLength(1);

            var totalElements= rows*cols;

            int[] path= new int[totalElements];
            int index = 0; 
            for(int i=0; i<cols; i++)
            {
                for(int j=0; j < rows; j++)
                {
                    path[index++] = matrix[j,i];
                }
            }
            return path;
        }
    }
}
