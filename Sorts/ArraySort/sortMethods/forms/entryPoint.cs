using sortMethods;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Обработать ошибки
*/





namespace forms
{
    internal class entryPoint
    {
        private string lineManual; // Строка, заданная пользователем
        private string[] arrayManual; // Массив, заданный вручную
        private int[] arrRnd; //Массив, заполненный случайно
        private string delimiter; // Разделитель
        private string filePath; // Путь к файлу
        private string direct; // Направление сортировки
        private string metSort; // Метод сортировки
        private long timeOfSort;
        private bool sortCorrection;
        formResult formRes;

        private string lineResult;
        Stopwatch timer = new Stopwatch();
        public entryPoint(int[] arr, string direct, string metSort)
        {
            arrRnd = arr;
            this.direct = direct;
            this.metSort = metSort;
            mainRnd();
        }
        /// <summary>
        /// Конструктор класса, экземпляр которого, сортирует массив, заданный вручную
        /// </summary>
        /// <param name="arrayManual">Массив</param>
        /// <param name="delimiter">Разделитель</param>
        /// <param name="direct">Направление</param>
        /// <param name="metSort">Метод соритровки</param>
        public entryPoint(string lineManual, string delimiter, string direct, string metSort)
        {
            this.lineManual = lineManual;
            this.delimiter = delimiter;
            this.direct = direct;
            this.metSort = metSort;
            mainManual();
        }
        /// <summary>
        /// Конструктор класса, экземпляр которого, сортирует массив, заданный из файла
        /// </summary>
        /// <param name="filePath">Ссылка на файл</param>
        /// <param name="direct">Направление</param>
        /// <param name="metSort">Метод сортировки</param>
        public entryPoint(string filePath, string direct, string metSort)
        {
            this.filePath = filePath;
            this.direct = direct;
            this.metSort = metSort;
            mainFile();
        }
        private void CheckSortCorrection(double[] arr, int direction)
        {
            sortCorrection = SortMethods.IsSortedCorrect(arr, direction);
        }
        private void CheckSortCorrection(int[] arr, int direction)
        {
            sortCorrection = SortMethods.IsSortedCorrect(arr, direction);
        }
        /// <summary>
        /// Метод для сортировки массива из файла.
        /// </summary>
        /// <param name="dirSort">Направление сортировки</param>
        /// <param name="metSort">Метод сортировки</param>
        /// <returns></returns>
        private double[] sortFile(int dirSort, int metSort)
        {
            var array = new double[] { };
            array = fileHandler.fileOpen(filePath);
            Stopwatch S = new();
            S.Start();
            switch (metSort)
            {
                case 1:
                    SortMethods.FastSort(array, dirSort);
                    break;
                case 2:
                    SortMethods.MergeSort(array, 0, array.Length - 1, dirSort);
                    break;
                case 3:
                    SortMethods.HeapSort(array, array.Length, dirSort);
                    break;
                case 4:
                    SortMethods.BubbleSort(array, dirSort);
                    break;
                case 5:
                    SortMethods.InsertSort(array, dirSort);
                    break;
                case 6:
                    SortMethods.CountSort(array, dirSort);
                    break;

                case 7:
                    SortMethods.BogoSort(array, dirSort);
                    break;
                default:
                    break; 

            }
            S.Stop();
            timeOfSort = S.ElapsedMilliseconds;
            CheckSortCorrection(array, dirSort);
            return array;
        }
        /// <summary>
        /// Метод для сортировки массива, заданный вручную.
        /// </summary>
        /// <param name="dirSort">Направление</param>
        /// <param name="metSort">Метод сортировки</param>
        /// <returns></returns>
        private double[] sortManual(int dirSort, int metSort)
        {
            var array = Array.Empty<double>();
            if (delimiter == String.Empty)
            {
                delimiter = " ";
            }
            arrayManual = lineManual.Split(delimiter);
            array = arrayDblConvert(arrayManual);
            Stopwatch S = new();
            S.Start();
            switch (metSort)
            {
                case 1:
                    SortMethods.FastSort(array, dirSort);
                    break;
                case 2:
                    SortMethods.MergeSort(array, 0, array.Length - 1, dirSort);
                    break;
                case 3:
                    SortMethods.HeapSort(array, array.Length, dirSort);
                    break;
                case 4:
                    SortMethods.BubbleSort(array, dirSort);
                    break;
                case 5:
                    SortMethods.InsertSort(array, dirSort);
                    break;
                case 6:
                    SortMethods.CountSort(array, dirSort);
                    break;
                case 7:
                    SortMethods.BogoSort(array, dirSort);
                    break;
                default:
                    break;

            }
            S.Stop();
            timeOfSort = S.ElapsedMilliseconds;
            CheckSortCorrection(array, dirSort);
            return array;
        }
        

