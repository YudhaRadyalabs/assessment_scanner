using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment_scanner.Commands
{
    public static class ChangeDirectories
    {
        public static string CurrentPath { get; set; }
        
        public static void ChangeDirectory(string path)
        {
            if (path == "..")
            {
                CurrentPath = Path.GetPathRoot(Environment.SystemDirectory);
            }
            else
            {
                CurrentPath = string.IsNullOrEmpty(CurrentPath) ? Path.GetPathRoot(Environment.SystemDirectory) : CurrentPath;

                if (Directory.Exists(Path.Combine(CurrentPath, path)))
                {
                    CurrentPath = Path.Combine(CurrentPath, path);
                }
                else
                {
                    Console.WriteLine("path not found");
                }
            }
        }
    }
}
