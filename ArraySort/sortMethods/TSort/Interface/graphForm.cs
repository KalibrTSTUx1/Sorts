using System.Diagnostics;
using System.IO;
using WinFormsApp1;

namespace Interface
{
    public partial class graphForm : Form
    {
        string[] fileInfo;
        string outputP;
        public graphForm()
        {
            InitializeComponent();
        }

        private void manInput_CheckedChanged(object sender, EventArgs e)
        {
            inputPath.Enabled = manInput.Checked;
        }

        private void OpenFileIn_Click(object sender, EventArgs e)
        {
            FileOpenSuc.Visible = false;
            errorProvider1.Clear();
            try
            {
                if (!manInput.Checked)
                {
                    fileInfo = null;
                    if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
                    {
                        fileInfo = fileHand.ReadFile(openFileDialog1.FileName);
                        inputPath.Text = openFileDialog1.FileName;
                    }
                }
                else
                {
                    fileInfo = fileHand.ReadFile(inputPath.Text);
                }
                if ( fileInfo!= null && !fileHand.IsCorrectFormated(fileInfo))
                {
                    throw new Exception("Неправильный формат файла!");
                }
                FileOpenSuc.Visible = true;
            } catch (Exception ex)
            {
                errorProvider1.SetError(OpenFileIn, ex.Message);
                fileInfo = null;
            }

        }

        private void OpenFileOut_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            FileOutSuc.Visible = false;
            if (!manOutput.Checked)
            {
                if (openFileDialog2.ShowDialog(this) == DialogResult.OK)
                {
                    outputP = openFileDialog2.FileName;
                    OutputPath.Text = outputP;
                }
            } else
            {
                outputP = OutputPath.Text;
            }

            Stream F ;
            try
            {
                F = File.OpenRead(outputP);
                if (F.CanRead)
                    FileOutSuc.Visible = true;
                F.Close(); F.Dispose();
            }
            catch { errorProvider1.SetError(OpenFileOut, "Файл не найден!"); }
            finally { F = null; }
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (fileInfo == null)
            {
                errorProvider1.SetError(mainButton, "Нет данных!");
                return;
            }

            EntryPoint enP = new(fileInfo);
            string[] res = enP.ReturnRes();
            if (res == null)
            {
                errorProvider1.SetError(mainButton, "Граф зациклован, сортировка невозможна!");
                return;
            }
               

            try
            {
                fileHand.WriteFile(outputP, res);
            } 
            catch (Exception ex)
            {
                errorProvider1.SetError(OpenFileOut, ex.Message);
            }

            if (ShowResInForm.Checked)
            {
                OutPutForm F = new(res);
                F.Show();
            }

            Time.Text = enP.getTime().ToString();
        }

        private void manOutput_CheckedChanged(object sender, EventArgs e)
        {
            OutputPath.Enabled = manOutput.Checked;

        }
    }
}