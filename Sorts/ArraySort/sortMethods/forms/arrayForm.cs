using System.Text;

namespace forms
{
    public partial class arrayForm : Form
    {
        private string filePath;
        public int[] RndArr;
        entryPoint enPoint;
        public arrayForm()
        {
            InitializeComponent();
        }

        private void buttonFilePath_Click(object sender, EventArgs e)
        {
            filePath = string.Empty;
            if (openFileDialog1.ShowDialog() == DialogResult.OK) { filePath = openFileDialog1.FileName; }
            textBoxManual.Text = filePath;
        }

        private void chBoxManual_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxManual.Checked == true)
            {
                textBoxManual.Text = String.Empty;
                textBoxManual.ReadOnly = false;
                buttonFilePath.Visible = false;
                txBxDelimiter.Visible = true;
                labelDelimiter.Visible = true;
                labelDelInfo.Visible = true;
                checkBox1.Checked = false;
            }
            else { textBoxManual.ReadOnly = true; 
                buttonFilePath.Visible = true; 
                textBoxManual.Text = String.Empty;
                txBxDelimiter.Visible = false; 
                labelDelimiter.Visible = false; 
                labelDelInfo.Visible = false; }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (cmBxWaySort.Text != String.Empty && cmBxMetSort.Text != String.Empty)
            {
                if (chBoxManual.Checked == true)
                {
                    if (textBoxManual.Text != String.Empty)
                    {
                        enPoint = new(textBoxManual.Text, txBxDelimiter.Text, cmBxWaySort.Text, cmBxMetSort.Text);
                    }
                    else { errorProvider1.SetError(buttonStart, "Не все поля заполнены!"); }
                }
                else if (checkBox1.Checked == true)
                {
                    if (RndArr != null)
                    {
                        enPoint = new(RndArr, cmBxWaySort.Text, cmBxMetSort.Text);
                    }
                    else { errorProvider1.SetError(btn_FillRndArr, "Массив не сформирован!"); }

                }
                else
                {
                    if (textBoxManual.Text != String.Empty)
                    {
                        enPoint = new(textBoxManual.Text, cmBxWaySort.Text, cmBxMetSort.Text);
                    } else { errorProvider1.SetError(textBoxManual, "Путь к файлу не задан!"); }
                    
                }
            } else { errorProvider1.SetError(buttonStart, "Не все поля заполнены!"); }
            enPoint = null;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tx_Bx_rnd_LBound.Visible = !tx_Bx_rnd_LBound.Visible;
            tx_Bx_rnd_UBound.Visible = !tx_Bx_rnd_UBound.Visible;
            tx_Bx_rnd_N.Visible = !tx_Bx_rnd_N.Visible;
            btn_FillRndArr.Visible = !btn_FillRndArr.Visible;
            label4.Visible = !label4.Visible;
            label5.Visible = !label5.Visible;
            label6.Visible = !label6.Visible;
            if (checkBox1.Checked)
            {
                chBoxManual.Checked = false;
                buttonFilePath.Visible = false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_FillRndArr_Click(object sender, EventArgs e)
        {
            RndArr = null;
            textBoxManual.Clear();
            try
            {
                RndArr = sortMethods.SortMethods.RandomFill(
                    int.Parse(tx_Bx_rnd_N.Text),
                    int.Parse(tx_Bx_rnd_LBound.Text),
                    int.Parse(tx_Bx_rnd_UBound.Text));
                arrayWrite(RndArr);
            }
            catch (Exception)
            {
                allClear();
                errorProvider1.SetError(btn_FillRndArr, "Неверно заполненны значения");
            }
            
        }
        private void arrayWrite(int[] array)
        {
            string arrayStrFormat = String.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                string elem = array[i].ToString();
                arrayStrFormat += elem;
                if (arrayStrFormat.Length >= 108)
                {
                    StringBuilder sb = new StringBuilder(arrayStrFormat);
                    sb.Remove(arrayStrFormat.Length - elem.Length, elem.Length);
                    sb.Append("...");
                    textBoxManual.Text = sb.ToString();
                    return;
                }
                arrayStrFormat += " ";
            }
            textBoxManual.Text = arrayStrFormat;
            
        }
        private void allClear()
        {
            textBoxManual.Clear();
            tx_Bx_rnd_LBound.Clear();
            tx_Bx_rnd_N.Clear();
            tx_Bx_rnd_UBound.Clear();
            errorProvider1.Clear();
        }
    }
}