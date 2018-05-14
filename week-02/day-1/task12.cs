using System;

namespace task12_
{
    class Program
    {
        static void Main(string[] args)
        {

            //12 matrix
            // - Create (dynamically) a two dimensional array
            //   with the following matrix. Use a loop!
            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            // - Print this two dimensional array to the output

            int[,] matrix = new int[4, 4];
         
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					if (i == j)
                    {
                        matrix[i,j] = 1;
                    }
				}  
               
			}
            Console.WriteL(matrix[i, j] + " ");
		}
    }
}
