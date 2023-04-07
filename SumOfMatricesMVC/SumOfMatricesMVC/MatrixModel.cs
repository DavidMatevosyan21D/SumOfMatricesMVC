public class MatrixModel
{
    public int Rows { get; set; }
    public int Cols { get; set; }
    public int[,] Data { get; set; }

    public MatrixModel(int rows, int cols)
    {
        Rows = rows;
        Cols = cols;
        Data = new int[rows, cols];
    }

    public static MatrixModel operator +(MatrixModel a, MatrixModel b)
    {
        if (a.Rows != b.Rows || a.Cols != b.Cols)
        {
            throw new ArgumentException("Матрицы должны иметь одинаковый размер.");
        }

        var result = new MatrixModel(a.Rows, a.Cols);

        for (int i = 0; i < a.Rows; i++)
        {
            for (int j = 0; j < a.Cols; j++)
            {
                result.Data[i, j] = a.Data[i, j] + b.Data[i, j];
            }
        }

        return result;
    }
}
