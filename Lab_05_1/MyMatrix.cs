using System.Data;
using System.Diagnostics;

namespace Lab_05_1;

public class MyMatrix
{
    private int[,] matrix;
    private int rows;
    private int columns;
    private Random random;

    public MyMatrix(int rows, int columns, int minVal, int maxVal)
    {
        this.rows = rows;
        this.columns = columns;
        matrix = new int[rows, columns];
        random = new Random();
        Fill(minVal, maxVal);
    }

    public void Fill(int minVal, int maxVal)
    {
        for (int i = 0; i <= rows; ++i)
        {
            for (int j = 0; j <= rows; ++j)
            {
                matrix[i, j] = random.Next(minVal, maxVal + 1);
            }
        }
    }

    public void ChangeSize(int newRows, int newColumns)
    {
        int[,] newMatrix = new int[newRows, newColumns];

        for (int i = 0; i < Math.Min(rows, newRows); i++)
        {
            for (int j = 0; j < Math.Min(columns, newColumns); j++)
            {
                newMatrix[i, j] = matrix[i, j];
            }
        }

        for (int i = rows; i < newRows; i++)
        {
            for (int j = 0; j < newColumns; j++)
            {
                newMatrix[i, j] = random.Next();
            }
        }

        for (int i = 0; i < newRows; i++)
        {
            for (int j = columns; j < newColumns; j++)
            {
                newMatrix[i, j] = random.Next();
            }
        }

        matrix = newMatrix;
        rows = newRows;
        columns = newColumns;
    }

    public void ShowPartialy(int startRow, int endRow, int startColumn, int endColumn)
    {
        for (int i = startRow; i <= endRow; i++)
        {
            for (int j = startColumn; j <= endColumn; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }

            Console.WriteLine();
        }
    }

    public void Show()
    {
        for (int i = 0; i < rows; ++i)
        {
            for (int j = 0; j < rows; ++j)
            {
                Console.WriteLine($"{matrix[i, j]} ");
            }

            Console.WriteLine();
        }
    }

    public int this[int index1, int index2]
    {
        get { return matrix[index1, index2]; }
        set { matrix[index1, index2] = value; }
    }
}