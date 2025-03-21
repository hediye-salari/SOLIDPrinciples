using SOLIDPrinciples.LSP;
using SOLIDPrinciples.OCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.DIP
{
    // Dependency Inversion Principle (DIP)
    // High-level modules should not depend on low-level modules. Both should depend on abstractions.
    public class FileManager
    {
        private readonly IFileOperation _fileOperation;
        public FileManager(IFileOperation fileOperation) 
        {
            _fileOperation= fileOperation;
        } 
        public void PerformOperation(string filePath, string content = null)
        {
            _fileOperation.Execute(filePath, content);  
        }
    }
}
