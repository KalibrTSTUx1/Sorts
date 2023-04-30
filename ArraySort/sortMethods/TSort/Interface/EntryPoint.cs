using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSortLib;

namespace Interface
{
    internal class EntryPoint
    {
        private Graph grph;
        private long TimeSort;
        /// <summary>
        /// Конструктор класса, создающий его экземпляр на основе массива строк
        /// </summary>
        /// <param name="fileInfo">мМассив строк, содержащий всю информацию о файле</param>
        public EntryPoint(string[] fileInfo)
        {
            grph = new Graph(
                ConvertToCorrectFormat(fileInfo)
                );
        }
        /// <summary>
        /// Функция, конвертирующая массив строк со всей информацией о файле в
        /// двумерный массив элементов
        /// </summary>
        /// <param name="strs">Конвертируемый массив строк</param>
        /// <returns>Двумерный целочиселнный массив - матрица смежности графа</returns>

        private int[,] ConvertToCorrectFormat(string[] strs)
        {
            int[,] res = new int[strs.GetLength(0), strs.GetLength(0)];

            for (int i = 0; i<strs.GetLength(0); i++)
            {
                for (int j = 0; j < strs[i].Split(" ").Length; j ++)
                {
                    res[i,j] = int.Parse(strs[i].Split(" ")[j]);
                }
            }

            return res;
        }
        /// <summary>
        /// Фунция, конвертирующая массив чисел в строку для вывода, где вершины заменены буквами
        /// </summary>
        /// <param name="vertexes">Массив чисел - номеров вершин</param>
        /// <returns>Выводимая строка</returns>

        private string[] ConvertToStr(int[] vertexes)
        {
            if (vertexes == null)
                return null;
            char[] resC = new char[vertexes.Length];

            for (int i = 0; i<vertexes.Length; i++)
            {
                resC[vertexes[i] - 1] = (Convert.ToChar('A' + i));
            }

            string[] res = new string[1];
            foreach (char i in resC)
            {
                res[0] += i + " ";
            }

            return res;
        }
        /// <summary>
        /// Итоговая функция, вычисляющая время сортировки, а также сортирующая данный граф
        /// </summary>
        /// <returns></returns>
        public string[] ReturnRes()
        {
            Stopwatch S = new();

            S.Start();
            
            int[] sorted = grph.getSortedGraph();
            S.Stop();
            TimeSort = S.ElapsedMilliseconds;

            return ConvertToStr(sorted);
        }
        /// <summary>
        /// Геттер, возврающий время сортировки в миллисекундах
        /// </summary>
        /// <returns>Время сортировки в миллисекундах в формате long</returns>
        public long getTime()
        {
            return this.TimeSort;
        }
    }
}
