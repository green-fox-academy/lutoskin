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
            if (IsSquare(CreateListList(matrixInput)) && IsIncreasing(CreateListList(matrixInput)))
            {
                output.Result = "Success! Matrix is square and increasing!";
                AddMatrix(matrixInput);
            }
            else
            {
                output.Result = "No";
            }
            return output;
        }

        public List<List<string>> CreateListList(string matrixInput)
        {
            List<List<string>> lineslines = new List<List<string>>();
            foreach (string line in matrixInput.Split('\n').ToList())
            {
                lineslines.Add(line.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList());
            }
            return lineslines;
        }

        public bool IsSquare(List<List<string>> lineslines)
        {
            return lineslines.All(l => l.Count == lineslines.Count);
        }

        public bool IsIncreasing(List<List<string>> lineslines)
        {
            return LinesIncreasing(lineslines) && RowsIncreasing(lineslines);
        }

        public bool LinesIncreasing(List<List<string>> lineslines)
        {
            for (int j = 0; j < lineslines.Count; j++)
            {
                for (int i = 1; i < lineslines.Count; i++)
                {
                    if (! (Int32.Parse(lineslines[j][i]) >= Int32.Parse(lineslines[j][i-1])))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool RowsIncreasing(List<List<string>> lineslines)
        {
            for (int j = 0; j < lineslines.Count; j++)
            {
                for (int i = 1; i < lineslines.Count; i++)
                {
                    if (!(Int32.Parse(lineslines[i][j]) >= Int32.Parse(lineslines[i - 1][j])))
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
