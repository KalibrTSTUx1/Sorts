using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextResForm
{
    public partial class TextResF : Form
    {
        public TextResF(int[,] SortRes, int[] directions, double time)
        {
            InitializeComponent();
            string resSortText = "";
            string arrows = "";

            for (int i = 0; i< directions.Length;i++)
            {
                if (directions[i] == 0)
                {
                    arrows += "     ↓";
                } else
                {
                    arrows += "     ↑";
                }
            }
            arrows += "\r\n";

            for (int i = 0; i < SortRes.GetLength(0); i++)
            {
                for (int j = 0; j < SortRes.GetLength(1); j++)
                {
                    resSortText += $"{SortRes[i, j], 5}";
                }
                resSortText += "\r\n";
            }

            resForm.Text = resSortText;
            resForm.Text += arrows;
            txBxTime.Text = Convert.ToString(time);
        }
    }
}
