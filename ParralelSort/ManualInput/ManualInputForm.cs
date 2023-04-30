using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManualInput
{
    public partial class ManualInputForm : Form
    {
        private int Rows, Cols;
        private TextBox[,] tb;
        public int[] directions;
        public int[,] arr;
        public ManualInputForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (tb == null)
            {
                errorProvider1.SetError(btn_generateTable, "Массив не создан!");
                return;
            }
            directions = new int[Cols];
            arr = new int[Rows - 1, Cols];
            int i = 0, j = 0;
            try
            {
                for (j = 0; j < Cols; j++)
                {
                    directions[j] = int.Parse(tb[0, j].Text);
                    if (directions[j] < 0 || directions[j] > 1)
                    {
                        throw new Exception("Некорректное направление - либо 0 либо 1!");
                    }
                }
                for (i = 1; i < Rows; i++)
                {
                    for (j = 0; j < Cols; j++)
                    {
                        arr[i - 1, j] = int.Parse(tb[i, j].Text);
                    }
                }
            } catch (Exception ex)
            {
                if (ex.Message != null)
                {
                    errorProvider1.SetError(tb[i, j], ex.Message);
                } else
                {
                    errorProvider1.SetError(tb[i, j], "Нечисленный ввод!");
                }
                arr = null;
                return;
            }

        }

        private void btnRndFill_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (tb == null)
            {
                errorProvider1.SetError(btnRndFill, "Матрица не создана!");
                return;
            }
            directions = new int[Cols];
            arr = new int[Rows - 1, Cols];
            Random R = new Random();
            for (int j = 0; j < Cols; j++)
            {
                int num = R.Next(0,2);
                tb[0, j].Text = num.ToString();
                directions[j] = num;
            }
            for (int i = 0; i < Rows-1; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    int num = R.Next(-100, 100);
                    tb[i+1, j].Text = num.ToString();
                    arr[i, j] = num;
                }
            }

        }

        private void btn_generateTable_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    Controls.Remove(tb[i, j]);
                }
            }

            try
            {
                Rows = int.Parse(NRows.Text);
            } catch(Exception)
            {
                errorProvider1.SetError(NRows, "Нецелочисленный ввод!");
                return;
            }
            try
            {
                Cols = int.Parse(NCols.Text);
            }
            catch (Exception)
            {
                errorProvider1.SetError(NCols, "Нецелочисленный ввод!");
                return;
            }
            tb = new TextBox[Rows, Cols];
            for (int i = 0; i < Rows ; i++)
            {
                for (int j = 0; j < Cols ; j++)
                {
                    tb[i, j] = new System.Windows.Forms.TextBox();
                    tb[i, j].Location = new System.Drawing.Point(150 + j * 60, 109 + i * 60);
                    tb[i, j].Size = new System.Drawing.Size(50, 50);
                    Controls.Add(tb[i, j]);
                }
            }
        }
    }
}
