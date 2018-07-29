using MatrixChecker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatrixChecker.Repositories
{
    public class MatrixRepository
    {
        private MatrixCheckerContext matrixContext;

        public MatrixRepository(MatrixCheckerContext matrixContext)
        {
            this.matrixContext = matrixContext;
        }

        public void AddMatrix(Matrix matrix)
        {
            matrixContext.Matrices.Add(matrix);
            matrixContext.SaveChanges();
        }

        public List<Matrix> GetMatrices()
        {
            return matrixContext.Matrices.ToList();
        }
    }
}
