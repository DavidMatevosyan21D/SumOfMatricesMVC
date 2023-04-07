class Program
{
    static void Main(string[] args)
    {
        var view = new MatrixView();
        var controller = new MatrixController(view);
        controller.Run();
    }
}
