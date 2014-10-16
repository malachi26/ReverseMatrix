using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MatrixTools
{
    public class Matrix
    {
        static int[,] ReverseMatrix(int[,] inputMatrix)
        {
            var outputMatrix = new int[inputMatrix.GetLength(0), inputMatrix.GetLength(1)];

            for (int i = inputMatrix.GetLength(0) - 1, x = 0; i >= 0; i--, x++)
            {
                for (int j = inputMatrix.GetLength(1) - 1, y = 0; j >= 0; j--, y++)
                {
                    outputMatrix[x, y] = inputMatrix[i, j];
                }
            }
            return outputMatrix;
        }

        static override string ToString<int>(int[,] inputMatrix, int padLeft = 5)
        {
            var outputString = "";
            for (int row = 0; row < inputMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < inputMatrix.GetLength(1); col++)
                {
                    outputString += (inputMatrix[row, col].ToString()).PadLeft(5);
                    //Console.Write(outputString.PadLeft(5));
                }
                outputString += Environment.NewLine;
                //Console.WriteLine();
            }
            return outputString;
        }

        /// <summary>
        /// Creates a Square Matrix with Random Numbers inside the given range
        /// </summary>
        /// <param name="numOfRows">Number of Rows and Columns</param>
        /// <param name="maxNumber">Maximum Number to be returned in the Matrix</param>
        /// <param name="minNumber">Minimum Number to be returned in the Matrix</param>
        /// <returns>A Square Matrix</returns>
        static int[,] CreateSqaureMatrix(int numOfRows, int maxNumber = 100, int minNumber = 0)
        {
            var rng = new Random();
            var outputMatrix = new int[numOfRows, numOfRows];
            for (int i = 0; i < numOfRows; i++)
            {
                for (int j = 0; j < numOfRows; j++)
                {
                    outputMatrix[i, j] = rng.Next(minNumber, maxNumber);
                }
            }
            return outputMatrix;
        }
    }
}
