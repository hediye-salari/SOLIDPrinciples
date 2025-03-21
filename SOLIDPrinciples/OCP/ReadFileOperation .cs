using SOLIDPrinciples.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.OCP
{
    // Extended class for reading files
    public class ReadFileOperation : FileOperation
    {
        private readonly FileReader _fileReader;

        public ReadFileOperation(FileReader fileReader)
        {
            _fileReader = fileReader;
        }
        public override void Execute(string filePath, string content = null)
        {
            string fileContent = _fileReader.Read(filePath);
            Console.WriteLine("File content:", fileContent);
        }
    }
}
