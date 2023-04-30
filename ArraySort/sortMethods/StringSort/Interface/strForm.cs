using WinFormsApp1;

namespace Interface
{
    public partial class strForm : Form
    {
        string[] fileInfo;
        string path;
        public strForm()
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
                    fileInfo = null;
                    fileInfo = fileHand.ReadFile(inputPath.Text);
                }
                if ( fileInfo!= null && !fileHand.IsCorrectFormated(fileInfo))
                {
                    throw new Exception("Файл не в корректном формате!");
                }
                FileOpenSuc.Visible = true;
            } catch (Exception ex)
            {
                errorProvider1.SetError(OpenFileIn, ex.Message);
            }

        }

        private void OpenFileOut_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            FileOutSuc.Visible = false;
            if (!manOutput.Checked)
            {
                if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
                {
                    path = openFileDialog1.FileName;
                    OutputPath.Text = path;
                }
            } else
            {
                path = OutputPath.Text;
            }


            Stream F;
            try
            {
                F = File.OpenRead(path);
                if (F.CanRead)
                    FileOutSuc.Visible = true;
                F.Close(); F.Dispose(); 
            } 
            catch { errorProvider1.SetError(OpenFileOut, "Файл не найден!"); }
            finally { F = null; }
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            try
            {
                fileInfo = fileHand.ReadFile(inputPath.Text);
                if (fileInfo != null && !fileHand.IsCorrectFormated(fileInfo))
                    throw new Exception("Файл не в корректном формате!");   
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(OpenFileIn, ex.Message);
            }
            errorProvider1.Clear();
            if (fileInfo ==  null)
            {
                errorProvider1.SetError(mainButton, "Нет данных!");
                return;
            }
            EntryPoint enP = new(fileInfo, Convert.ToInt32(dirAsc.Checked));
            try
            {
                fileHand.WriteFile(path, enP.ReturnRes());
            } 
            catch (Exception ex)
            {
                errorProvider1.SetError(OpenFileOut, ex.Message);
            }
            if (ShowResInForm.Checked)
            {
                OutPutForm F = new(enP.ReturnRes());
                F.Show();
            }
        }

        private void manOutput_CheckedChanged(object sender, EventArgs e)
        {
            OutputPath.Enabled = manOutput.Checked;

        }

        private void dirAsc_CheckedChanged(object sender, EventArgs e)
        {
            dirDec.Checked = !dirAsc.Checked;
        }

        private void dirDec_CheckedChanged(object sender, EventArgs e)
        {
            dirAsc.Checked = !dirDec.Checked;
        }
    }
}