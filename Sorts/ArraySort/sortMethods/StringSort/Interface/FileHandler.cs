using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class fileHand
    {
        public static string[] ReadFile(string path)
        {
            StreamReader F = new StreamReader(path);
            List<string> fileInfo = new();

            while (!F.EndOfStream)
            {
                fileInfo.Add(F.ReadLine());
            }
            F.Close();
            return fileInfo.ToArray();
        }
        public static void WriteFile(string path, string[] text)
        {
            StreamWriter F = new StreamWriter(path);
            foreach (string line in text)
            {
                F.Write(line);
            }
            F.Close();
        }

        public static bool IsCorrectFormated(string[] fileInfo)
        {
            return true;
        }
    }
}
