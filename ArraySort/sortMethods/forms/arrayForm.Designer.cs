namespace forms
{
    partial class arrayForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.chBoxManual = new System.Windows.Forms.CheckBox();
            this.cmBxMetSort = new System.Windows.Forms.ComboBox();
            this.buttonFilePath = new System.Windows.Forms.Button();
            this.textBoxManual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmBxWaySort = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelDelimiter = new System.Windows.Forms.Label();
            this.txBxDelimiter = new System.Windows.Forms.TextBox();
            this.labelDelInfo = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_Bx_rnd_LBound = new System.Windows.Forms.TextBox();
            this.tx_Bx_rnd_UBound = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_Bx_rnd_N = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_FillRndArr = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(130, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сортировка массивов";
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStart.Location = new System.Drawing.Point(66, 226);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(494, 52);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Отсортировать";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // chBoxManual
            // 
            this.chBoxManual.AutoSize = true;
            this.chBoxManual.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chBoxManual.Location = new System.Drawing.Point(8, 77);
            this.chBoxManual.Name = "chBoxManual";
            this.chBoxManual.Size = new System.Drawing.Size(179, 23);
            this.chBoxManual.TabIndex = 2;
            this.chBoxManual.Text = "Задать массив вручную";
            this.chBoxManual.UseVisualStyleBackColor = true;
            this.chBoxManual.CheckedChanged += new System.EventHandler(this.chBoxManual_CheckedChanged);
            // 
            // cmBxMetSort
            // 
            this.cmBxMetSort.FormattingEnabled = true;
            this.cmBxMetSort.Items.AddRange(new object[] {
            "1.Быстрая",
            "2.Слияние",
            "3.Пирамидальная",
            "4.Пузырьковая",
            "5.Вставками",
            "6.Подсчетом",
            "7.Bogo Sort"});
            this.cmBxMetSort.Location = new System.Drawing.Point(209, 172);
            this.cmBxMetSort.Name = "cmBxMetSort";
            this.cmBxMetSort.Size = new System.Drawing.Size(393, 23);
            this.cmBxMetSort.TabIndex = 4;
            // 
            // buttonFilePath
            // 
            this.buttonFilePath.Location = new System.Drawing.Point(224, 75);
            this.buttonFilePath.Name = "buttonFilePath";
            this.buttonFilePath.Size = new System.Drawing.Size(153, 23);
            this.buttonFilePath.TabIndex = 5;
            this.buttonFilePath.Text = "Выбрать файл";
            this.buttonFilePath.UseVisualStyleBackColor = true;
            this.buttonFilePath.Click += new System.EventHandler(this.buttonFilePath_Click);
            // 
            // textBoxManual
            // 
            this.textBoxManual.Location = new System.Drawing.Point(12, 48);
            this.textBoxManual.Name = "textBoxManual";
            this.textBoxManual.ReadOnly = true;
            this.textBoxManual.Size = new System.Drawing.Size(590, 23);
            this.textBoxManual.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Способ сортировки:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Направление сортировки:";
            // 
            // cmBxWaySort
            // 
            this.cmBxWaySort.FormattingEnabled = true;
            this.cmBxWaySort.Items.AddRange(new object[] {
            "1.Возрастание",
            "2.Убывание"});
            this.cmBxWaySort.Location = new System.Drawing.Point(260, 199);
            this.cmBxWaySort.Name = "cmBxWaySort";
            this.cmBxWaySort.Size = new System.Drawing.Size(343, 23);
            this.cmBxWaySort.TabIndex = 10;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelDelimiter
            // 
            this.labelDelimiter.AutoSize = true;
            this.labelDelimiter.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDelimiter.Location = new System.Drawing.Point(224, 75);
            this.labelDelimiter.Name = "labelDelimiter";
            this.labelDelimiter.Size = new System.Drawing.Size(121, 22);
            this.labelDelimiter.TabIndex = 11;
            this.labelDelimiter.Text = "Разделитель:";
            this.labelDelimiter.Visible = false;
            // 
            // txBxDelimiter
            // 
            this.txBxDelimiter.Location = new System.Drawing.Point(350, 75);
            this.txBxDelimiter.Name = "txBxDelimiter";
            this.txBxDelimiter.Size = new System.Drawing.Size(28, 23);
            this.txBxDelimiter.TabIndex = 12;
            this.txBxDelimiter.Visible = false;
            // 
            // labelDelInfo
            // 
            this.labelDelInfo.AutoSize = true;
            this.labelDelInfo.Location = new System.Drawing.Point(382, 75);
            this.labelDelInfo.Name = "labelDelInfo";
            this.labelDelInfo.Size = new System.Drawing.Size(111, 30);
            this.labelDelInfo.TabIndex = 13;
            this.labelDelInfo.Text = "Оставить пустым\r\nесли через пробел";
            this.labelDelInfo.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(8, 113);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(284, 23);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Заполнить массив случайными числами";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(8, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Нижняя граница";
            this.label4.Visible = false;
            // 
            // tx_Bx_rnd_LBound
            // 
            this.tx_Bx_rnd_LBound.Location = new System.Drawing.Point(146, 143);
            this.tx_Bx_rnd_LBound.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_Bx_rnd_LBound.Name = "tx_Bx_rnd_LBound";
            this.tx_Bx_rnd_LBound.Size = new System.Drawing.Size(33, 23);
            this.tx_Bx_rnd_LBound.TabIndex = 16;
            this.tx_Bx_rnd_LBound.Visible = false;
            // 
            // tx_Bx_rnd_UBound
            // 
            this.tx_Bx_rnd_UBound.Location = new System.Drawing.Point(349, 143);
            this.tx_Bx_rnd_UBound.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_Bx_rnd_UBound.Name = "tx_Bx_rnd_UBound";
            this.tx_Bx_rnd_UBound.Size = new System.Drawing.Size(33, 23);
            this.tx_Bx_rnd_UBound.TabIndex = 18;
            this.tx_Bx_rnd_UBound.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(209, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Верхняя граница";
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tx_Bx_rnd_N
            // 
            this.tx_Bx_rnd_N.Location = new System.Drawing.Point(550, 146);
            this.tx_Bx_rnd_N.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_Bx_rnd_N.Name = "tx_Bx_rnd_N";
            this.tx_Bx_rnd_N.Size = new System.Drawing.Size(33, 23);
            this.tx_Bx_rnd_N.TabIndex = 20;
            this.tx_Bx_rnd_N.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(410, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Количество чисел";
            this.label6.Visible = false;
            // 
            // btn_FillRndArr
            // 
            this.btn_FillRndArr.Location = new System.Drawing.Point(412, 111);
            this.btn_FillRndArr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_FillRndArr.Name = "btn_FillRndArr";
            this.btn_FillRndArr.Size = new System.Drawing.Size(171, 22);
            this.btn_FillRndArr.TabIndex = 21;
            this.btn_FillRndArr.Text = "Заполнить";
            this.btn_FillRndArr.UseVisualStyleBackColor = true;
            this.btn_FillRndArr.Visible = false;
            this.btn_FillRndArr.Click += new System.EventHandler(this.btn_FillRndArr_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 284);
            this.Controls.Add(this.btn_FillRndArr);
            this.Controls.Add(this.tx_Bx_rnd_N);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tx_Bx_rnd_UBound);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tx_Bx_rnd_LBound);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelDelInfo);
            this.Controls.Add(this.txBxDelimiter);
            this.Controls.Add(this.labelDelimiter);
            this.Controls.Add(this.cmBxWaySort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxManual);
            this.Controls.Add(this.buttonFilePath);
            this.Controls.Add(this.cmBxMetSort);
            this.Controls.Add(this.chBoxManual);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button buttonStart;
        private CheckBox chBoxManual;
        private ComboBox cmBxMetSort;
        private Button buttonFilePath;
        private TextBox textBoxManual;
        private Label label2;
        private Label label3;
        private ComboBox cmBxWaySort;
        private OpenFileDialog openFileDialog1;
        private Label labelDelimiter;
        private TextBox txBxDelimiter;
        private Label labelDelInfo;
        private CheckBox checkBox1;
        private Label label4;
        private TextBox tx_Bx_rnd_LBound;
        private TextBox tx_Bx_rnd_UBound;
        private Label label5;
        private TextBox tx_Bx_rnd_N;
        private Label label6;
        private Button btn_FillRndArr;
        private ErrorProvider errorProvider1;
    }
}