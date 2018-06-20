using System;

namespace matrix
{
    public class MatrixTranspose
    {
        public static void Main(string[] args)
        {
			int[,] inputMatrix = 
			{
				{1,2,3},
				{4,5,6},
				{7,8,9}
			};

			Transpose(inputMatrix);            
        }

		public static int[,] Transpose(int[,] matrix)
        {
            int w = matrix.GetLength(0);
            int h = matrix.GetLength(1);

            int[,] result = new int[h, w];

            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    result[j, i] = matrix[i, j];
                }
            }
			for (int i = 0; i < result.GetLength(0); i++)
			{            
				for (int j = 0; j < result.GetLength(1); j++)
				{
					Console.Write(result[i,j] + ", ");                   
				}
				Console.WriteLine();
			}
			return result;
		}
    }
}

// Create a function that takes a matrix (array of arrays) as a parameter and
// returns the transpose of that matrix. The original matrix should remain the
// same.

// For this input:
// [
//     [1, 2, 3],
//     [4, 5, 6],
//     [7, 8, 9]
// ]

// This should be the output:
// [
//     [1, 4, 7],
//     [2, 5, 8],
//     [3, 6, 9]
// ]
