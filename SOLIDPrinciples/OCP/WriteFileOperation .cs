using SOLIDPrinciples.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.OCP
{
    public class WriteFileOperation : FileOperation
    {
        private readonly FileWriter _fileWriter;
        public WriteFileOperation(FileWriter fileWriter)
        {
            _fileWriter=fileWriter;
        }

        public override void Execute(string filePath, string content = null)
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
