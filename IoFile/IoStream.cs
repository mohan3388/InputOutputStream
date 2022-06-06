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
        string[] lines;
        public void FileExists()
        {
            if(File.Exists(Path))
            {
                Console.WriteLine("File Exists");
            }
            Console.ReadKey();
        }
        public void ReadAllLinens()
        {
            lines = File.ReadAllLines(Path);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
            Console.ReadKey();
        }
    }
}
