namespace WinFormsApp1
{
    public partial class OutPutForm : Form
    {
        public OutPutForm(string[] text)
        {
            InitializeComponent();
            foreach (string s in text)
                textBox1.Text += s;
        }
    }
}