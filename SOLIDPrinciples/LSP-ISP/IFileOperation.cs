using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.LSP
{
    public interface IFileOperation
    {
        // 3. Liskov Substitution Principle (LSP)
        // 4. Interface Segregation Principle (ISP)
        void Execute(string filePath, string content = null);
    }
}
