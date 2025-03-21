using SOLIDPrinciples.LSP;
using SOLIDPrinciples.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.DIP
{
    public class ReadFileOperation : IFileOperation
    {
        private readonly FileReader _fileReader;

        public ReadFileOperation(FileReader fileReader)
        {
            _fileReader = fileReader;
        }
        public void Execute(string filePath, string content = null)
        {
            string fileContent = _fileReader.Read(filePath);

            Console.WriteLine("File content:", fileContent);
        }
    }
}
