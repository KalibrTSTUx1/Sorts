namespace blankSolution
{
    partial class blankSolutionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.bt_ArraySort = new System.Windows.Forms.Button();
            this.bt_StringSort = new System.Windows.Forms.Button();
            this.bt_TSort = new System.Windows.Forms.Button();
            this.bt_PSort = new System.Windows.Forms.Button();
            this.btn_FourElemsSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Меню сортировок";
            // 
            // bt_ArraySort
            // 
            this.bt_ArraySort.Location = new System.Drawing.Point(16, 72);
            this.bt_ArraySort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_ArraySort.Name = "bt_ArraySort";
            this.bt_ArraySort.Size = new System.Drawing.Size(366, 71);
            this.bt_ArraySort.TabIndex = 1;
            this.bt_ArraySort.Text = "Сортировка чисел";
            this.bt_ArraySort.UseVisualStyleBackColor = true;
            this.bt_ArraySort.Click += new System.EventHandler(this.bt_ArraySort_Click);
            // 
            // bt_StringSort
            // 
            this.bt_StringSort.Location = new System.Drawing.Point(16, 151);
            this.bt_StringSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_StringSort.Name = "bt_StringSort";
            this.bt_StringSort.Size = new System.Drawing.Size(366, 71);
            this.bt_StringSort.TabIndex = 2;
            this.bt_StringSort.Text = "Сортировка строк";
            this.bt_StringSort.UseVisualStyleBackColor = true;
            this.bt_StringSort.Click += new System.EventHandler(this.bt_StringSort_Click);
            // 
            // bt_TSort
            // 
            this.bt_TSort.Location = new System.Drawing.Point(16, 229);
            this.bt_TSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_TSort.Name = "bt_TSort";
            this.bt_TSort.Size = new System.Drawing.Size(366, 71);
            this.bt_TSort.TabIndex = 3;
            this.bt_TSort.Text = "Топологическая сортировка ";
            this.bt_TSort.UseVisualStyleBackColor = true;
            this.bt_TSort.Click += new System.EventHandler(this.bt_TSort_Click);
            // 
            // bt_PSort
            // 
            this.bt_PSort.Location = new System.Drawing.Point(16, 308);
            this.bt_PSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_PSort.Name = "bt_PSort";
            this.bt_PSort.Size = new System.Drawing.Size(366, 71);
            this.bt_PSort.TabIndex = 4;
            this.bt_PSort.Text = "Параллельная сортировка";
            this.bt_PSort.UseVisualStyleBackColor = true;
            this.bt_PSort.Click += new System.EventHandler(this.bt_PSort_Click);
            // 
            // btn_FourElemsSort
            // 
            this.btn_FourElemsSort.Location = new System.Drawing.Point(16, 387);
            this.btn_FourElemsSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_FourElemsSort.Name = "btn_FourElemsSort";
            this.btn_FourElemsSort.Size = new System.Drawing.Size(366, 71);
            this.btn_FourElemsSort.TabIndex = 5;
            this.btn_FourElemsSort.Text = "Сортировка элементов 4 типов";
            this.btn_FourElemsSort.UseVisualStyleBackColor = true;
            this.btn_FourElemsSort.Click += new System.EventHandler(this.btn_FourElemsSort_Click);
            // 
            // blankSolutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 468);
            this.Controls.Add(this.btn_FourElemsSort);
            this.Controls.Add(this.bt_PSort);
            this.Controls.Add(this.bt_TSort);
            this.Controls.Add(this.bt_StringSort);
            this.Controls.Add(this.bt_ArraySort);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "blankSolutionForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button bt_ArraySort;
        private Button bt_StringSort;
        private Button bt_TSort;
        private Button bt_PSort;
        private Button btn_FourElemsSort;
    }
}