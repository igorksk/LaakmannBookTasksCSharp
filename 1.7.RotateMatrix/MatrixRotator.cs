namespace _1._7.RotateMatrix
{
    internal class MatrixRotator
    {
        public static int[,] RotateMatrix(int[,] matrix)
        {
            if (matrix == null || matrix.GetLength(0) != matrix.GetLength(1))
            {
                throw new ArgumentException("Input must be a square matrix.");
            }
            int n = matrix.GetLength(0);
            int[,] rotatedMatrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    rotatedMatrix[j, n - 1 - i] = matrix[i, j];
                }
            }
            return rotatedMatrix;
        }
    }
}
