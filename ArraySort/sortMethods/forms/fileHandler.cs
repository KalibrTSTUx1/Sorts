using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms
{
    /// <summary>
    /// Модуль, функции которого, служат для обработки файла
    /// </summary>
    static internal class fileHandler
    {
        static public double[] fileOpen(string filePath)
        {
            StreamReader file;
            var array = Array.Empty<double>();
            try
            {
                file = new StreamReader(filePath);
                array = fileReader(file, array);
            }
            catch (Exception)
            {
                return Array.Empty<double>();
            }
            
            return array;
        }

        static public void fileChange(string filePath, string lineRes)
        {
            fileRecorder(filePath, lineRes);
        }
        static private void fileRecorder(string dirFile, string lineResult)
        {
            using(StreamWriter sw = File.CreateText(dirFile))
            {
                string[] buf = lineResult.Split(" ");
                try
                {
                    int inx = 0;
                    while (true)
                    {
                        sw.WriteLine(buf[inx]);
                        inx += 1;
                    }
                  
                }
                catch (Exception)
                {
                }
            }
        }
        static public void fileGeneration(string filePath, string fileName, string lineRes)
        {
            const string EXT = ".txt";
            string path = $"{filePath}/{fileName}{EXT}";
            fileChange(path, lineRes);
            
        }


        static private double[] fileReader(StreamReader file, double[] array)
        {
            List<double> inpArray = new List<double>();
            while (true)
            {
                string line = file.ReadLine();
                if (line == null)
                {
                    return inpArray.ToArray();
                }
                else
                {
                    try
                    {
                        inpArray.Add(double.Parse(line));
                    }
                    catch (Exception)
                    {
                        return array;
                    }
                }
            }
        }
    }
}
