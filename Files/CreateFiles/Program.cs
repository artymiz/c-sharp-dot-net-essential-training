// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Creating and Deleting Files

const string filename = "TestFile.txt";

// TODO: Create a new file - this will overwrite any existing file
// Use the "using" construct to automatically close the file stream
using(StreamWriter writer = File.CreateText(filename)) {
    writer.WriteLine("This is a test of creating a file in C#");
}


// TODO: Determine if a file exists
Console.WriteLine(File.Exists(filename));
if (File.Exists(filename)) {
    File.Delete(filename);
}

