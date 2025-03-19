using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    // Concrete Strategy B
    // The following ZipCompression Concrete Strategy implement the Strategy Interface and 
    // Implement the CompressFolder Method. 
    public class ZipCompression : ICompression
    {
        public void CompressFolder(string compressedArchiveFileName)
        {
            Console.WriteLine("Folder is compressed using zip approach: '" + compressedArchiveFileName
                 + ".zip' file is created");
        }
    }
}
