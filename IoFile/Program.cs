using IoFile;
using System;


class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Welcome to the Input Output Program");
        Console.WriteLine("1.Enter 1 File exists or not\n 2.Enter 2 exit");
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
                    check = false;
                    break;
                  
            }
        }
    }
}