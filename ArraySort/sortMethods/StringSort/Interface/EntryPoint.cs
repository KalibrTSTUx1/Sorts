using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace Interface
{
    internal class EntryPoint
    {
        private string[] arr;
        int direction;

        public EntryPoint(string[] fileInfo, int dir)
        {
            this.arr = fileInfo;
            this.direction = dir;
        }   


        private string[] ConvertToCorrectOutput(string[] msc)
        {
            string[] output = msc;
            for (int i =0; i< msc.Length; i++)
            {
                output[i] += "\r\n";
            }
            return output;
        }

        public string[] ReturnRes()
        {
            return ConvertToCorrectOutput(StringSort.StrSort(arr, direction));
        }
    }
}
