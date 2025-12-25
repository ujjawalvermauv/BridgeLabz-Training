using System;

class MatrixUtility
{
    // a. Create a random matrix
    public static double[,] CreateRandomMatrix(int rows, int cols)
    {
        Random rand = new Random();
        double[,] matrix = new double[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = rand.Next(1, 10);
            }
        }
        return matrix;
    }

    // b. Add two matrices
    public static double[,] Add(double[,] A, double[,] B)
    {
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        double[,] result = new double[rows, cols];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[i, j] = A[i, j] + B[i, j];
        return result;
    }

    // c. Subtract two matrices
    public static double[,] Subtract(double[,] A, double[,] B)
    {
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        double[,] result = new double[rows, cols];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[i, j] = A[i, j] - B[i, j];
        return result;
    }

    // d. Multiply two matrices
    public static double[,] Multiply(double[,] A, double[,] B)
    {
        int rA = A.GetLength(0);
        int cA = A.GetLength(1);
        int cB = B.GetLength(1);
        double[,] result = new double[rA, cB]; //

        for (int i = 0; i < rA; i++)
            for (int j = 0; j < cB; j++)
                for (int k = 0; k < cA; k++)
                    result[i, j] += A[i, k] * B[k, j]; //
        return result;
    }

    // Write a Method to find the transpose of a matrix
    public static double[,] Transpose(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[,] result = new double[cols, rows]; //
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[j, i] = matrix[i, j]; //
        return result;
    }

    // e. Determinant of 2x2 matrix
    public static double Determinant2x2(double[,] m)
    {
        return (m[0, 0] * m[1, 1]) - (m[0, 1] * m[1, 0]); //
    }

    // f. Determinant of 3x3 matrix
    public static double Determinant3x3(double[,] m)
    {
        double det = m[0, 0] * (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1]) -
                     m[0, 1] * (m[1, 0] * m[2, 2] - m[1, 2] * m[2, 0]) +
                     m[0, 2] * (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]); //
        return det;
    }

    // g. Inverse of 2x2 matrix
    public static double[,] Inverse2x2(double[,] m)
    {
        double det = Determinant2x2(m);
        if (det == 0) return null;

        double[,] inv = new double[2, 2];
        inv[0, 0] = m[1, 1] / det;
        inv[0, 1] = -m[0, 1] / det;
        inv[1, 0] = -m[1, 0] / det;
        inv[1, 1] = m[0, 0] / det;
        return inv;
    }

    // i. Display a matrix
    public static void DisplayMatrix(string label, double[,] m)
    {
        Console.WriteLine("\n" + label);
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
                Console.Write(Math.Round(m[i, j], 2) + "\t");
            Console.WriteLine();
        }
    }

    static void Main()
    {
        double[,] mat1 = CreateRandomMatrix(2, 2);
        double[,] mat2 = CreateRandomMatrix(2, 2);

        DisplayMatrix("Matrix 1", mat1);
        DisplayMatrix("Matrix 2", mat2);
        DisplayMatrix("Sum (1+2)", Add(mat1, mat2));
        DisplayMatrix("Product (1*2)", Multiply(mat1, mat2));
        DisplayMatrix("Transpose of 1", Transpose(mat1));

        double det = Determinant2x2(mat1);
        Console.WriteLine("\nDeterminant of Matrix 1: " + det);

        if (det != 0)
            DisplayMatrix("Inverse of Matrix 1", Inverse2x2(mat1));
        else
            Console.WriteLine("Inverse does not exist (Determinant is 0).");
    }
}