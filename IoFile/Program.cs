using IoFile;
using System;


class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Welcome to the Input Output Program");
        Console.WriteLine("1.Enter 1 File exists or not\n2.Enter 2 to Read all lines\n3.Enter 3 to read all text\n4.Enter 4 to Copy text\n5.Enter 5 to Delete\n6.Enter 6 to stream reader\n7.Enter 0 exit");
        bool check=true;
        IoStream Files = new IoStream();
        while(check)
        {
            Console.WriteLine("\nEnter Above Option");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch (Option)
            {
                case 1:
                    Files.FileExists();
                    break;
                    case 2:
                        Files.ReadAllLinens();
                    break;
                case 3:
                    Files.ReadAllText();
                    break;
                case 4:
                    Files.CopyFile();
                    break;
                case 5:
                    Files.DeleteFile();
                    break;
                case 6:
                    Files.StreamReader();
                    break;
                case 0:
                    check = false;
                    break;
                  
            }
        }
    }
}