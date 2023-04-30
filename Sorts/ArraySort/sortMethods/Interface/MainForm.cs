using Microsoft.VisualBasic.Devices;
using sortMethods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Interface
{
    public partial class MainForm : Form
    {
        public int sortDirection;
        public int[] Arr;
        public int[] sortedArr;
        public string sortLog;
        SortingForm F2;
        public MainForm()
        {
            InitializeComponent();
            ErrorText.Hide();
        }
        /// <summary>
        /// Перерисовывает, т.е выделяет цветом кнопку, 
        /// которая показывает направление сортировки
        /// </summary>
        /// <param name="sortDirection"></param>
        private void ReDrawButton(int sortDirection)
        {
            if (sortDirection == 1)
            {
                butSelectUpDir.ForeColor = Color.Blue;
                butSelectDownDir.ForeColor = Color.Black;
            }
            else
            {
                butSelectUpDir.ForeColor = Color.Black;
                butSelectDownDir.ForeColor = Color.Blue;
            }
        }
        /// <summary>
        /// Превращает введенную пользователем строку в массив целых чисел
        /// </summary>
        private void InitArr()
        {
            try
            {
                string[] strArr = arrayBox.Text.Split(';');
                Arr = new int[strArr.Length];
                for (int i = 0; i < strArr.Length; i++)
                    Arr[i] = int.Parse(strArr[i]);
            } catch(Exception)
            {
                Arr = new int[0];
                ErrorText.Show();
                return;
            }
            arrayBox.ForeColor = Color.Black;

        }
       
        private void butSelectUpDir_Click(object sender, EventArgs e)
        {
            sortDirection = 1;
            ReDrawButton(sortDirection);
        }
        
        private void butSelectDownDir_Click(object sender, EventArgs e)
        {
            sortDirection = 0;
            ReDrawButton(sortDirection);
        }
        //все кнопки сделаны по одинаковому шаблону 
        //(я бы через класс сделал но хз как)
        //считываем массив, далее записываем в глобальный лог лог сортировки
        //создаем новую форму, показываем
        //далее обнуляем лог на будущее
        //если основной массив пуст, то говорим об этом
        private void FastSortButton_Click(object sender, EventArgs e)
        {
            InitArr();
            if (Arr.Length == 0)
            {
                ErrorText.Show();
                return;
            }
            ErrorText.Hide();
            sortedArr = SortMethods.FastSort(Arr, sortDirection);
            sortLog = SortMethods.sortLog;
            F2 = new SortingForm(sortLog, FastSortButton.Text, sortedArr);
            F2.Show();
            SortMethods.sortLog = "";
        }

        private void MergeSortButton_Click(object sender, EventArgs e)
        {
            InitArr();
            if (Arr.Length == 0)
            {
                ErrorText.Show();
                return;
            }
            ErrorText.Hide();
            sortedArr = SortMethods.MergeSort(Arr,0,Arr.Length-1, sortDirection);
            sortLog = SortMethods.sortLog;
            F2 = new SortingForm(sortLog, MergeSortButton.Text, sortedArr);
            F2.Show();
            SortMethods.sortLog = "";
        }

        private void PiramidalSortButton_Click(object sender, EventArgs e)
        {
            InitArr();
            if (Arr.Length == 0)
            {
                ErrorText.Show();
                return;
            }
            ErrorText.Hide();
            sortedArr = SortMethods.HeapSort(Arr, Arr.Length, sortDirection);
            sortLog = SortMethods.sortLog;
            F2 = new SortingForm(sortLog, PiramidalSortButton.Text, sortedArr);
            F2.Show();
            SortMethods.sortLog = "";
        }

        private void CountSortButton_Click(object sender, EventArgs e)
        {
            InitArr();
            if (Arr.Length == 0)
            {
                ErrorText.Show();
                return;
            }
            ErrorText.Hide();
            sortedArr = SortMethods.CountSort(Arr, sortDirection);
            sortLog = SortMethods.sortLog;
            F2 = new SortingForm(sortLog, CountSortButton.Text, sortedArr);
            F2.Show();
            SortMethods.sortLog = "";
        }

        private void InsertSortButton_Click(object sender, EventArgs e)
        {
            InitArr();
            if (Arr.Length == 0)
            {
                ErrorText.Show();
                return;
            }
            ErrorText.Hide();
            sortedArr = SortMethods.InsertSort(Arr, sortDirection);
            sortLog = SortMethods.sortLog;
            F2 = new SortingForm(sortLog, InsertSortButton.Text, sortedArr);
            F2.Show();
            SortMethods.sortLog = "";
        }

        private void BubbleSortButton_Click(object sender, EventArgs e)
        {
            InitArr();
            if (Arr.Length == 0)
            {
                ErrorText.Show();
                return;
            }
            ErrorText.Hide();
            sortedArr = SortMethods.BubbleSort(Arr, sortDirection);
            sortLog = SortMethods.sortLog;
            F2 = new SortingForm(sortLog, BubbleSortButton.Text, sortedArr);
            F2.Show();
            SortMethods.sortLog = "";
        }
    }
}