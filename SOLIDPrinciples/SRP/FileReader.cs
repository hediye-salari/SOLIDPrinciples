using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.SRP
{
    // 1. Single Responsibility Principle (SRP)
    // Each class has only one responsibility.

    // Responsible for reading files
    public class FileReader
    {
        public string Read(string filePath)
        {
            return File.ReadAllText(filePath);
        }
    }

}
