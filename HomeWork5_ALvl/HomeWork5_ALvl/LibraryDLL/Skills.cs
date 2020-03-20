using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDLL
{
    public static class Skills
    {
        public static void CreateMatrix(int N, ref int[,] arr)
        {
            Random numRand = new Random();
            arr = new int[N, N];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    int numOfArray = numRand.Next(1, 100);
                    arr[i, j] = numOfArray;
                    //Console.Write(numOfArray + " " + (numOfArray < 10 ? " " : ""));
                }
                //Console.WriteLine();
            }
        }

        public static int[,] TransposeMatrix(int[,] array)
        {
            int[,] arrTranspose = new int[array.GetLength(0), array.GetLength(1)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    arrTranspose[i, j] = array[j, i];
                    //Console.Write(arrTranspose[i, j]+" ");
                }
            }
            return arrTranspose;
        }

        public static int[,] GetTriangularMatrixLower(int[,] array)
        {
            int[,] arrTriangular = new int[array.GetLength(0), array.GetLength(1)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j < array.GetLength(0) - i - 1)
                        arrTriangular[i, j] = array[i, j];
                    else
                        arrTriangular[i, j] = 0;
                }
            }
            return arrTriangular;
        }

        public static int[,] GetTriangularMatrixUpper(int[,] array)
        {
            int[,] arrTriangular = new int[array.GetLength(0), array.GetLength(1)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j > array.GetLength(0) - i - 1)
                        // if (j >=i)
                        arrTriangular[i, j] = array[i, j];
                    else
                        arrTriangular[i, j] = 0;
                }
            }
            return arrTriangular;
        }

        public static int[,] CreateMultDimensArr(ref int counter, int[,] array, ref int[][,] multArray)
        {
            multArray[++counter] = array;
            //int a = multArray[counter][0, 1];
            //int b = array[1, 1];
            return array;
        }

    }
}
