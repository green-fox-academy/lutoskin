using MatrixChecker.Models;
using MatrixChecker.Repositories;
using MatrixChecker.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatrixChecker.Services
{
    public class MatrixCheckerService
    {
        private MatrixRepository matrixRepository;

        public MatrixCheckerService(MatrixRepository matrixRepository)
        {
            this.matrixRepository = matrixRepository;
        }

        public IndexViewModel CheckMatrix(string matrixInput)
        {
            IndexViewModel output = new IndexViewModel() { MatrixNumbers = matrixInput };
            List<List<string>> matrix = MatrixInputToListOfLists(matrixInput);
            if (IsSquare(matrix) && IsIncreasing(matrix))
            {
                output.Result = "Success! Matrix is square and increasing!";
                AddMatrix(matrixInput);
            }
            if (!IsSquare(matrix))
            {
                output.Result = "Matrix is not square.";
            }
            if (!IsIncreasing(matrix))
            {
                output.Result = "Matrix is not increasing.";
            }
            else
            {
                output.Result = "Try again please";
            }
            return output;
        }

        public List<List<string>> MatrixInputToListOfLists(string matrixInput)
        {
            List<List<string>> matrixLines = new List<List<string>>();
            foreach (string line in matrixInput.Split('\n').ToList())
            {
                matrixLines.Add(line.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList());
            }
            return matrixLines;
        }

        public bool IsSquare(List<List<string>> matrixLines)
        {
            return matrixLines.All(l => l.Count == matrixLines.Count);
        }

        public bool IsIncreasing(List<List<string>> matrixLines)
        {
            return LinesIncreasing(matrixLines) && RowsIncreasing(matrixLines);
        }

        public bool LinesIncreasing(List<List<string>> matrixLines)
        {
            for (int j = 0; j < matrixLines.Count; j++)
            {
                for (int i = 1; i < matrixLines.Count; i++)
                {
                    if (! (Int32.Parse(matrixLines[j][i]) >= Int32.Parse(matrixLines[j][i-1])))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool RowsIncreasing(List<List<string>> matrixLines)
        {
            for (int j = 0; j < matrixLines.Count; j++)
            {
                for (int i = 1; i < matrixLines.Count; i++)
                {
                    if (!(Int32.Parse(matrixLines[i][j]) >= Int32.Parse(matrixLines[i - 1][j])))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public void AddMatrix(string matrixInput)
        {
            matrixRepository.AddMatrix(new Matrix(matrixInput));
        }

        public List<Matrix> GetMatrices()
        {
            return matrixRepository.GetMatrices();
        }
    }
}
