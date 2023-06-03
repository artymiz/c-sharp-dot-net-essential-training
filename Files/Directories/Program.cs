// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Creating and Deleting Directories

const string dirname = "TestDir";

// TODO: Create a Directory if it doesn't already exist
// if (!Directory.Exists(dirname)) {
//     Directory.CreateDirectory(dirname);
//     Console.WriteLine("Created directory {0}", dirname);
// } else {
//     Directory.Delete(dirname);
//     Console.WriteLine("Directory {0} already exists, deleting...", dirname);
// }

// TODO: Get the path for the current directory
string currentDir = Directory.GetCurrentDirectory();
Console.WriteLine($"Current directory is {currentDir}");

// TODO: Just like with files, you can retrieve info about a directory
// DirectoryInfo dirInfo = new DirectoryInfo(currentDir);
// Console.WriteLine($"Directory name is {dirInfo.Name}");
// Console.WriteLine($"Directory parent is {dirInfo.Parent}");
// Console.WriteLine($"Directory is created at {dirInfo.CreationTime}");

// TODO: Enumerate the contents of directories
Console.WriteLine("Just directories:");
List<string> dirs = new List<string>(Directory.EnumerateDirectories(currentDir));
foreach (var dir in dirs) {
    Console.WriteLine(dir);
}

Console.WriteLine("---------------");

Console.WriteLine("Just files:");
List<string> files = new List<string>(Directory.EnumerateFiles(currentDir));
foreach (var file in files) {
    Console.WriteLine(file);
}

Console.WriteLine("---------------");

Console.WriteLine("All directory contents:");
List<string> all = new List<string>(Directory.EnumerateFileSystemEntries(currentDir));
foreach (var entry in all) {
    Console.WriteLine(entry);
}
