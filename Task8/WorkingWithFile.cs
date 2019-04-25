using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Task8
{
    class WorkingWithFile
    {
        public static void ShowAllFilesInDirectory(string pathOfFile)
        {
            List<string> filesName = Directory.GetFiles(pathOfFile).ToList();
            Console.WriteLine("Files in directory:");
            foreach (string file in filesName)
            {
                Console.WriteLine(file);
            }
        }

        public static void ShowFileContent(string pathOfFile, string nameOfFile)
        {
            using (StreamReader streamReader = new StreamReader(pathOfFile + nameOfFile))
            {
                string line;
                do
                {
                    line = streamReader.ReadLine();
                    Console.WriteLine(line);
                }
                while (line != null) ;
            }
        }
    }
}
