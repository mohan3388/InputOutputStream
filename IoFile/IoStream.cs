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
        
        string file = @"D:\dotnet\Files\InputOutputStream\IoFile\Filecopys.txt";
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
        public void ReadAllText()
        {
            string line = File.ReadAllText(Path);
            Console.WriteLine(line);
            Console.ReadKey();
        }
        public void CopyFile()
        {
          
            File.Copy(Path, file);
            Console.ReadKey();
        }
        public void DeleteFile()
        {
            File.Delete(Path);

            Console.ReadKey();
        }
        public void StreamReader()
        {
            using (StreamReader sr = new StreamReader(file))
            {
                String s = " ";
                while((s=sr.ReadLine())!=null)
                {
                    Console.WriteLine(s);
                }
                Console.ReadKey();
            }

        }
    }
}
