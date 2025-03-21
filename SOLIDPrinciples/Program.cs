using SOLIDPrinciples.DIP;
using SOLIDPrinciples.OCP;
using SOLIDPrinciples.SRP;
using SOLIDPrinciples.OCP;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "example.txt";
        string content = "Hello, SOLID Principles!";

        // Create instances of low-level modules
        var fileReader = new FileReader();
        var fileWriter = new FileWriter();

        // Use high-level module with abstraction
        var readOperation = new SOLIDPrinciples.DIP.ReadFileOperation(fileReader);
        var writeOperation = new SOLIDPrinciples.DIP.WriteFileOperation(fileWriter);

        var fileManager = new FileManager(writeOperation);
        fileManager.PerformOperation(filePath, content);

        fileManager = new FileManager(readOperation);
        fileManager.PerformOperation(filePath);
    }
}
