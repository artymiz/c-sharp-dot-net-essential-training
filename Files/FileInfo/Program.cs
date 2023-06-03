// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Working with file information

// Make sure the example file exists
const string filename = "TestFile.txt";

if (!File.Exists(filename)) {
    using (StreamWriter sw = File.CreateText(filename)) {
        sw.WriteLine("This is a text file.");
    }
}

// TODO: Get some information about the file
// Console.WriteLine(File.GetCreationTime(filename));
// Console.WriteLine(File.GetLastWriteTime(filename));
// Console.WriteLine(File.GetLastAccessTime(filename));
//
// File.SetAttributes(filename, FileAttributes.ReadOnly);
// Console.WriteLine(File.GetAttributes(filename));

// TODO: We can also get general information using a FileInfo
try {
    FileInfo fi = new FileInfo(filename);
    Console.WriteLine(fi.Length);
    Console.WriteLine(fi.Directory);
    Console.WriteLine($"ReadOnly: {fi.IsReadOnly}");
} catch (Exception e) {
    Console.WriteLine($"Exception: {e.Message}");
}

// TODO: File information can also be manipulated
File.SetCreationTime(filename, new DateTime(2020, 1, 1));
Console.WriteLine($"Created on: {File.GetCreationTime(filename)}");

