using FourElemsSort;
using static FourElemsSort.FourElemsSor;

namespace ResF
{
    public partial class ResFForm : Form
    {
        private (int, FourElemsSor.Colors)[] arr;
        public ResFForm((int, Colors)[] N)
        {
            this.arr = N;

            TextBox[]TX = new TextBox[arr.Length];
            TextBox[]CB = new TextBox[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                TX[i] = new TextBox();
                TX[i].Location = new System.Drawing.Point(20 + i * 85, 50);
                TX[i].Size = new System.Drawing.Size(75, 50);
                TX[i].Text = arr[i].Item1.ToString();
                Controls.Add(TX[i]);

                CB[i] = new TextBox();
                CB[i].Location = new System.Drawing.Point(20 + i * 85, 100);
                CB[i].Size = new System.Drawing.Size(75, 50);
                switch (arr[i].Item2)
                {
                    case FourElemsSor.Colors.Red:
                        CB[i].Text = "Красный";
                        Controls.Add(CB[i]);
                        continue;
                    case FourElemsSor.Colors.White:
                        CB[i].Text = "Белый";
                        Controls.Add(CB[i]);
                        continue;
                    case FourElemsSor.Colors.Green:
                        CB[i].Text = "Зеленый";
                        Controls.Add(CB[i]);
                        continue;
                    case FourElemsSor.Colors.Blue:
                        CB[i].Text = "Синий";
                        Controls.Add(CB[i]);
                        continue;
                }

            }

            InitializeComponent();
        }




    }
}