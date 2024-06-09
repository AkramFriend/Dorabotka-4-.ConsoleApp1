using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorabotka_4._1_.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Напишите количество строк для матриц: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Напишите количество столбцов для матриц: ");
            int col = int.Parse(Console.ReadLine());
            int[,] matrixA = new int[row, col];
            int[,] matrixB = new int[row, col];
            int[,] matrixC = new int[row, col];
            Random r = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrixA[i, j] = r.Next(10);
                    Console.Write($"{matrixA[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrixB[i, j] = r.Next(10);
                    Console.Write($"{matrixB[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrixC[i, j] = matrixA[i, j] + matrixB[i, j];
                    Console.Write($"{matrixC[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
