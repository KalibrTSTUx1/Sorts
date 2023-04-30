using System.Xml.Linq;

namespace sortMethods
{
    public class SortMethods
    {
        /// <summary>
        /// Возвращает целочисленный массив, отсортированный методом быстрой сортировки Хоара
        /// </summary>
        /// <param name="arr">Сортируемый целочисленный массив</param>
        /// <param name="directionOfSort">
        /// Направление сортировки
        /// (0 - по убыванию, 1 - по возрастанию)
        /// </param>
        /// <returns>Отсортированный целочисленный массив</returns>
        public static int[] FastSort(int[] arr, int directionOfSort)
        {
            if (directionOfSort == 0)
                return QuickSortRangeDown(arr, 0, arr.Length - 1);
            else
                return QuickSortRangeUp(arr, 0, arr.Length - 1);
        }
        public static double[] FastSort(double[] arr, int directionOfSort)
        {
            if (directionOfSort == 0)
                return QuickSortRangeDown(arr, 0, arr.Length - 1);
            else
                return QuickSortRangeUp(arr, 0, arr.Length - 1);
        }

        /// <summary>
        /// Вспомогательная функция для быстрой сортировки
        /// массива по возрастанию
        /// </summary>
        /// <param name="a">Сортируемый массив</param>
        /// <param name="l">Индекс начала сортируемого отрезка</param>
        /// <param name="r">Индекс конца сортируемого отрезка</param>
        /// <returns></returns>
        private static int[] QuickSortRangeUp(int[] a, int l, int r)
        {
            int i = l;
            int j = r;
            int pivot = a[(l + r) / 2];
            while (i <= j)
            {
                while (a[i] < pivot)
                {
                    i++;
                }

                while (a[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    SwapByIndex(a, i, j);
                    i++;
                    j--;
                }
            }

            if (l < j)
            {
                QuickSortRangeUp(a, l, j);
            }
            if (i < r)
            {
                QuickSortRangeUp(a, i, r);
            }
            return a;
        }
        /// <summary>
        /// Вспомогательная функция для быстрой сортировки массива
        /// по убыванию
        /// </summary>
        /// <param name="a">Сортируемый массив</param>
        /// <param name="l">Индекс начала сортируемого отрезка</param>
        /// <param name="r">Индекс конца сортируемого отрезка</param>
        /// <returns></returns>
        private static double[] QuickSortRangeUp(double[] a, int l, int r)
        {
            int i = l;
            int j = r;
            double pivot = a[(l + r) / 2];
            while (i <= j)
            {
                while (a[i] < pivot)
                {
                    i++;
                }

                while (a[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    SwapByIndex(a, i, j);
                    i++;
                    j--;
                }
            }

            if (l < j)
            {
                QuickSortRangeUp(a, l, j);
            }
            if (i < r)
            {
                QuickSortRangeUp(a, i, r);
            }
            return a;
        }
        private static double[] QuickSortRangeDown(double[] a, int l, int r)
        {
            int i = l;
            int j = r;
            double pivot = a[(l + r) / 2];
            while (i <= j)
            {
                while (a[i] > pivot)
                {
                    i++;
                }

                while (a[j] < pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    SwapByIndex(a, i, j);
                    i++;
                    j--;
                }
            }

            if (l < j)
            {
                QuickSortRangeDown(a, l, j);
            }
            if (i < r)
            {
                QuickSortRangeDown(a, i, r);
            }
            return a;
        }
        private static int[] QuickSortRangeDown(int[] a, int l, int r)
        {
            int i = l;
            int j = r;
            int pivot = a[(l + r) / 2];
            while (i <= j)
            {
                while (a[i] > pivot)
                {
                    i++;
                }

                while (a[j] < pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    SwapByIndex(a, i, j);
                    i++;
                    j--;
                }
            }

            if (l < j)
            {
                QuickSortRangeDown(a, l, j);
            }
            if (i < r)
            {
                QuickSortRangeDown(a, i, r);
            }
            return a;
        }
        /// <summary>
        /// Осуществляет сортировку слиянием данного массива
        /// </summary>
        /// <param name="a">Сортируемый массив</param>
        /// <param name="l">Начало сортируемого отрезка</param>
        /// <param name="r">Конец сортируемого отрезка</param>
        /// <param name="mode">
        /// Режим сортировки:
        /// 0 - по убыванию
        /// 1 - по возрастанию 
        /// </param>
        /// <returns>Отсортированный слиянием массив</returns>
        public static double[] MergeSort(double[] a, int l, int r, int mode)
        {
            if (l < r)
            {
                int m = (r + l) / 2;
                if (mode == 1)
                {
                    MergeSort(a, l, m, 1);
                    MergeSort(a, m + 1, r, 1);
                    MergeUp(a, l, r);
                }
                else
                {
                    MergeSort(a, l, m, 0);
                    MergeSort(a, m + 1, r, 0);
                    MergeDown(a, l, r);
                }
            }
            return a;
        }
        public static int[] MergeSort(int[] a, int l, int r, int mode)
        {
            if (l < r)
            {
                int m = (r + l) / 2;
                if (mode == 1)
                {
                    MergeSort(a, l, m, 1);
                    MergeSort(a, m + 1, r, 1);
                    MergeUp(a, l, r);
                }
                else
                {
                    MergeSort(a, l, m, 0);
                    MergeSort(a, m + 1, r, 0);
                    MergeDown(a, l, r);
                }
            }
            return a;
        }
        /// <summary>
        /// Вспомогательная функция для сортировки слиянием
        /// по возрастанию
        /// </summary>
        /// <param name="a">Сортируемый массив</param>
        /// <param name="l">Индекс начала сортируемого отрезка</param>
        /// <param name="r">Индекс конца сортируемого отрезка</param>
        private static void MergeUp(double[] a, int l, int r)
        {
            int m = l + (r - l) / 2;
            double[] la = new double[m - l + 1];
            double[] ra = new double[r - m];
            int i, j;
            for (i = 0; i < la.Length; ++i)
                la[i] = a[l + i];
            for (j = 0; j < ra.Length; ++j)
                ra[j] = a[m + 1 + j];
            i = 0;
            j = 0;
            int t = l;
            while (i < la.Length && j < ra.Length)
            {
                if (la[i] <= ra[j])
                {
                    a[t] = la[i];
                    i++;
                }
                else
                {
                    a[t] = ra[j];
                    j++;
                }
                t++;
            }
            while (i < la.Length)
            {
                a[t] = la[i];
                i++;
                t++;
            }
            while (j < ra.Length)
            {
                a[t] = ra[j];
                j++;
                t++;
            }
        }
        private static void MergeUp(int[] a, int l, int r)
        {
            int m = l + (r - l) / 2;
            int[] la = new int[m - l + 1];
            int[] ra = new int[r - m];
            int i, j;
            for (i = 0; i < la.Length; ++i)
                la[i] = a[l + i];
            for (j = 0; j < ra.Length; ++j)
                ra[j] = a[m + 1 + j];
            i = 0;
            j = 0;
            int t = l;
            while (i < la.Length && j < ra.Length)
            {
                if (la[i] <= ra[j])
                {
                    a[t] = la[i];
                    i++;
                }
                else
                {
                    a[t] = ra[j];
                    j++;
                }
                t++;
            }
            while (i < la.Length)
            {
                a[t] = la[i];
                i++;
                t++;
            }
            while (j < ra.Length)
            {
                a[t] = ra[j];
                j++;
                t++;
            }
        }
        /// <summary>
        /// Вспомогательная функция для сортировки слиянием
        /// по убыванию
        /// </summary>
        /// <param name="a">Сортируемый массив</param>
        /// <param name="l">Индекс начала сортируемого отрезка</param>
        /// <param name="r">Индекс конца сортируемого отрезка</param>
        private static void MergeDown(double[] a, int l, int r)
        {
            int m = l + (r - l) / 2;
            double[] la = new double[m - l + 1];
            double[] ra = new double[r - m];
            int i, j;
            for (i = 0; i < la.Length; ++i)
                la[i] = a[l + i];
            for (j = 0; j < ra.Length; ++j)
                ra[j] = a[m + 1 + j];
            i = 0;
            j = 0;
            int t = l;
            while (i < la.Length && j < ra.Length)
            {
                if (la[i] >= ra[j])
                {
                    a[t] = la[i];
                    i++;
                }
                else
                {
                    a[t] = ra[j];
                    j++;
                }
                t++;
            }
            while (i < la.Length)
            {
                a[t] = la[i];
                i++;
                t++;
            }
            while (j < ra.Length)
            {
                a[t] = ra[j];
                j++;
                t++;
            }
        }
        private static void MergeDown(int[] a, int l, int r)
        {
            int m = l + (r - l) / 2;
            int[] la = new int[m - l + 1];
            int[] ra = new int[r - m];
            int i, j;
            for (i = 0; i < la.Length; ++i)
                la[i] = a[l + i];
            for (j = 0; j < ra.Length; ++j)
                ra[j] = a[m + 1 + j];
            i = 0;
            j = 0;
            int t = l;
            while (i < la.Length && j < ra.Length)
            {
                if (la[i] >= ra[j])
                {
                    a[t] = la[i];
                    i++;
                }
                else
                {
                    a[t] = ra[j];
                    j++;
                }
                t++;
            }
            while (i < la.Length)
            {
                a[t] = la[i];
                i++;
                t++;
            }
            while (j < ra.Length)
            {
                a[t] = ra[j];
                j++;
                t++;
            }
        }
        /// <summary>
        /// Осуществляет пирамидальную сортировку массива 
        /// </summary>
        /// <param name="M">Сортируемый массив</param>
        /// <param name="N">Длина сортируемого массива</param>
        /// <param name="mode">
        /// Режим сортировки:
        /// 0 - по убыванию
        /// 1 - по возрастанию 
        /// </param>
        public static int[] HeapSort(int[] M, int N, int mode)
        {
            for (int i = N / 2 - 1; i >= 0; i--)
            {
                if (mode == 0)
                {
                    HeapifyDown(M, N, i);
                }
                else
                {
                    HeapifyUp(M, N, i);
                }
            }
            for (int i = N - 1; i >= 0; i--)
            {
                SwapByRef(ref M[0], ref M[i]);
                if (mode == 0)
                {
                    HeapifyDown(M, i, 0);
                }
                else
                {
                    HeapifyUp(M, i, 0);
                }
            }
            return M;
        }
        public static double[] HeapSort(double[] M, int N, int mode)
        {
            for (int i = N / 2 - 1; i >= 0; i--)
            {
                if (mode == 0)
                {
                    HeapifyDown(M, N, i);
                }
                else
                {
                    HeapifyUp(M, N, i);
                }
            }
            for (int i = N - 1; i >= 0; i--)
            {
                SwapByRef(ref M[0], ref M[i]);
                if (mode == 0)
                {
                    HeapifyDown(M, i, 0);
                }
                else
                {
                    HeapifyUp(M, i, 0);
                }
            }
            return M;
        }
        /// <summary>
        /// Вспомогательная функция для пирамидальной сортировки 
        /// по возрастанию
        /// </summary>
        /// <param name="M"></param>
        /// <param name="N">Индекс начала сортируемого отрезка</param>
        /// <param name="i">Индекс конца сортируемого отрезка</param>
        private static void HeapifyUp(int[] M, int N, int i)
        {
            int iM = i;
            int L = 2 * i + 1, R = 2 * i + 2;
            if (L < N && (M[L] > M[iM]))
            {
                iM = L;
            }
            if (R < N && (M[R] > M[iM]))
            {
                iM = R;
            }
            if (i != iM)
            {
                SwapByRef(ref M[i], ref M[iM]);
                HeapifyUp(M, N, iM);
            }
            return;
        }
        private static void HeapifyUp(double[] M, int N, int i)
        {
            int iM = i;
            int L = 2 * i + 1, R = 2 * i + 2;
            if (L < N && (M[L] > M[iM]))
            {
                iM = L;
            }
            if (R < N && (M[R] > M[iM]))
            {
                iM = R;
            }
            if (i != iM)
            {
                SwapByRef(ref M[i], ref M[iM]);
                HeapifyUp(M, N, iM);
            }
            return;
        }
        /// <summary>
        /// Вспомогательная функция для пирамидальной сортировки 
        /// по убыванию
        /// </summary>
        /// <param name="M">Сортируемый массив</param>
        /// <param name="N">Индекс начала сортируемого отрезка</param>
        /// <param name="i">Индекс конца сортируемого отрезка</param>
        private static void HeapifyDown(int[] M, int N, int i)
        {
            int iM = i;
            int L = 2 * i + 1, R = 2 * i + 2;
            if (L < N && (M[L] < M[iM]))
            {
                iM = L;
            }
            if (R < N && (M[R] < M[iM]))
            {
                iM = R;
            }
            if (i != iM)
            {
                SwapByRef(ref M[i], ref M[iM]);
                HeapifyDown(M, N, iM);
            }
            return;
        }
        private static void HeapifyDown(double[] M, int N, int i)
        {
            int iM = i;
            int L = 2 * i + 1, R = 2 * i + 2;
            if (L < N && (M[L] < M[iM]))
            {
                iM = L;
            }
            if (R < N && (M[R] < M[iM]))
            {
                iM = R;
            }
            if (i != iM)
            {
                SwapByRef(ref M[i], ref M[iM]);
                HeapifyDown(M, N, iM);
            }
            return;
        }
        public static int[] BubbleSort(int[] a, int napr)
        {
            if (napr == 0)
            {
                for (int i = 0; i <= a.Length - 1; i++)
                {
                    bool swapflag = false;
                    for (int j = 0; j < a.Length - 1; j++)
                        if (a[j] < a[j + 1])
                        {
                            SwapByRef(ref a[j], ref a[j + 1]);
                            swapflag = true;
                        }
                    if (!swapflag)
                    {
                        return a;
                    }
                }
                return a;
            }
            else
            {
                for (int i = 0; i <= a.Length - 1; i++)
                {
                    bool swapflag = false;
                    for (int j = 0; j < a.Length - 1; j++)
                        if (a[j] > a[j + 1])
                        {
                            SwapByRef(ref a[j], ref a[j + 1]);
                            swapflag = true;
                        }
                    if (!swapflag)
                    {
                        return a;
                    }
                }
                return a;
            }
        }
        public static double[] BubbleSort(double[] a, int napr)
        {
            if (napr == 0)
            {
                for (int i = 0; i <= a.Length - 1; i++)
                {
                    bool swapflag = false;
                    for (int j = 0; j < a.Length - 1; j++)
                        if (a[j] < a[j + 1])
                        {
                            SwapByRef(ref a[j], ref a[j + 1]);
                            swapflag = true;
                        }
                    if (!swapflag)
                    {
                        return a;
                    }
                }
                return a;
            }
            else
            {
                for (int i = 0; i <= a.Length - 1; i++)
                {
                    bool swapflag = false;
                    for (int j = 0; j < a.Length - 1; j++)
                        if (a[j] > a[j + 1])
                        {
                            SwapByRef(ref a[j], ref a[j + 1]);
                            swapflag = true;
                        }
                    if (!swapflag)
                    {
                        return a;
                    }
                }
                return a;
            }
        }
        /// <summary>
        /// Функция сортировки вставками
        /// </summary>
        /// <param name="a">Исходный массив</param>
        /// <param name="napr">Направление</param>
        /// <returns></returns>
        public static int[] InsertSort(int[] a, int napr)
        {
            if (napr == 0)
            {
                for (int i = 0; i <= a.Length - 1; i++)
                {
                    for (int j = 0; j < a.Length - 1; j++)
                        if (a[j] < a[j + 1])
                        {
                            SwapByRef(ref a[j], ref a[j + 1]);
                        }
                }
                return a;
            }
            else
            {
                for (int i = 0; i <= a.Length - 1; i++)
                {
                    for (int j = 0; j < a.Length - 1; j++)
                        if (a[j] > a[j + 1])
                        {
                            SwapByRef(ref a[j], ref a[j + 1]);
                        }
                }
                return a;
            }
        }
        public static double[] InsertSort(double[] a, int napr)
        {
            if (napr == 0)
            {
                for (int i = 0; i <= a.Length - 1; i++)
                {
                    for (int j = 0; j < a.Length - 1; j++)
                        if (a[j] < a[j + 1])
                        {
                            SwapByRef(ref a[j], ref a[j + 1]);
                        }
                }
                return a;
            }
            else
            {
                for (int i = 0; i <= a.Length - 1; i++)
                {
                    for (int j = 0; j < a.Length - 1; j++)
                        if (a[j] > a[j + 1])
                        {
                            SwapByRef(ref a[j], ref a[j + 1]);
                        }
                }
                return a;
            }
        }
        /// <summary>
        /// Функция сортировки подсчетом
        /// </summary>
        /// <param name="a">Исходный массив</param>
        /// <param name="napr">Направление</param>
        /// <returns></returns>
        public static int[] CountSort(int[] a, int napr)
        {
            int minelement = a[0], maxelement = a[0];
            int LeghtArray = a.Length;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > maxelement)
                {
                    maxelement = a[i];
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < minelement)
                {
                    minelement = a[i];
                }
            }
            if (napr == 1)
            {
                int[] array = a;
                int diapozon = maxelement - minelement + 1;
                int[] s = new int[diapozon]; // вспомогательный массив
                for (int i = 0; i < diapozon; i++)
                {
                    s[i] = 0;
                }
                for (int i = 0; i < LeghtArray; i++)
                {
                    s[array[i] - minelement]++;
                }
                int j = 0;
                for (int i = 0; i < diapozon; i++)
                {
                    for (int k = 0; k < s[i]; k++)
                    {
                        array[j++] = i + minelement;
                    }
                }
                return a;
            }
            else
            {
                int[] array = a;
                int diapozon = maxelement - minelement + 1;
                int[] s = new int[diapozon]; // вспомогательный массив
                for (int i = 0; i < diapozon; i++)
                {
                    s[i] = 0;
                }
                for (int i = 0; i < LeghtArray; i++)
                {
                    s[array[i] - minelement]++;
                }
                int j = 0;
                for (int i = diapozon - 1; i > -1; i--)
                {
                    for (int k = 0; k < s[i]; k++)
                    {
                        array[j++] = i + minelement;
                    }
                }
                return a;
            }
        }
        public static double[] CountSort(double[] a, int napr)
        {
            double minelement = a[0], maxelement = a[0];
            int LeghtArray = a.Length;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > maxelement)
                {
                    maxelement = a[i];
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < minelement)
                {
                    minelement = a[i];
                }
            }
            if (napr == 1)
            {
                double[] array = a;
                double diapozon = maxelement - minelement + 1;
                double[] s = new double[(int)diapozon]; // вспомогательный массив
                for (int i = 0; i < diapozon; i++)
                {
                    s[i] = 0;
                }
                for (int i = 0; i < LeghtArray; i++)
                {
                    s[(int)array[i] - (int)minelement]++;
                }
                int j = 0;
                for (int i = 0; i < diapozon; i++)
                {
                    for (int k = 0; k < s[i]; k++)
                    {
                        array[j++] = i + minelement;
                    }
                }
                return a;
            }
            else
            {
                double[] array = a;
                double diapozon = maxelement - minelement + 1;
                double[] s = new double[(int)diapozon]; // вспомогательный массив
                for (int i = 0; i < diapozon; i++)
                {
                    s[i] = 0;
                }
                for (int i = 0; i < LeghtArray; i++)
                {
                    s[(int)array[i] - (int)minelement]++;
                }
                int j = 0;
                for (double i = diapozon - 1; i > -1; i--)
                {
                    for (double k = 0; k < s[(int)i]; k++)
                    {
                        array[j++] = i + minelement;
                    }
                }
                return a;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double[] BogoSort(double[] arr, int direction)
        {
            double[] res = arr;
            while (!IsSortedCorrect(res, direction)) {
                res = Shuffle(res);
            }
            return res;
        }
        public static int[] BogoSort(int[] arr, int direction)
        {
            int[] res = arr;
            while (!IsSortedCorrect(res, direction))
            {
                res = Shuffle(res);
            }
            return res;
        }
        public static double[] Shuffle(double[] arr)
        {
            Random R = new Random();
            double[] res = new double[arr.Length];
            List<int> indexes = new();
            for (int i = 0; i < arr.Length; i++)
                indexes.Add(i);
            for (int i = 0; i < res.Length; i++)
            {
                int rndInd = R.Next(0, indexes.Count);
                res[i] = arr[indexes[rndInd]];
                indexes.RemoveAt(rndInd);
            }
            return res;
        }
        public static int[] Shuffle(int[] arr)
        {
            Random R = new Random();
            int[] res = new int[arr.Length];
            List<int> indexes = new();
            for (int i = 0; i<arr.Length; i++)
                indexes.Add(i);
            for (int i = 0; i < res.Length; i++)
            {
                int rndInd = R.Next(0, indexes.Count);
                res[i] = arr[indexes[rndInd]];
                indexes.RemoveAt(rndInd);
            }
            return res;
        }
        /// <summary>
        /// Выполняет обмен элементов данного массива по ссылке
        /// </summary>
        /// <param name="a">Первый элемент</param>
        /// <param name="b">Второй элемент</param>
        private static void SwapByRef(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }
        private static void SwapByRef(ref double a, ref double b)
        {
            double t = a;
            a = b;
            b = t;
        }
        /// <summary>
        /// Выполняет обмен элементов данного массива по индексу
        /// </summary>
        /// <param name="arr">Данный массив</param>
        /// <param name="a">Первый индекс</param>
        /// <param name="b">Второй индекс</param>
        private static void SwapByIndex(int[] arr, int a, int b)
        {
            int v = arr[a];
            arr[a] = arr[b];
            arr[b] = v;
        }
        private static void SwapByIndex(double[] arr, int a, int b)
        {
            double v = arr[a];
            arr[a] = arr[b];
            arr[b] = v;
        }
        /// <summary>
        /// Превращает массив в строку с его элементами
        /// </summary>
        /// <param name="arr">Данный массив</param>
        /// <returns>Строка с элементами массива</returns>
        public static string ArrToStr(int[] arr)
        {
            string res = "";
            for (int i = 0; i < arr.Length; i++)
            {
                res += Convert.ToString(arr[i]);
                res += " ";
            }
            return res;
        }
        public static string ArrToStr(double[] arr)
        {
            string res = "";
            for (int i = 0; i < arr.Length; i++)
            {
                res += Convert.ToString(arr[i]);
                res += " ";
            }
            return res;
        }
        /// <summary>
        /// Создает массив, заполненный данным количеством псевдослучайныч чисел
        /// в данном диапозоне
        /// </summary>
        /// <param name="n">Количество случайных числел</param>
        /// <param name="left">Нижняя граница диапозона</param>
        /// <param name="right">Верхняя граница диапозона</param>
        /// <returns>Целочисленный массив, состоящий из случайных чисел</returns>
        public static int[] RandomFill(int n, int left, int right)
        {
            Random R = new Random();
            int[] massive = new int[n];
            for (int i = 0; i < massive.Length; i++)
            {
                massive[i] = R.Next(left, (right + 1));
            }
            return massive;
        }
        /// <summary>
        /// Проверяет, корректно ли отсортирован данный массив в заданном направлении
        /// </summary>
        /// <param name="arr">Проверяемый массив</param>
        /// <param name="direction">Направление проверки сортировки</param>
        /// <returns>True если массив отсортирован корректно, false, если нет</returns>
        public static bool IsSortedCorrect(double[] arr, int direction)
        {
            if (direction == 0) //по убыванию
            {
                for (int i = 0; i<arr.Length - 1; i++)
                {
                    if (arr[i] < arr[i + 1])
                        return false;
                }
            } else //по возрастанию
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                        return false;
                }
            }
            return true;
        }
        public static bool IsSortedCorrect(int[] arr, int direction)
        {
            if (direction == 0) //по убыванию
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] < arr[i + 1])
                        return false;
                }
            }
            else //по возрастанию
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                        return false;
                }
            }
            return true;
        }

    }
    
}