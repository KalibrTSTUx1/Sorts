namespace Interface
{
    partial class SortingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.sortName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resArray = new System.Windows.Forms.TextBox();
            this.logOfChanges = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ход сортировки:";
            // 
            // sortName
            // 
            this.sortName.AutoSize = true;
            this.sortName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sortName.Location = new System.Drawing.Point(30, 20);
            this.sortName.Name = "sortName";
            this.sortName.Size = new System.Drawing.Size(0, 46);
            this.sortName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(424, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Итог сортировки:";
            // 
            // resArray
            // 
            this.resArray.Location = new System.Drawing.Point(424, 163);
            this.resArray.Name = "resArray";
            this.resArray.Size = new System.Drawing.Size(353, 27);
            this.resArray.TabIndex = 4;
            // 
            // logOfChanges
            // 
            this.logOfChanges.Location = new System.Drawing.Point(30, 163);
            this.logOfChanges.Name = "logOfChanges";
            this.logOfChanges.Size = new System.Drawing.Size(353, 249);
            this.logOfChanges.TabIndex = 5;
            this.logOfChanges.Text = "";
            // 
            // SortingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logOfChanges);
            this.Controls.Add(this.resArray);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sortName);
            this.Controls.Add(this.label1);
            this.Name = "SortingForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label sortName;
        private Label label2;
        private TextBox resArray;
        private RichTextBox logOfChanges;
    }
}