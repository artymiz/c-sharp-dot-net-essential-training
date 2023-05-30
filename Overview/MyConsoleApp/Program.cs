// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("What is your name?");

string? response;
response = Console.ReadLine();

while (response == null || response == "")
{
    Console.WriteLine("Please enter your name.");
    response = Console.ReadLine();
}

Console.WriteLine($"Hello, {response}!");

OperatingSystem os = Environment.OSVersion;
Console.WriteLine(os.Platform);
Console.WriteLine(os.VersionString);
