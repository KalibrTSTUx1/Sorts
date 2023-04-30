using NSortClassLib;

namespace StringSort
{
    public class StringSort
    {
        public static string[] StrSort(string[] str, int direction)
        {
            int maxLen = FoundMaxLen(str);
            int[,] numberFormOfStr = new int[maxLen, str.Length];
            string[] strArray = new string[str.Length];

            numberFormOfStr = ConvertToNumberForm(str, maxLen);
            int[] dir = FillDirections(maxLen, direction);
            numberFormOfStr = NSortClass.NSort(numberFormOfStr, dir);
            strArray = ConvertToStringForm(numberFormOfStr);

            return strArray;
        }
        private static int FoundMaxLen(string[] str)
        {
            int res = -1;
            foreach (string elem in str)
            {
                res = Math.Max(res, elem.Length);
            }
            return res;
        }

        private static int[,] ConvertToNumberForm(string[] str, int mlen)
        {
            int[,] res = new int[str.Length, mlen];
            for (int i = 0; i < str.Length ; i++)
            {
                for (int j = 0; j < str[i].Length; j++)
                {
                    res[i,j] = Convert.ToChar(str[i][j]);
                }
            }
            return res;
        }
        
        private static int[] FillDirections(int mlen, int direction)
        {
            int[] res = new int[mlen];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = direction;
            }
            return res;
        }
        
        private static string[] ConvertToStringForm(int[,] numberForm)
        {
            string[] res = new string[numberForm.GetLength(1)];
            for (int i = 0; i<numberForm.GetLength(0); i++)
            {
                for (int j =0; j<numberForm.GetLength(1);j++)
                {
                    if (numberForm[i,j] != 0)
                    {
                        res[i] += Convert.ToChar(numberForm[i, j]);
                    }
                }
            }
            return res;
        }
    }
    
}