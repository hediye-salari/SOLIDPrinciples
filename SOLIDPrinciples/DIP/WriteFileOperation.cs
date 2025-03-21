using SOLIDPrinciples.LSP;
using SOLIDPrinciples.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.DIP
{
    public class WriteFileOperation : IFileOperation
    {
        private readonly FileWriter _fileWriter;
        public WriteFileOperation(FileWriter fileWriter)
        {
            _fileWriter=fileWriter;
        }
        public void Execute(string filePath, string content = null)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content), "Content cannot be null for write operation.");
            }

            _fileWriter.Write(filePath, content);
            Console.WriteLine("Content written to file.");
        }
    }
}
