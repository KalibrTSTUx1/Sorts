using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    /// <summary>
    /// Класс, позволяющий взаимодействовать с файлам
    /// </summary>
    internal class fileHand
    {
        /// <summary>
        /// Фунция, читающая содержимое файла по данному пути
        /// </summary>
        /// <param name="path">Путь к файлу в виде строки</param>
        /// <returns>Содержимое файла в виде массива строк файла</returns>
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
        /// <summary>
        /// Функция, записывающая данные в файл по заданному пути
        /// </summary>
        /// <param name="path">Путь к файлу, в который записывается информация</param>
        /// <param name="text">Информация, записываемая в файл, в виде массива строк</param>
        public static void WriteFile(string path, string[] text)
        { 
            StreamWriter F = new StreamWriter(File.OpenWrite(path));
            foreach (string line in text)
            {
                F.WriteLine(line);
            }
            F.Close();
        }
        /// <summary>
        /// Функция, проверяющая содержимое файла на соответствие необходимому формату
        /// </summary>
        /// <param name="fileInfo">Содержимое файла в виде массива строк</param>
        /// <returns>True, если содержимое файла корректно, иначе false</returns>

        public static bool IsCorrectFormated(string[] fileInfo)
        {
        //формат - пусть в файле N строк.
        //Тогда в каждой строке, после разделения по пробелу, должно быть N
        //элементов - целых чисел. Любое нарушение будет отступлением от формата.
            for (int i = 0; i < fileInfo.GetLength(0); i++)
            {
                try
                {
                    if (fileInfo.GetLength(0) != fileInfo[i].Split(" ").Length)
                        return false;

                    for (int j = 0; j < fileInfo[i].Split(" ").Length; j++)
                    {
                        Convert.ToInt32(fileInfo[i].Split(" ")[j]);
                    }
                } catch (Exception)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
