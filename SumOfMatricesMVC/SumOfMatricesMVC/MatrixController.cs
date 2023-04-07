public class MatrixController
{
    private MatrixView _view;

    public MatrixController(MatrixView view)
    {
        _view = view;
    }

    public void Run()
    {
        var matrix1 = _view.ReadMatrix();
        var matrix2 = _view.ReadMatrix();

        try
        {
            var result = matrix1 + matrix2;
            _view.DisplayMatrix(result);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Ошибка: {0}", ex.Message);
        }
    }
}