        private int[] sortRnd(int dirSort, int metSort)
        {
            Stopwatch S = new();
            S.Start();
            switch (metSort)
            {
                case 1:
                    SortMethods.FastSort(arrRnd, dirSort);
                    break;
                case 2:
                    SortMethods.MergeSort(arrRnd, 0, arrRnd.Length - 1, dirSort);
                    break;
                case 3:
                    SortMethods.HeapSort(arrRnd, arrRnd.Length, dirSort);
                    break;
                case 4:
                    SortMethods.BubbleSort(arrRnd, dirSort);
                    break;
                case 5:
                    SortMethods.InsertSort(arrRnd, dirSort);
                    break;
                case 6:
                    SortMethods.CountSort(arrRnd, dirSort);
                    break;
                case 7:
                    SortMethods.BogoSort(arrRnd, dirSort);
                    break;
                default:
                    break;

            }
            S.Stop();
            timeOfSort = S.ElapsedMilliseconds;
            CheckSortCorrection(arrRnd, dirSort);
            return arrRnd;
        }
        /// <summary>
        /// Метод определения направления сортировки.
        /// </summary>
        /// <returns></returns>
        private int directDet()
        {
            if (direct[0]  == '1')
            {
                return 1;
            } else { return 0; }
        }
        /// <summary>
        /// Метод определения метода сортировки.
        /// </summary>
        /// <returns></returns>
        private int metSortDet()
        {
            switch (metSort[0])
            {
                case '1':
                    return 1;
                case '2':
                    return 2;
                case '3':
                    return 3;
                case '4':
                    return 4;
                case '5':
                    return 5;
                case '6':
                    return 6;
                case '7':
                    return 7;
                default:
                    return 0;
            }
        }
        /// <summary>
        /// Метод конвертации элементов массива в целочисленные значения
        /// </summary>
        /// <param name="arr">Массив</param>
        /// <returns></returns>
        private int[] arrayIntConvert(string[] arr)
        {
            var array = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                array[i] = int.Parse(arr[i]);
            return array;
        }

        private double[] arrayDblConvert(string[] arr)
        {
            var array = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                array[i] = double.Parse(arr[i]);
            return array;
        }

        /// <summary>
        /// Основной метод, вызывающий метод сортировки массива из файла.
        /// </summary>
        /// <returns></returns>
        private void mainFile()
        {
            int dirSort = directDet();
            int metSort = metSortDet();
            lineResult = SortMethods.ArrToStr(sortFile(dirSort, metSort));
            formRes = new formResult(lineResult, timeOfSort, sortCorrection);
            formRes.Show();
        }
        /// <summary>
        /// Основной метод, вызывающий метод сортировки массива, заданного вручную.
        /// </summary>
        /// <returns></returns>
        private void mainManual()
        {
            int dirSort = directDet();
            int metSort = metSortDet();
            lineResult = SortMethods.ArrToStr(sortManual(dirSort, metSort));
            formRes = new formResult(lineResult, timeOfSort, sortCorrection);
            formRes.Show();
        }

        private void mainRnd()
        {
            int dirSort = directDet();
            int metSort = metSortDet();
            lineResult = SortMethods.ArrToStr(sortRnd(dirSort, metSort));
            formRes = new formResult(lineResult, timeOfSort, sortCorrection);
            formRes.Show();
        }
    }
}
