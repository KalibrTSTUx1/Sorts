using sortMethods;
namespace Test
{
    class T
    {
        static void Main()
        {
            int[] arr = { 1, 4, 6, 2, 6, 7, 9, 10, 6 };
                foreach (int i in SortMethods.BogoSort(arr,1))
                    Console.Write($" {i} ");
                Console.WriteLine();

            int[]arr2 = { -1, 4, 6, 2, 6, 7, -9, 10, 6, 2, 16, 12 };
            foreach (int i in SortMethods.HeapSort(arr2, arr2.Length, 0))
                Console.Write($" {i} ");
            Console.WriteLine();

            double[] arr3 = { -1, 4.33, 6, 2, 6.1, 7, -9, 10.2, 6, 2, 16, 12 };
            foreach (double i in SortMethods.HeapSort(arr3, arr2.Length, 0))
                Console.Write($" {i} ");
            Console.WriteLine();

            return;
        }
    }
}