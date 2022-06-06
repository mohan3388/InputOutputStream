using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoFile
{
    public class IoStream
    {
        string Path = @"D:\dotnet\Files\InputOutputStream\IoFile\File.txt";
        public void FileExists()
        {
            if(File.Exists(Path))
            {
                Console.WriteLine("File Exists");
            }
            Console.ReadKey();
        }
    }
}
