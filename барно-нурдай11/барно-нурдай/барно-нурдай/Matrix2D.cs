using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Matrix2D
{
    private int[,] matrix;
    private int rows;
    private int cols;

    public Matrix2D(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;
        matrix = new int[rows, cols];
    }

    public void FillRandom(int minValue = 0, int maxValue = 100)
    {
        Random rnd = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = rnd.Next(minValue, maxValue);
            }
        }
    }

    public void DisplayInDataGridView(DataGridView dgv)
    {
        dgv.ColumnCount = cols;
        dgv.RowCount = rows;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                dgv.Rows[i].Cells[j].Value = matrix[i, j];
            }
        }
    }

    public int GetPositiveSum()
    {
        int sum = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] > 0)
                {
                    sum += matrix[i, j];
                }
            }
        }
        return sum;
    }
    public int GetPositiveMax()
    {
        int max = int.MinValue;
        bool found = false;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] > 0)
                {
                    if (!found || matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        found = true;
                    }
                }
            }
        }

        return found ? max : 0;
    }

    public int GetOtrizMin()
    {
        int min = int.MaxValue;
        bool found = false;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] < 0)
                {
                    if (!found || matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                        found = true;
                    }
                }
            }
        }

        return found ? min : 0;
    }

public int[,] GetPositiveMatrix()
    {
        var positiveList = new List<int[]>();

        for (int i = 0; i < rows; i++)
        {
            List<int> row = new List<int>();
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] > 0)
                {
                    row.Add(matrix[i, j]);
                }
            }
            if (row.Count > 0)
                positiveList.Add(row.ToArray());
        }

        return ConvertListTo2DArray(positiveList);
    }

    public int[,] GetNegativeMatrix()
    {
        var negativeList = new List<int[]>();

        for (int i = 0; i < rows; i++)
        {
            List<int> row = new List<int>();
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] < 0)
                {
                    row.Add(matrix[i, j]);
                }
            }
            if (row.Count > 0)
                negativeList.Add(row.ToArray());
        }

        return ConvertListTo2DArray(negativeList);
    }

    private int[,] ConvertListTo2DArray(List<int[]> list)
    {
        if (list.Count == 0)
            return new int[0, 0];

        int rowCount = list.Count;
        int colCount = list.Max(r => r.Length);
        int[,] result = new int[rowCount, colCount];

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < list[i].Length; j++)
            {
                result[i, j] = list[i][j];
            }
        }

        return result;
    }

    public static void DisplayMatrixInDataGridView(int[,] matrix, DataGridView dgv)
    {
      

        if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
            return;

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        dgv.ColumnCount = cols;
        dgv.RowCount = rows;
        dgv.Rows.Clear();
        dgv.Columns.Clear();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                dgv.Rows[i].Cells[j].Value = matrix[i, j];
            }
            
        }
    }
}