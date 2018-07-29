using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatrixChecker.Models
{
    public class Matrix
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string MatrixNumbers { get; set; }

        public Matrix(string matrixNumbers)
        {
            Date = DateTime.Now;
            MatrixNumbers = matrixNumbers;
        }
    }
}
