using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = CreateMatrix();
            Console.WriteLine("");
            Console.WriteLine("-------------------------");
            PrintMatrix(matrix1);
            Console.WriteLine("-------------------------");
            Console.WriteLine("");
            SumOfRows(matrix1);
            Console.WriteLine();
            SumOfColumns(matrix1);
        }


        public static int[,] CreateMatrix()
        {
            Console.Write("Specify the number of rows = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Specify the number of colomns = ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            int[,] matrix = new int[n, m];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"Element of matrix [{i}] [{j}] = ");
                    int element = Convert.ToInt32(Console.ReadLine());
                    matrix[i, j] = element;
                }
            }
            return matrix;
        }


        public static void PrintMatrix(int[,] matrix)
        {
            if (matrix is null)
            {
                Console.WriteLine("Matrix is not valid, please enter a valid matrix !");
                return;
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j],6}");
                }

                Console.WriteLine();
            }
        }

        public static int SumOfRows(int[,] matrix)
        {
            if(matrix is null)
            {
                Console.WriteLine("Matrix is null !");
                return 0;
            }
            int sum = 0;
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum = sum + matrix[i, j];
                }
                Console.WriteLine($"The sum of the row {i} is {sum}");
            }
            return sum;
        }

        public static int SumOfColumns(int[,] matrix)
        {
            if (matrix is null)
            {
                Console.WriteLine("Matrix is null !");
                return 0;
            }
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                sum = 0;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    sum = sum + matrix[j, i];
                }
                Console.WriteLine($"The sum of the column {i} is {sum}");
            }
            return sum;
        }

    }
}
