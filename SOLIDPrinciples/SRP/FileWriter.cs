using System.IO;

namespace SOLIDPrinciples.SRP
{
    // Responsible for writing files
    public class FileWriter
    {
        public void Write(string filePath, string content)
        {
            File.WriteAllText(filePath, content);
        }
    }
}