namespace _1._8.SetZeros
{
    internal class MatrixZeroSetter
    {
        public static void SetZeros(int[,] matrix)
        {
            if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
            {
                return; // Return if the matrix is null or empty
            }
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            bool[] zeroRows = new bool[rows];
            bool[] zeroCols = new bool[cols];
            // First pass: identify rows and columns that need to be zeroed
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        zeroRows[i] = true;
                        zeroCols[j] = true;
                    }
                }
            }
            // Second pass: set identified rows and columns to zero
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (zeroRows[i] || zeroCols[j])
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
        }
    }
}
