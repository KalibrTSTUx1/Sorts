﻿namespace Project
{
    partial class parralelSort
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
            this.txBx_InpPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_InpPath = new System.Windows.Forms.Button();
            this.chBx_ManualPath = new System.Windows.Forms.CheckBox();
            this.txBx_OutPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_OutPath = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.ch_Bx_showResInForm = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txBx_InpPath
            // 
            this.txBx_InpPath.Location = new System.Drawing.Point(14, 104);
            this.txBx_InpPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txBx_InpPath.Name = "txBx_InpPath";
            this.txBx_InpPath.ReadOnly = true;
            this.txBx_InpPath.Size = new System.Drawing.Size(383, 27);
            this.txBx_InpPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Парралельная сортировка";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_InpPath
            // 
            this.button_InpPath.Location = new System.Drawing.Point(410, 102);
            this.button_InpPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_InpPath.Name = "button_InpPath";
            this.button_InpPath.Size = new System.Drawing.Size(86, 31);
            this.button_InpPath.TabIndex = 2;
            this.button_InpPath.Text = "Выбрать";
            this.button_InpPath.UseVisualStyleBackColor = true;
            this.button_InpPath.Click += new System.EventHandler(this.button1_Click);
            // 
            // chBx_ManualPath
            // 
            this.chBx_ManualPath.AutoSize = true;
            this.chBx_ManualPath.Location = new System.Drawing.Point(14, 213);
            this.chBx_ManualPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chBx_ManualPath.Name = "chBx_ManualPath";
            this.chBx_ManualPath.Size = new System.Drawing.Size(175, 24);
            this.chBx_ManualPath.TabIndex = 3;
            this.chBx_ManualPath.Text = "Задать путь вручную";
            this.chBx_ManualPath.UseVisualStyleBackColor = true;
            this.chBx_ManualPath.CheckedChanged += new System.EventHandler(this.chBx_ManualPath_CheckedChanged);
            // 
            // txBx_OutPath
            // 
            this.txBx_OutPath.Location = new System.Drawing.Point(14, 143);
            this.txBx_OutPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txBx_OutPath.Name = "txBx_OutPath";
            this.txBx_OutPath.ReadOnly = true;
            this.txBx_OutPath.Size = new System.Drawing.Size(383, 27);
            this.txBx_OutPath.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Путь к входному файлу:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Путь к выходному файлу";
            // 
            // button_OutPath
            // 
            this.button_OutPath.Location = new System.Drawing.Point(410, 142);
            this.button_OutPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_OutPath.Name = "button_OutPath";
            this.button_OutPath.Size = new System.Drawing.Size(86, 31);
            this.button_OutPath.TabIndex = 7;
            this.button_OutPath.Text = "Выбрать";
            this.button_OutPath.UseVisualStyleBackColor = true;
            this.button_OutPath.Click += new System.EventHandler(this.button_OutPath_Click);
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(356, 180);
            this.button_Start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(139, 57);
            this.button_Start.TabIndex = 8;
            this.button_Start.Text = "Запустить";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // ch_Bx_showResInForm
            // 
            this.ch_Bx_showResInForm.AutoSize = true;
            this.ch_Bx_showResInForm.Location = new System.Drawing.Point(14, 245);
            this.ch_Bx_showResInForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ch_Bx_showResInForm.Name = "ch_Bx_showResInForm";
            this.ch_Bx_showResInForm.Size = new System.Drawing.Size(402, 24);
            this.ch_Bx_showResInForm.TabIndex = 9;
            this.ch_Bx_showResInForm.Text = "Показать результат в виде текста в отдельной форме";
            this.ch_Bx_showResInForm.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 74);
            this.button1.TabIndex = 10;
            this.button1.Text = "Справка по формату";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(518, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 68);
            this.button2.TabIndex = 11;
            this.button2.Text = "Ручной ввод массива";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 274);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ch_Bx_showResInForm);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.button_OutPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txBx_OutPath);
            this.Controls.Add(this.chBx_ManualPath);
            this.Controls.Add(this.button_InpPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txBx_InpPath);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txBx_InpPath;
        private Label label1;
        private ErrorProvider errorProvider1;
        private Button button_OutPath;
        private Label label3;
        private Label label2;
        private TextBox txBx_OutPath;
        private CheckBox chBx_ManualPath;
        private Button button_InpPath;
        private OpenFileDialog openFileDialog1;
        private Button button_Start;
        private CheckBox ch_Bx_showResInForm;
        private Button button1;
        private Button button2;
    }
}