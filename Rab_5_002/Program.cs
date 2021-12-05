using System;

namespace Rab_5_002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Запросить у пользователя целочисленное значение N.
            // Сформировать двумерный массив размера NxN следующего вида:
            //  1 0 1 0 1                        
            //  0 1 0 1 0
            //  1 0 1 0 1
            //  0 1 0 1 0
            //  1 0 1 0 1

            const int n = 5;
            const int m = 5;
            int[,] a = new int [n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = 1 - (i + j) % 2;
                    Console.Write(a[i, j] + " ");
                }

                Console.WriteLine();
                
            }

        }
    }
}
