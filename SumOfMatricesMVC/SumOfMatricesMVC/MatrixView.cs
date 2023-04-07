public class MatrixView
{
    public void DisplayMatrix(MatrixModel matrix)
    {
        Console.WriteLine("Матрица:");
        for (int i = 0; i < matrix.Rows; i++)
        {
            for (int j = 0; j < matrix.Cols; j++)
            {
                Console.Write("{0,5}", matrix.Data[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public MatrixModel ReadMatrix()
    {
        Console.Write("Введите количество строк: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов: ");
        int cols = int.Parse(Console.ReadLine());

        var matrix = new MatrixModel(rows, cols);

        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine("Введите строку {0}:", i + 1);
            for (int j = 0; j < cols; j++)
            {
                matrix.Data[i, j] = int.Parse(Console.ReadLine());
            }
        }

        return matrix;
    }
}
