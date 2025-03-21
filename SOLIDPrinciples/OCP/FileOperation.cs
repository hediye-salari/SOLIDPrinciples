using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.OCP
{
    // 2. Open/Closed Principle (OCP)
    // The system is open for extension but closed for modification.

    // Base class for file operations
    public abstract class FileOperation
    {
        public abstract void Execute(string filePath, string content=null);       

    }
}
