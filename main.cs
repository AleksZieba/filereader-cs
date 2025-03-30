using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "sample.txt";

        if (File.Exists(filePath))
        {
            string content = File.ReadAllText(filePath);
            Console.WriteLine(content);
        }
        else
        {
            Console.WriteLine("File not found: " + filePath);
        }

        // Wait for user input before closing the console window 
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}