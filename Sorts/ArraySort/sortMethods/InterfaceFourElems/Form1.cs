using FourElemsSort;
using static FourElemsSort.FourElemsSor;
using ResF;

namespace InterfaceFourElems
{
    public partial class Form1 : Form
    {
        int N;
        TextBox[] TX;
        ComboBox[] CB;
        ComboBox[] OrderCB;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (TX != null && CB!=null )
                for (int i = 0; i < N; i++)
                {
                    Controls.Remove(TX[i]);
                    Controls.Remove(CB[i]);
                }
            try
            {
                N = int.Parse(txBx_NumOfElems.Text);
            } catch(Exception)
            {
                errorProvider1.SetError(txBx_NumOfElems, "��������������� ����!");
                return;
            }
            TX = new TextBox[N];
            CB = new ComboBox[N];
            
            for (int i = 0; i < N; i++)
            {
                TX[i] = new TextBox();
                TX[i].Location = new System.Drawing.Point(100 + i * 85, 150);
                TX[i].Size = new System.Drawing.Size(75, 50);
                Controls.Add(TX[i]);

                CB[i] = new ComboBox();
                CB[i].Location = new System.Drawing.Point(100 + i * 85, 200);
                CB[i].Size = new System.Drawing.Size(75, 50);
                CB[i].Items.Add("�������");
                CB[i].Items.Add("�����");
                CB[i].Items.Add("�������");
                CB[i].Items.Add("�����");
                Controls.Add(CB[i]);
            }
            OrderCB = new ComboBox[4];
            for (int i = 0; i< (N > 4 ? 4 : N); i++)
            {
                OrderCB[i] = new ComboBox();
                OrderCB[i].Location = new System.Drawing.Point(325 + i * 85, 360);
                OrderCB[i].Size = new System.Drawing.Size(75, 50);
                OrderCB[i].Items.Add("�������");
                OrderCB[i].Items.Add("�����");
                OrderCB[i].Items.Add("�������");
                OrderCB[i].Items.Add("�����");
                Controls.Add(OrderCB[i]);
            }

            bt_SortIt.Visible = true;
        }

        private void bt_SortIt_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            (int, FourElemsSor.Colors)[] res = new (int, FourElemsSor.Colors)[N];
            FourElemsSor.Colors[] Order = new FourElemsSor.Colors[(N > 4 ? 4 : N)];
            for (int i = 0; i<N; i++)
            {
                try
                {
                    res[i].Item1 = int.Parse(TX[i].Text);
                } catch(Exception)
                {
                    errorProvider1.SetError(TX[i], "��������������� ����!");
                }
                switch(CB[i].Text)
                {
                    case "�������":
                        res[i].Item2 = Colors.Red;
                        continue;
                    case "�����":
                        res[i].Item2 = Colors.White;
                        continue;
                    case "�������":
                        res[i].Item2 = Colors.Green;
                        continue;
                    case "�����":
                        res[i].Item2 = Colors.Blue;
                        continue;
                    default:
                        errorProvider1.SetError(CB[i], "���������� ��������� ����!");
                        return;
                }
            }

            for (int i = 0; i< (N>4? 4: N); i++)
            {
                switch (OrderCB[i].Text)
                {
                    case "�������":
                        Order[i] = Colors.Red;
                        continue;
                    case "�����":
                        Order[i] = Colors.White;
                        continue;
                    case "�������":
                        Order[i] = Colors.Green;
                        continue;
                    case "�����":
                        Order[i] = Colors.Blue;
                        continue;
                    default:
                        errorProvider1.SetError(OrderCB[i], "���������� ��������� ����!");
                        return;
                }
            }

            for (int i = 0; i< (N>4? 4: N); i++) {
                for (int j =i + 1; j < (N > 4 ? 4 : N); j++)
                {
                    if (OrderCB[j].Text == OrderCB[i].Text)
                    {
                        errorProvider1.SetError(OrderCB[j], $"����������� ���������� ������ � �������");
                        return;
                    }

                }
            }

            for (int i = 0; i < N; i++)
            {
                bool found = false;
                for (int j = 0; j< (N > 4 ? 4 : N); j++)
                {
                    if (CB[i].Text == OrderCB[j].Text)
                    {
                        found = true;
                        break;
                    }

                }
                if (!found)
                {
                    errorProvider1.SetError(CB[i], $"������ ���� ����������� � �������, �� ����������� � " +
                        $"��������� �������!");
                    return;
                }
            }

            for (int i = 0; i < (N > 4 ? 4 : N); i++)
            {
                bool found = false;
                for (int j = 0; j < N; j++)
                {
                    if (CB[j].Text == OrderCB[i].Text)
                    {
                        found = true;
                        break;
                    }

                }
                if (!found)
                {
                    errorProvider1.SetError(CB[i], $"������ ���� ����������� � ���������� �������, �� ����������� � " +
                        $"������� !");
                    return;
                }
            }


            res = FourElemsSor.Sorting(res, Order);

            ResFForm form = new ResFForm(res);
            form.Show();


        }
    }
}