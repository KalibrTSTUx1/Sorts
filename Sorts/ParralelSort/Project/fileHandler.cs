using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    static class fileHandler
    {
        static public string[] fileOpen(string filePath)
        {
            StreamReader file;
            var array = Array.Empty<string>();
            if (errorHandler(filePath) != 0) { return array; }
            
            try
            {
                file = new StreamReader(filePath);
                array = fileReader(file);
            }
            catch (Exception)
            {
                return Array.Empty<string>();
            }
           
            return array;
        }
        static public int[,] GetInfo(string[] src, out int[] directions)
        {
            List<int> dirs = new();
            int[,] res;
            foreach (string elem in src[0].Split(" "))
            {
                try
                {
                    dirs.Add(int.Parse(elem));
                } catch(Exception)
                {
                    throw new Exception("Нечисловое значение");
                }
                if (int.Parse(elem) < 0 || int.Parse(elem) > 1)
                {
                    throw new Exception("Некорректный формат");
                }
            }
            directions = dirs.ToArray();
            res = new int[src.Length - 1, dirs.ToArray().Length];
            for (int i = 1; i<src.Length; i++)
            {
                int counter = 0;
                foreach (string elem in src[i].Split(" "))
                {
                    try
                    {
                        res[i - 1, counter] = int.Parse(elem);
                    } catch (Exception)
                    {
                        throw new Exception("Нечисловое значение");
                    }
                    counter++;
                }
                if (counter != directions.Length)
                {
                    throw new Exception("Некорректный формат");
                }
            }
            return res;
        }
        static private int errorHandler(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return 2;
            }
            return 0;
        }
        static private string[] fileReader(StreamReader file)
        {
            var fileContent = new List<string>();
            string fileLine;
            while (true)
            {
                try
                {
                    string line;
                    line = file.ReadLine();
                    if (line != null)
                    {
                        fileContent.Add(line);
                        continue;
                    }
                    break;
                }
                catch (Exception)
                {
                    break;
                }
            }
            if (fileContent.Count == 0)
            {
                return null;
            }

            return convertListToArray(fileContent);
        }

        static private string[] convertListToArray(List<string> fileContent)
        {
            var lines = new string[fileContent.Count];
            for (int i = 0; i < fileContent.Count; i++)
            {
                lines[i] = fileContent[i];
            }
            return lines;
        }

        static public void fileRecorder(string filePath, int[,] result)
        {
            if (filePath == String.Empty || filePath == null)
            {
                return;
            }
            using (StreamWriter sw = File.CreateText(filePath))
            {
                for (int i = 0; i < result.GetLength(0); i++)
                {
                    for (int j = 0; j < result.GetLength(1); j++)
                    {
                        sw.Write("{0, 5}", result[i, j]);
                    }
                    sw.WriteLine();
                }
            }
        }

    }
}
