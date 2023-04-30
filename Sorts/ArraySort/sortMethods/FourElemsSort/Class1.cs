namespace FourElemsSort
{
    public class FourElemsSor
    {
        public enum Colors { Red, Green, Blue, White }
        private static void SwapByColor((int, Colors)[] arr, int a, int b)
        {
            var v = arr[a];
            arr[a] = arr[b];
            arr[b] = v;
        }
        private static void SwapByNumber(List<(int, Colors)> arr, int a, int b)
        {
            var v = arr[a];
            arr[a] = arr[b];
            arr[b] = v;
        }
        public static (int, Colors)[] SortColor((int, Colors)[] tupl, int l, int r)
        {
            int i = l;
            int j = r;
            var pivot = tupl[(l + r) / 2].Item2;
            while (i <= j)
            {
                while (tupl[i].Item2 < pivot)
                {
                    i++;
                }
                while (tupl[j].Item2 > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    SwapByColor(tupl, i, j);
                    i++;
                    j--;
                }
            }
            if (l < j)
            {
                SortColor(tupl, l, j);
            }
            if (i < r)
            {
                SortColor(tupl, i, r);
            }

            return tupl;
        }
        public static (int, Colors)[] SortNumbers(List<(int, Colors)> tupl, int l, int r)
        {
            int i = l;
            int j = r;
            var pivot = tupl[(l + r) / 2].Item1;
            while (i <= j)
            {
                while (tupl[i].Item1 < pivot)
                {
                    i++;
                }
                while (tupl[j].Item1 > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    SwapByNumber(tupl, i, j);
                    i++;
                    j--;
                }
            }
            if (l < j)
            {
                SortNumbers(tupl, l, j);
            }
            if (i < r)
            {
                SortNumbers(tupl, i, r);
            }
            return tupl.ToArray();
        }
        public static List<(int, Colors)> SplitTuple((int, Colors)[] tupl, Colors Color)
        {
            List<(int, Colors)> Col = new List<(int, Colors)>();
            foreach (var n in tupl)
                if (n.Item2 == Color)
                    Col.Add(n);
            return Col;
        }

        public static (int, Colors)[] Sorting((int, Colors)[] tuple, Colors[] ArrayColor)
        {
            (int, Colors)[] resultColor = SortColor(tuple, 0, tuple.Length - 1);
            List<(int, Colors)> TUPL = new List<(int, Colors)>();
            foreach (Colors Color in ArrayColor)
            {
                foreach (var El in SortNumbers(SplitTuple(resultColor, Color), 0, SplitTuple(resultColor, Color).Count - 1))
                    TUPL.Add(El);
            }
            (int, Colors)[] result = TUPL.ToArray();
            foreach (var n in result)
            {
                Console.Write("{0} {1}", n.Item1, n.Item2);
                Console.WriteLine();
            }
            return result;
        }
    }
}