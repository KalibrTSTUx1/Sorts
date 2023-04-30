using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSortClassLib;

namespace Project
{
    internal class entryPoint
    {
        private string filePathInp;
        private string filePathOut;
        private string[] fileContent;
        private int[] directions;
        private int[,] arr;
        public double time;
        public entryPoint(string filePathInp, string filePathOut )
        {
            this.filePathInp = filePathInp;
            this.filePathOut = filePathOut;
        }
        public entryPoint(int[,] arr, int[] directions, string filePathOut)
        {
            this.arr = arr;
            this.directions = directions;
            this.filePathOut = filePathOut;
        }
        public void startManualArr()
        {
            var timer = Stopwatch.StartNew();
            arr = NSortClass.NSort(arr, directions);
            timer.Stop();
            time = timer.ElapsedMilliseconds;
            fileHandler.fileRecorder(filePathOut, arr);
            return;
        }
        public int start()
        {
            fileContent = fileHandler.fileOpen(filePathInp);
            try
            {
                arr = fileHandler.GetInfo(fileContent, out directions);
            } catch(Exception e)
            {
                if (e.Message == "Нечисловое значение")
                {
                    return 3;
                }
                if (e.Message == "Некорректный формат")
                {
                    return 4;
                }
            }
            if (fileContent == null)
            {
                return 1;
            }
            if (fileContent.Length == 0)
            {
                return 2;
            }

            var timer = Stopwatch.StartNew();
            arr = NSortClass.NSort(arr, directions);
            timer.Stop();
            time = timer.ElapsedMilliseconds;
            fileHandler.fileRecorder(filePathOut, arr);
            return 0;
        }
        public int[,] GetArr()
        {
            return arr;
        }

        public int[] GetDirections()
        {
            return directions;
        }

    }
}
