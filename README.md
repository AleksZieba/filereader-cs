# Text File Reader

This is an old project I made to test out C#. It is a .NET Framework CLI tool reads the contents of a text file and prints it to the console. 

## Features

- **File Reading:** Reads the entire content of a specified text file.
- **File Existence Check:** Verifies that the file exists before attempting to read it.
- **Console Output:** Displays the file content on the console.

## Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 5.0 or later recommended)
- A text editor or IDE such as [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/).

## Getting Started

### 1. Clone the Repository

Clone the repository to your local machine:

```bash
git clone https://github.com/yourusername/TextFileReader.git
cd TextFileReader 
```

### 2. Add Your Text File 

Ensure that the text file you want to read (e.g., sample.txt) is placed in the same directory as the executable or update the file path in the code accordingly. 

### 3. Build and Run 

1. Build the project: 

**Using the .NET CLI:** 

```bash
dotnet build
``` 

2. Run the project: 
```bash 
dotnet run 
``` 

**Using Visual Studio:** 

1. Open the solution file (`.sln`) in Visual Studio.

2. Build the solution. 

3. Run the project by pressing **F5** or selecting **Debug > Start Debugging**. 

## Project Structure 

```cpp
TextFileReader/
├── Program.cs        // Contains the Main method and file reading logic.
├── sample.txt        // Sample text file to read (ensure this exists).
├── TextFileReader.csproj  // Project file.
└── README.md         // This file.
``` 

## Customization 

- **File Path:** Modify the `filePath` variable in `Program.cs` if your text file is located in a different directory.
- **Error Handling:** The current implementation provides basic error handling by checking if the file exists. Consider expanding this to handle other potential errors (e.g., file access permissions).
