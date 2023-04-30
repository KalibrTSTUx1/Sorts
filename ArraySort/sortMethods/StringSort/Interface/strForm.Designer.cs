namespace Interface
{
    partial class strForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.manInput = new System.Windows.Forms.CheckBox();
            this.inputPath = new System.Windows.Forms.TextBox();
            this.OpenFileIn = new System.Windows.Forms.Button();
            this.OpenFileOut = new System.Windows.Forms.Button();
            this.OutputPath = new System.Windows.Forms.TextBox();
            this.manOutput = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mainButton = new System.Windows.Forms.Button();
            this.ShowResInForm = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dirAsc = new System.Windows.Forms.CheckBox();
            this.dirDec = new System.Windows.Forms.CheckBox();
            this.FileOpenSuc = new System.Windows.Forms.Label();
            this.FileOutSuc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сортировка строк";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Входной файл";
            // 
            // manInput
            // 
            this.manInput.AutoSize = true;
            this.manInput.Checked = true;
            this.manInput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.manInput.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.manInput.Location = new System.Drawing.Point(214, 71);
            this.manInput.Name = "manInput";
            this.manInput.Size = new System.Drawing.Size(171, 24);
            this.manInput.TabIndex = 2;
            this.manInput.Text = "Ручной ввод пути";
            this.manInput.UseVisualStyleBackColor = true;
            this.manInput.CheckedChanged += new System.EventHandler(this.manInput_CheckedChanged);
            // 
            // inputPath
            // 
            this.inputPath.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputPath.Location = new System.Drawing.Point(21, 111);
            this.inputPath.Name = "inputPath";
            this.inputPath.Size = new System.Drawing.Size(606, 34);
            this.inputPath.TabIndex = 3;
            // 
            // OpenFileIn
            // 
            this.OpenFileIn.Location = new System.Drawing.Point(633, 111);
            this.OpenFileIn.Name = "OpenFileIn";
            this.OpenFileIn.Size = new System.Drawing.Size(126, 34);
            this.OpenFileIn.TabIndex = 4;
            this.OpenFileIn.Text = "Открыть файл";
            this.OpenFileIn.UseVisualStyleBackColor = true;
            this.OpenFileIn.Click += new System.EventHandler(this.OpenFileIn_Click);
            // 
            // OpenFileOut
            // 
            this.OpenFileOut.Location = new System.Drawing.Point(633, 228);
            this.OpenFileOut.Name = "OpenFileOut";
            this.OpenFileOut.Size = new System.Drawing.Size(126, 34);
            this.OpenFileOut.TabIndex = 8;
            this.OpenFileOut.Text = "Открыть файл";
            this.OpenFileOut.UseVisualStyleBackColor = true;
            this.OpenFileOut.Click += new System.EventHandler(this.OpenFileOut_Click);
            // 
            // OutputPath
            // 
            this.OutputPath.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputPath.Location = new System.Drawing.Point(21, 228);
            this.OutputPath.Name = "OutputPath";
            this.OutputPath.Size = new System.Drawing.Size(606, 34);
            this.OutputPath.TabIndex = 7;
            // 
            // manOutput
            // 
            this.manOutput.AutoSize = true;
            this.manOutput.Checked = true;
            this.manOutput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.manOutput.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.manOutput.Location = new System.Drawing.Point(214, 188);
            this.manOutput.Name = "manOutput";
            this.manOutput.Size = new System.Drawing.Size(171, 24);
            this.manOutput.TabIndex = 6;
            this.manOutput.Text = "Ручной ввод пути";
            this.manOutput.UseVisualStyleBackColor = true;
            this.manOutput.CheckedChanged += new System.EventHandler(this.manOutput_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Выходной файл";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // mainButton
            // 
            this.mainButton.Location = new System.Drawing.Point(21, 313);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(194, 41);
            this.mainButton.TabIndex = 9;
            this.mainButton.Text = "Отсортировать!";
            this.mainButton.UseVisualStyleBackColor = true;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // ShowResInForm
            // 
            this.ShowResInForm.AutoSize = true;
            this.ShowResInForm.Checked = true;
            this.ShowResInForm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowResInForm.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowResInForm.Location = new System.Drawing.Point(240, 322);
            this.ShowResInForm.Name = "ShowResInForm";
            this.ShowResInForm.Size = new System.Drawing.Size(246, 24);
            this.ShowResInForm.TabIndex = 10;
            this.ShowResInForm.Text = "Показать результат в форме";
            this.ShowResInForm.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(21, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Направление";
            // 
            // dirAsc
            // 
            this.dirAsc.AutoSize = true;
            this.dirAsc.Checked = true;
            this.dirAsc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dirAsc.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dirAsc.Location = new System.Drawing.Point(214, 399);
            this.dirAsc.Name = "dirAsc";
            this.dirAsc.Size = new System.Drawing.Size(157, 24);
            this.dirAsc.TabIndex = 12;
            this.dirAsc.Text = "По возрастанию";
            this.dirAsc.UseVisualStyleBackColor = true;
            this.dirAsc.CheckedChanged += new System.EventHandler(this.dirAsc_CheckedChanged);
            // 
            // dirDec
            // 
            this.dirDec.AutoSize = true;
            this.dirDec.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dirDec.Location = new System.Drawing.Point(433, 399);
            this.dirDec.Name = "dirDec";
            this.dirDec.Size = new System.Drawing.Size(138, 24);
            this.dirDec.TabIndex = 13;
            this.dirDec.Text = "По убыванию";
            this.dirDec.UseVisualStyleBackColor = true;
            this.dirDec.CheckedChanged += new System.EventHandler(this.dirDec_CheckedChanged);
            // 
            // FileOpenSuc
            // 
            this.FileOpenSuc.AutoSize = true;
            this.FileOpenSuc.Location = new System.Drawing.Point(530, 76);
            this.FileOpenSuc.Name = "FileOpenSuc";
            this.FileOpenSuc.Size = new System.Drawing.Size(229, 20);
            this.FileOpenSuc.TabIndex = 14;
            this.FileOpenSuc.Text = "Входной файл открыт успешно!";
            this.FileOpenSuc.Visible = false;
            // 
            // FileOutSuc
            // 
            this.FileOutSuc.AutoSize = true;
            this.FileOutSuc.Location = new System.Drawing.Point(519, 192);
            this.FileOutSuc.Name = "FileOutSuc";
            this.FileOutSuc.Size = new System.Drawing.Size(240, 20);
            this.FileOutSuc.TabIndex = 15;
            this.FileOutSuc.Text = "Выходной файл открыт успешно!";
            this.FileOutSuc.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FileOutSuc);
            this.Controls.Add(this.FileOpenSuc);
            this.Controls.Add(this.dirDec);
            this.Controls.Add(this.dirAsc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ShowResInForm);
            this.Controls.Add(this.mainButton);
            this.Controls.Add(this.OpenFileOut);
            this.Controls.Add(this.OutputPath);
            this.Controls.Add(this.manOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OpenFileIn);
            this.Controls.Add(this.inputPath);
            this.Controls.Add(this.manInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private CheckBox manInput;
        private TextBox inputPath;
        private Button OpenFileIn;
        private Button OpenFileOut;
        private TextBox OutputPath;
        private CheckBox manOutput;
        private Label label3;
        private ErrorProvider errorProvider1;
        private Button mainButton;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private CheckBox ShowResInForm;
        private CheckBox dirDec;
        private CheckBox dirAsc;
        private Label label4;
        private Label FileOutSuc;
        private Label FileOpenSuc;
    }
}