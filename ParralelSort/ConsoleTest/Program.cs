using NSortClassLib;
using StringSort;

namespace P
{
    class P
    {
        static void Main()
        {
            //string sort test
            string[] ex =
            {
                "АБББВ",
                "ЮВАО",
                "ПРОЛЕТАРКА",
                "ЮЖАК",
                "АА"
            };
            string[] sorted = StringSort.StringSort.StrSort(ex, 1);
            foreach (string str in sorted)
            {
                Console.WriteLine(str);
            }
        }
    }
}