using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoForm
{
    public partial class InfoForm1 : Form
    {
        public InfoForm1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            infoTxBx.Text = "В первой строке вводимого файла находится последовательность нулей и единиц,\r\nобозначающих направление сортировки в соответсвующем столбце,\r\nгде 0 - по убыванию, 1 - по возрастанию.\r\nДалее следует произвольное количество строк, содержащих такое же количество элементов,\r\nкаково оно в первой строке. \r\nЭлементы полученного массива должны быть разделены пробелом.\r\nЛюбое отступление от такого формата является ошибкой форматирования,\r\nтакие входные данные некорректы и обрабатываться не будут.";
        }
    }
}
