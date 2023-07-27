using System;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("dang thuc hien");
        string python2Code = File.ReadAllText("tool.py");
        string python3Code = ConvertPython2ToPython3(python2Code);
        File.WriteAllText("tool1.py", python3Code);

        Console.WriteLine("Conversion successful! Python 3 code saved to output_file.py");
        Console.WriteLine("xong");
        Console.ReadKey();  
    }

    static string ConvertPython2ToPython3(string python2Code)
    {
        // Setup the process start info
        ProcessStartInfo psi = new ProcessStartInfo
        {
            FileName = "python",
            RedirectStandardInput = true,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        // Start the process
        Process process = new Process();
        process.StartInfo = psi;
        process.Start();

        // Write the Python 2 code to the process
        process.StandardInput.WriteLine("import lib2to3");
        process.StandardInput.WriteLine("from lib2to3.refactor import RefactoringTool, get_fixers_from_package");
        process.StandardInput.WriteLine("refactoring_tool = RefactoringTool(get_fixers_from_package('lib2to3.fixes'))");
        process.StandardInput.WriteLine("python2_code = '''");
        process.StandardInput.WriteLine(python2Code);
        process.StandardInput.WriteLine("'''");
        process.StandardInput.WriteLine("python3_tree = refactoring_tool.refactor_string(python2_code, 'input.py')");
        process.StandardInput.WriteLine("print(python3_tree)"); // Output Python 3 code

        // Read the Python 3 code from the process
        string python3Code = process.StandardOutput.ReadToEnd();

        // Check for any errors
        string errors = process.StandardError.ReadToEnd();
        if (!string.IsNullOrEmpty(errors))
        {
            Console.WriteLine("Conversion Error:");
            Console.WriteLine(errors);
        }

        // Close the process
        process.Close();

        return python3Code;
    }
}
