using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Specify the path to your text file
        string filePath = "sample.txt";

        // Check if the file exists
        if (File.Exists(filePath))
        {
            // Read all text from the file
            string content = File.ReadAllText(filePath);
            // Print the content to the console
            Console.WriteLine(content);
        }
        else
        {
            // Inform the user that the file does not exist
            Console.WriteLine("File not found: " + filePath);
        }

        // Wait for user input before closing the console window (optional)
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}