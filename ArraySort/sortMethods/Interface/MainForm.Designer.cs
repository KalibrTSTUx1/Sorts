namespace Interface
{
    partial class MainForm
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
            this.labelSortDirect = new System.Windows.Forms.Label();
            this.butSelectUpDir = new System.Windows.Forms.Button();
            this.butSelectDownDir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.arrayBox = new System.Windows.Forms.TextBox();
            this.FastSortButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MergeSortButton = new System.Windows.Forms.Button();
            this.PiramidalSortButton = new System.Windows.Forms.Button();
            this.ErrorText = new System.Windows.Forms.Label();
            this.CountSortButton = new System.Windows.Forms.Button();
            this.InsertSortButton = new System.Windows.Forms.Button();
            this.BubbleSortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSortDirect
            // 
            this.labelSortDirect.AutoSize = true;
            this.labelSortDirect.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSortDirect.Location = new System.Drawing.Point(12, 395);
            this.labelSortDirect.Name = "labelSortDirect";
            this.labelSortDirect.Size = new System.Drawing.Size(325, 35);
            this.labelSortDirect.TabIndex = 0;
            this.labelSortDirect.Text = "Направление сортировки: ";
            // 
            // butSelectUpDir
            // 
            this.butSelectUpDir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.butSelectUpDir.Location = new System.Drawing.Point(343, 395);
            this.butSelectUpDir.Name = "butSelectUpDir";
            this.butSelectUpDir.Size = new System.Drawing.Size(203, 35);
            this.butSelectUpDir.TabIndex = 1;
            this.butSelectUpDir.Text = "По возрастанию";
            this.butSelectUpDir.UseVisualStyleBackColor = true;
            this.butSelectUpDir.Click += new System.EventHandler(this.butSelectUpDir_Click);
            // 
            // butSelectDownDir
            // 
            this.butSelectDownDir.ForeColor = System.Drawing.Color.Blue;
            this.butSelectDownDir.Location = new System.Drawing.Point(585, 395);
            this.butSelectDownDir.Name = "butSelectDownDir";
            this.butSelectDownDir.Size = new System.Drawing.Size(203, 35);
            this.butSelectDownDir.TabIndex = 2;
            this.butSelectDownDir.Text = "По убыванию";
            this.butSelectDownDir.UseVisualStyleBackColor = true;
            this.butSelectDownDir.Click += new System.EventHandler(this.butSelectDownDir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Массив: ";
            // 
            // arrayBox
            // 
            this.arrayBox.Location = new System.Drawing.Point(132, 82);
            this.arrayBox.Name = "arrayBox";
            this.arrayBox.PlaceholderText = "Числа вводите через точку с запятой";
            this.arrayBox.Size = new System.Drawing.Size(626, 27);
            this.arrayBox.TabIndex = 4;
            // 
            // FastSortButton
            // 
            this.FastSortButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FastSortButton.Location = new System.Drawing.Point(31, 131);
            this.FastSortButton.Name = "FastSortButton";
            this.FastSortButton.Size = new System.Drawing.Size(306, 43);
            this.FastSortButton.TabIndex = 6;
            this.FastSortButton.Text = "Быстрая сортировка";
            this.FastSortButton.UseVisualStyleBackColor = true;
            this.FastSortButton.Click += new System.EventHandler(this.FastSortButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 46);
            this.label2.TabIndex = 7;
            this.label2.Text = "Методы сортировок";
            // 
            // MergeSortButton
            // 
            this.MergeSortButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MergeSortButton.Location = new System.Drawing.Point(31, 216);
            this.MergeSortButton.Name = "MergeSortButton";
            this.MergeSortButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MergeSortButton.Size = new System.Drawing.Size(306, 43);
            this.MergeSortButton.TabIndex = 8;
            this.MergeSortButton.Text = "Сортировка слиянием";
            this.MergeSortButton.UseVisualStyleBackColor = true;
            this.MergeSortButton.Click += new System.EventHandler(this.MergeSortButton_Click);
            // 
            // PiramidalSortButton
            // 
            this.PiramidalSortButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PiramidalSortButton.Location = new System.Drawing.Point(31, 307);
            this.PiramidalSortButton.Name = "PiramidalSortButton";
            this.PiramidalSortButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PiramidalSortButton.Size = new System.Drawing.Size(306, 43);
            this.PiramidalSortButton.TabIndex = 9;
            this.PiramidalSortButton.Text = "Пирамидальная сортировка";
            this.PiramidalSortButton.UseVisualStyleBackColor = true;
            this.PiramidalSortButton.Click += new System.EventHandler(this.PiramidalSortButton_Click);
            // 
            // ErrorText
            // 
            this.ErrorText.AutoSize = true;
            this.ErrorText.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ErrorText.ForeColor = System.Drawing.Color.Red;
            this.ErrorText.Location = new System.Drawing.Point(394, 25);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(357, 35);
            this.ErrorText.TabIndex = 10;
            this.ErrorText.Text = "Некорректный ввод массива!";
            // 
            // CountSortButton
            // 
            this.CountSortButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CountSortButton.Location = new System.Drawing.Point(452, 131);
            this.CountSortButton.Name = "CountSortButton";
            this.CountSortButton.Size = new System.Drawing.Size(306, 43);
            this.CountSortButton.TabIndex = 11;
            this.CountSortButton.Text = "Сортировка подсчетом";
            this.CountSortButton.UseVisualStyleBackColor = true;
            this.CountSortButton.Click += new System.EventHandler(this.CountSortButton_Click);
            // 
            // InsertSortButton
            // 
            this.InsertSortButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InsertSortButton.Location = new System.Drawing.Point(452, 216);
            this.InsertSortButton.Name = "InsertSortButton";
            this.InsertSortButton.Size = new System.Drawing.Size(306, 43);
            this.InsertSortButton.TabIndex = 12;
            this.InsertSortButton.Text = "Сортировка вставками";
            this.InsertSortButton.UseVisualStyleBackColor = true;
            this.InsertSortButton.Click += new System.EventHandler(this.InsertSortButton_Click);
            // 
            // BubbleSortButton
            // 
            this.BubbleSortButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BubbleSortButton.Location = new System.Drawing.Point(452, 307);
            this.BubbleSortButton.Name = "BubbleSortButton";
            this.BubbleSortButton.Size = new System.Drawing.Size(306, 43);
            this.BubbleSortButton.TabIndex = 13;
            this.BubbleSortButton.Text = "Пузырьковая сортировка";
            this.BubbleSortButton.UseVisualStyleBackColor = true;
            this.BubbleSortButton.Click += new System.EventHandler(this.BubbleSortButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BubbleSortButton);
            this.Controls.Add(this.InsertSortButton);
            this.Controls.Add(this.CountSortButton);
            this.Controls.Add(this.ErrorText);
            this.Controls.Add(this.PiramidalSortButton);
            this.Controls.Add(this.MergeSortButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FastSortButton);
            this.Controls.Add(this.arrayBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butSelectDownDir);
            this.Controls.Add(this.butSelectUpDir);
            this.Controls.Add(this.labelSortDirect);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelSortDirect;
        private Button butSelectUpDir;
        private Button butSelectDownDir;
        private Label label1;
        private TextBox arrayBox;
        private Button FastSortButton;
        private Label label2;
        private Button MergeSortButton;
        private Button PiramidalSortButton;
        private Label ErrorText;
        private Button CountSortButton;
        private Button InsertSortButton;
        private Button BubbleSortButton;
    }
}