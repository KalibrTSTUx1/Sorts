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

namespace forms
{
    public partial class formResult : Form
    {
        private string filePath;
        private bool SortedCorrect;
        private string lineResult;
        public formResult(string lineResult, double time, bool SortedCorrect)
        {
            InitializeComponent();
            this.lineResult = lineResult;
            arrayWrite();
            tx_Bx_time.Text = Convert.ToString(time);
            this.SortedCorrect = SortedCorrect;
        }

        private void chBxSaveFile_CheckedChanged(object sender, EventArgs e)
        {
            if (chBxSaveFile.Checked == true)
            {
                labelPathToFile.Visible = true;
                txBxPath.Visible = true;
                chBxNew.Visible = true;
                buttonChoice.Visible = true;
                buttonSave.Visible = true;
            } else { labelPathToFile.Visible = false; txBxPath.Visible = false; chBxNew.Visible = false; buttonChoice.Visible = false; buttonSave.Visible = false; }
        }

        private void chBxNew_CheckedChanged(object sender, EventArgs e)
        {
            if (chBxNew.Checked == true)
            {
                txBxPath.Text = String.Empty;
                labelNameFile.Visible = true;
                txBxName.Visible = true;
                txBxPath.ReadOnly = false;
                buttonChoice.Enabled = false;
            } else { txBxPath.Text = String.Empty; labelNameFile.Visible = false; txBxName.Visible = false; txBxPath.ReadOnly = true; buttonChoice.Enabled = true; }
        }

        private void buttonChoice_Click(object sender, EventArgs e)
        {
            if (chBxNew.Checked != true)
            {
                filePath = string.Empty;
                if (openFileDialog1.ShowDialog() == DialogResult.OK) { filePath = openFileDialog1.FileName; }
                txBxPath.Text = filePath;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (chBxNew.Checked != true)
            {
                fileHandler.fileChange(txBxPath.Text, lineResult);
            }
            else
            {
                fileHandler.fileGeneration(txBxPath.Text, txBxName.Text, lineResult);
            }
        }

        private void txBxPath_TextChanged(object sender, EventArgs e)
        {
            if (txBxPath.Text != String.Empty)
            {
                buttonSave.Enabled = true;
            } else { buttonSave.Enabled = false; }

        }

        private void btn_CheckSortCorrected_Click(object sender, EventArgs e)
        {
            lbl_SortCorrection.Visible = true;
            if (SortedCorrect)
            {
                lbl_SortCorrection.Text = "Отсортировано корректно";
            } else
            {
                lbl_SortCorrection.Text = "Отсортировано некорректно";
            }
        }

        private void arrayWrite()
        {
            string[] arrayRes = lineResult.Split(" ");
            string arrayStrFormat = String.Empty;
            for (int i = 0; i < arrayRes.Length; i++)
            {
                string elem = arrayRes[i];
                arrayStrFormat += elem;
                if (arrayStrFormat.Length >= 90)
                {
                    StringBuilder sb = new StringBuilder(arrayStrFormat);
                    sb.Remove(arrayStrFormat.Length - elem.Length, elem.Length);
                    sb.Append("...");
                    txBxResult.Text = sb.ToString();
                    return;
                }
                arrayStrFormat += " ";
            }
            txBxResult.Text = arrayStrFormat;

        }
    }
}
