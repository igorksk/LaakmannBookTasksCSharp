namespace _1._7.RotateMatrix
{
    internal class Program
    {
        static void Main()
        {
            int[,] matrix = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            Console.WriteLine("Original matrix:");
            PrintMatrix(matrix);

            int[,] rotated = MatrixRotator.RotateMatrix(matrix);

            Console.WriteLine("\nRotated matrix:");
            PrintMatrix(rotated);
        }

        static void PrintMatrix(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
