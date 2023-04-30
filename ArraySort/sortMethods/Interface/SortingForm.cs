using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sortMethods;

namespace Interface
{
    public partial class SortingForm : Form
    {
        //для данной формы ее конструктор имеет особенности
        //нужно дать лог, который отобразится в поле
        //нужно дать текст, который отобразится сверху(название сортировки)
        //нужно дать результирующий массив, который отобразится в соответсвущем поле
        public SortingForm(string log, string method, int[] resArr)
        {
            InitializeComponent();
            logOfChanges.Text = log;
            sortName.Text = method;
            resArray.Text = SortMethods.ArrToStr(resArr);
        }

        
    }
}
