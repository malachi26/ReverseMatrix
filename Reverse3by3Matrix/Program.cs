﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse3by3Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = new[,]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };
            ReverseMatrix_bad(matrix);
            PrintMatrix(matrix);
            
            //PrintMatrix(ReverseMatrix(matrix));
            Console.ReadLine();

            var matrix2 = new[,]
            {
                {1,2,3,4},
                {5,6,7,8},
                {9,10,11,12},
                {13,14,15,16}
            };
            ReverseMatrix_bad(matrix2);
            PrintMatrix(matrix2);
            //PrintMatrix(ReverseMatrix(matrix2));

            Console.ReadLine();

        }
        static int[,] ReverseMatrix(int[,] inputMatrix)
        {
            var outputMatrix = new int[inputMatrix.GetLength(0), inputMatrix.GetLength(1)];
            var x = 0;
            for (int i = inputMatrix.GetLength(0) - 1; i >= 0; i--)
            {
                var y = 0;
                for (int j = inputMatrix.GetLength(1) - 1; j >= 0; j--)
                {
                    outputMatrix[x, y] = inputMatrix[i, j];
                    y++;
                }
                x++;
            }
            return outputMatrix;
        }

        static void PrintMatrix(int[,] inputMatrix)
        {
            for (int row = 0; row < inputMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < inputMatrix.GetLength(1); col++)
                {
                    var outputString = inputMatrix[row, col].ToString();
                    Console.Write(outputString.PadLeft(5));
                }
                Console.WriteLine();
            }
        }

        public int[,] CreateSqaureMatrix(int numOfRows, int maxNumber, int minNumber)
        {
            var rng = new Random();
            var outputMatrix = new int[numOfRows, numOfRows];
            for (int i = 0; i < numOfRows; i++)
            {
                for (int j = 0; j <numOfRows; j++)
                {
                    outputMatrix[i, j] = rng.Next(minNumber, maxNumber);
                }
            }
                return outputMatrix;
        }


        /// <summary>
        /// I really don't like this method
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="matrix"></param>
        static void ReverseMatrix_long_dontlike<T>(T[,] matrix)
        {
            int width = matrix.GetLength(1);
            int height = matrix.GetLength(0);
            int startRow = 0;
            int startCol = 0;
            int endRow = height - 1;
            int endCol = width - 1;

            while (true)
            {
                if (startRow > endRow) return;

                // swap
                var temp = matrix[startRow, startCol];
                matrix[startRow, startCol] = matrix[endRow, endCol];
                matrix[endRow, endCol] = temp;

                startCol++;
                endCol--;

                if (startCol == width)
                {
                    startRow++;
                    startCol = 0;
                }
                if (startCol == -1)
                {
                    startRow++;
                    startCol = width - 1;
                }
                if (endCol == -1)
                {
                    endRow--;
                    endCol = width - 1;
                }
                if (endCol == width)
                {
                    endRow--;
                    endCol = 0;
                }
            }
        }

    }
}
