using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string[] allFiles = Directory.GetFiles("C:\\");

        string exampleDir = @"D:\Example_36tp";
        Directory.CreateDirectory(exampleDir);

        string sourceDir = @"C:\SourceDirectory";
        string[] filesToCopy = Directory.GetFiles(sourceDir);

        foreach (string file in filesToCopy)
        {
            string fileName = Path.GetFileName(file);
            string destFile = Path.Combine(exampleDir, fileName);
            File.Copy(file, destFile, true);
        }

        foreach (string file in filesToCopy)
        {
            string fileName = Path.GetFileName(file);
            string destFile = Path.Combine(exampleDir, fileName);

            File.SetAttributes(destFile, FileAttributes.Hidden);
            string linkFilePath = Path.Combine(exampleDir, "Link_" + fileName);
            CreateSymbolicLink(linkFilePath, destFile, SymbolicLink.File);
        }

        Console.WriteLine("Операции завершены успешно.");
        Console.ReadLine();
    }

    [System.Runtime.InteropServices.DllImport("kernel32.dll")]
    public static extern bool CreateSymbolicLink(string lpSymlinkFileName, string lpTargetFileName, SymbolicLink dwFlags);

    public enum SymbolicLink
    {
        File = 0,
        Directory = 1
    }
}
