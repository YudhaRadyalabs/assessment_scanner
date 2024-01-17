// See https://aka.ms/new-console-template for more information
using assessment_scanner.Commands;
using System.Runtime.CompilerServices;

string command = "";
List<string> commandDetail = new List<string>();

Console.WriteLine("Assessmemnt Scanner");

while (command != "exit")
{
    Console.WriteLine();
    Console.Write((string.IsNullOrEmpty(ChangeDirectories.CurrentPath) ? Path.GetPathRoot(Environment.SystemDirectory) : ChangeDirectories.CurrentPath) + " >> ");
    command = Console.ReadLine();
    commandDetail = command.Split(' ').ToList();

    if (commandDetail[0] == "cd")
    {
        ChangeDirectories.ChangeDirectory(commandDetail[1]);
    }
    else if (commandDetail[0] == "exit")
    { 
        
    }
    else
    {
        Console.WriteLine("Command not found");
    }
}