using forms;
using Interface;
using Project;
using InterfaceFourElems;

namespace blankSolution
{
    public partial class blankSolutionForm : Form
    {
        public blankSolutionForm()
        {
            InitializeComponent();
        }

        private void bt_ArraySort_Click(object sender, EventArgs e)
        {
            arrayForm form = new();
            form.Show();
        }

        private void bt_StringSort_Click(object sender, EventArgs e)
        {
            strForm form = new();
            form.Show();
        }

        private void bt_TSort_Click(object sender, EventArgs e)
        {
            graphForm form = new();
            form.Show();
        }

        private void bt_PSort_Click(object sender, EventArgs e)
        {
            parralelSort form = new();
            form.Show();
        }

        private void btn_FourElemsSort_Click(object sender, EventArgs e)
        {
            Form1 form = new();
            form.Show();
        }
    }
}