namespace NSortClassLib
{
    /// <summary>
    /// Класс, позволяющий осуществлять парралельную сортировку произвольного массива
    /// в заданном набором нулей и единиц порядке для каждого столбца
    /// где нуль будет обозначать сортировку по убыванию в столбце
    /// а единица - по возрастанию
    /// </summary>
    public static class NSortClass
    {
        /// <summary>
        /// Вспомогательная функция, позволяющая менять данные строки в массиве местами
        /// </summary>
        /// <param name="arr">Массив, над которым осуществляется работа</param>
        /// <param name="a">Первая строка</param>
        /// <param name="b">Вторая строка</param>
        private static void SwapRow(int[,] arr, int a, int b)
        {
            int temp;
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                temp = arr[a, i];
                arr[a, i] = arr[b, i];
                arr[b, i] = temp;
            }

        }
        /// <summary>
        /// Функция, осуществляющая сортировку двумерного массива методом вставок
        /// в заданном направлении,
        /// заданном диапозоне строк и по заданному т.н. "приоритету", 
        /// т.е. по заданному столбцу
        /// </summary>
        /// <param name="priority">Столбец, по которому осуществляется сортировка</param>
        /// <param name="a">Сортируемый массив</param>
        /// <param name="direction">Направление сортировки</param>
        /// <param name="l">Начало заданного диапозона</param>
        /// <param name="r">Конец заданного диапозона</param>
        private static void SortByPriorityInRange(int priority, int[,] a, int direction, int l, int r)
        {
            if (direction == 0)
            {
                for (int i = l; i <= r - 1; i++)
                {
                    for (int j = l; j < r - 1; j++)
                        if (a[j, priority] < a[j + 1, priority])
                        {
                            SwapRow(a, j, j + 1);
                        }
                }
            }
            else
            {
                for (int i = l; i <= r - 1; i++)
                {
                    for (int j = l; j < r - 1; j++)
                        if (a[j, priority] > a[j + 1, priority])
                        {
                            SwapRow(a, j, j + 1);
                        }
                }
            }
        }
        /// <summary>
        /// Функция, ищущая последовательности повторяющихся элементов
        /// в заданном массиве, столбце и диапозоне строк
        /// </summary>
        /// <param name="arr">Заданный массив</param>
        /// <param name="priority">Столбец, в котором ищутся повторяющиеся значения</param>
        /// <param name="l">Начало диапозона строк</param>
        /// <param name="r">Конец диапозона строк</param>
        /// <returns>
        /// Список, состоящий из массивов, включающих два элемента - 
        /// начало повторяющийся последовательности и ее конец
        /// </returns>
        private static List<int[]> FoundEqNumsIndxesInRange(int[,] arr, int priority, int l, int r)
        {
            List<int[]> list = new List<int[]>();

            for (int i = l; i < r - 1; i++)
            {

                if (arr[i, priority] == arr[i + 1, priority])
                {
                    for (int j = i; j < r - 1; j++)
                    {
                        if (arr[j, priority] != arr[j + 1, priority])
                        {
                            list.Add(new int[] { i, j });
                            i = j;
                            break;
                        }
                        if (arr[j, priority] == arr[j + 1, priority] && j + 1 == r - 1)
                        {
                            list.Add(new int[] { i, r - 1 });
                            i = j;
                            break;
                        }
                    }
                }
            }

            return list;
        }
        /// <summary>
        /// Функция, осуществляющая парралельную сортировку данного массива
        /// на основе массива, состоящего из направлений - последовательности нулей и единиц
        /// в данном диапозоне строк
        /// по данному приоритету, то есть строке, по которой сортируется массив
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="directions"></param>
        /// <param name="l"></param>
        /// <param name="r"></param>
        /// <param name="priority"></param>
        private static void NSortRange(int[,] arr, int[] directions, int l, int r, int priority)
        {
            //Сортируем по исходному приоритету
            SortByPriorityInRange(priority, arr, directions[priority], l, r);
            //Находим повторяющиеся последовательности элементов, т.о.
            //определяем, какие строки будем сортировать по следующему столбцу ("приоритету")
            List<int[]> eqValsIndexs = FoundEqNumsIndxesInRange(arr, priority, l, r);
            //Вызываем эту же функцию в полученных диапозонах повторяющихся символов
            //но по следующему приоритету - т.е. по следующему столбцу
            foreach (int[] eqVals in eqValsIndexs)
            {
                if (priority + 1 == directions.Length)
                {
                    return;
                }
                NSortRange(arr, directions, eqVals[0], eqVals[1] + 1, priority + 1);
            }
        }
        /// <summary>
        /// Основная функция, возвращающая отсортированный таким образом массив
        /// на основе массива направлений
        /// </summary>
        /// <param name="arr">Сортируемый массив</param>
        /// <param name="directions">Массив направлений</param>
        /// <returns>Отсортированный массив</returns>
        public static int[,] NSort(int[,] arr, int[] directions)
        {
            int[,] res = arr;
            NSortRange(arr, directions, 0, res.GetLength(0), 0);
            return res;
        }
    }
}