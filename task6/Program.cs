// See https://aka.ms/new-console-template for more information
using System;
class A
{
    static void Main()
    {
        int N = 3; // Number of rows
        int M = 3; // Number of columns

        int[,] matrix = new int[N, M];
        Random random = new Random();

        for (int num = 1; num <= N * M; num++)
        {
            int row, col;

            do
            {
                row = random.Next(N);
                col = random.Next(M);
            } while (matrix[row, col] != 0);

            matrix[row, col] = num;
        }

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
