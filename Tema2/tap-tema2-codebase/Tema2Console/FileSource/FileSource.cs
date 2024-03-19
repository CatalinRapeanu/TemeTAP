namespace Tema2Console.FileSource;

public class FileSource : IFileSource
{
    public string GetOrderSource()
    {
        return File.ReadAllText("orders.json");
    }
}