using TextResForm;
using InfoForm;
using ManualInput;

namespace Project
{
    public partial class parralelSort : Form
    {
        private string filePath;
        ManualInputForm F;
        string typeOfInput;
        public parralelSort()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            typeOfInput = "file";
            errorProvider1.Clear();
            filePath = string.Empty;
            if (openFileDialog1.ShowDialog() == DialogResult.OK) { filePath = openFileDialog1.FileName; }
            txBx_InpPath.Text = filePath;
            
        }

        private void button_OutPath_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            filePath = string.Empty;
            if (openFileDialog1.ShowDialog() == DialogResult.OK) { filePath = openFileDialog1.FileName; }
            txBx_OutPath.Text = filePath;
        }

        private void chBx_ManualPath_CheckedChanged(object sender, EventArgs e)
        {
            if (chBx_ManualPath.Checked == true)
            {
                txBx_InpPath.ReadOnly = false;
                txBx_OutPath.ReadOnly = false;
                button_InpPath.Enabled = false;
                button_OutPath.Enabled = false;
            }
            else
            {
                txBx_InpPath.ReadOnly = true;
                txBx_OutPath.ReadOnly = true;
                button_InpPath.Enabled = true;
                button_OutPath.Enabled = true;
            }
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (typeOfInput == "manual" && F.arr != null)
            {
                entryPoint en = new entryPoint(F.arr, F.directions, txBx_OutPath.Text);
                en.startManualArr();
                if (ch_Bx_showResInForm.Checked == true)
                {
                    TextResF F = new TextResF(en.GetArr(), en.GetDirections(), en.time);
                    F.Show();
                }
            }
            if (typeOfInput == "file" || F.arr == null)
            {
                var enPoint = new entryPoint(txBx_InpPath.Text, txBx_OutPath.Text);
                var log = enPoint.start();

                if (log == 1)
                {
                    errorProvider1.SetError(txBx_InpPath, "Файл пустой!");
                    return;
                }
                else if (log == 2)
                {
                    errorProvider1.SetError(txBx_InpPath, "Неверный путь!");
                    return;
                }
                else if(log == 3)
                {
                    errorProvider1.SetError(txBx_InpPath, "Некорректный формат файла - нечисловые значения!");
                    return;
                }
                else if(log == 4)
                {
                    errorProvider1.SetError(txBx_InpPath, "Некорректный формат!");
                    return;
                }

                if (ch_Bx_showResInForm.Checked == true)
                {
                    TextResF F = new TextResF(enPoint.GetArr(),
                                              enPoint.GetDirections(),
                                              enPoint.time);
                    F.Show();
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            InfoForm1 F = new InfoForm1();
            F.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            typeOfInput = "manual";
            F = new ManualInputForm();
            F.Show();
        }
    }
}