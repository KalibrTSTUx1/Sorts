namespace forms
{
    partial class formResult
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
            this.txBxResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chBxSaveFile = new System.Windows.Forms.CheckBox();
            this.txBxPath = new System.Windows.Forms.TextBox();
            this.labelPathToFile = new System.Windows.Forms.Label();
            this.chBxNew = new System.Windows.Forms.CheckBox();
            this.txBxName = new System.Windows.Forms.TextBox();
            this.labelNameFile = new System.Windows.Forms.Label();
            this.buttonChoice = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_Bx_time = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_CheckSortCorrected = new System.Windows.Forms.Button();
            this.lbl_SortCorrection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txBxResult
            // 
            this.txBxResult.Location = new System.Drawing.Point(12, 38);
            this.txBxResult.Name = "txBxResult";
            this.txBxResult.ReadOnly = true;
            this.txBxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txBxResult.Size = new System.Drawing.Size(490, 23);
            this.txBxResult.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Итог сортировки:";
            // 
            // chBxSaveFile
            // 
            this.chBxSaveFile.AutoSize = true;
            this.chBxSaveFile.Location = new System.Drawing.Point(12, 62);
            this.chBxSaveFile.Name = "chBxSaveFile";
            this.chBxSaveFile.Size = new System.Drawing.Size(182, 19);
            this.chBxSaveFile.TabIndex = 2;
            this.chBxSaveFile.Text = "Сохранить результат в файл";
            this.chBxSaveFile.UseVisualStyleBackColor = true;
            this.chBxSaveFile.CheckedChanged += new System.EventHandler(this.chBxSaveFile_CheckedChanged);
            // 
            // txBxPath
            // 
            this.txBxPath.Location = new System.Drawing.Point(98, 87);
            this.txBxPath.Name = "txBxPath";
            this.txBxPath.ReadOnly = true;
            this.txBxPath.Size = new System.Drawing.Size(250, 23);
            this.txBxPath.TabIndex = 3;
            this.txBxPath.Visible = false;
            this.txBxPath.TextChanged += new System.EventHandler(this.txBxPath_TextChanged);
            // 
            // labelPathToFile
            // 
            this.labelPathToFile.AutoSize = true;
            this.labelPathToFile.Location = new System.Drawing.Point(10, 92);
            this.labelPathToFile.Name = "labelPathToFile";
            this.labelPathToFile.Size = new System.Drawing.Size(80, 15);
            this.labelPathToFile.TabIndex = 4;
            this.labelPathToFile.Text = "Путь к файлу";
            this.labelPathToFile.Visible = false;
            // 
            // chBxNew
            // 
            this.chBxNew.AutoSize = true;
            this.chBxNew.Location = new System.Drawing.Point(12, 116);
            this.chBxNew.Name = "chBxNew";
            this.chBxNew.Size = new System.Drawing.Size(108, 19);
            this.chBxNew.TabIndex = 5;
            this.chBxNew.Text = "Создать новый";
            this.chBxNew.UseVisualStyleBackColor = true;
            this.chBxNew.Visible = false;
            this.chBxNew.CheckedChanged += new System.EventHandler(this.chBxNew_CheckedChanged);
            // 
            // txBxName
            // 
            this.txBxName.Location = new System.Drawing.Point(12, 141);
            this.txBxName.Name = "txBxName";
            this.txBxName.Size = new System.Drawing.Size(168, 23);
            this.txBxName.TabIndex = 6;
            this.txBxName.Visible = false;
            // 
            // labelNameFile
            // 
            this.labelNameFile.AutoSize = true;
            this.labelNameFile.Location = new System.Drawing.Point(12, 164);
            this.labelNameFile.Name = "labelNameFile";
            this.labelNameFile.Size = new System.Drawing.Size(69, 15);
            this.labelNameFile.TabIndex = 7;
            this.labelNameFile.Text = "Имя файла";
            this.labelNameFile.Visible = false;
            // 
            // buttonChoice
            // 
            this.buttonChoice.Location = new System.Drawing.Point(357, 141);
            this.buttonChoice.Name = "buttonChoice";
            this.buttonChoice.Size = new System.Drawing.Size(80, 23);
            this.buttonChoice.TabIndex = 8;
            this.buttonChoice.Text = "Выбрать";
            this.buttonChoice.UseVisualStyleBackColor = true;
            this.buttonChoice.Visible = false;
            this.buttonChoice.Click += new System.EventHandler(this.buttonChoice_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(451, 141);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(80, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(260, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Время - ";
            // 
            // tx_Bx_time
            // 
            this.tx_Bx_time.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tx_Bx_time.Location = new System.Drawing.Point(323, 10);
            this.tx_Bx_time.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_Bx_time.Name = "tx_Bx_time";
            this.tx_Bx_time.ReadOnly = true;
            this.tx_Bx_time.Size = new System.Drawing.Size(91, 26);
            this.tx_Bx_time.TabIndex = 11;
            
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "миллисекунд";
            // 
            // btn_CheckSortCorrected
            // 
            this.btn_CheckSortCorrected.Location = new System.Drawing.Point(357, 88);
            this.btn_CheckSortCorrected.Name = "btn_CheckSortCorrected";
            this.btn_CheckSortCorrected.Size = new System.Drawing.Size(173, 46);
            this.btn_CheckSortCorrected.TabIndex = 13;
            this.btn_CheckSortCorrected.Text = "Проверить правильность сортировки";
            this.btn_CheckSortCorrected.UseVisualStyleBackColor = true;
            this.btn_CheckSortCorrected.Click += new System.EventHandler(this.btn_CheckSortCorrected_Click);
            // 
            // lbl_SortCorrection
            // 
            this.lbl_SortCorrection.AutoSize = true;
            this.lbl_SortCorrection.Location = new System.Drawing.Point(198, 143);
            this.lbl_SortCorrection.Name = "lbl_SortCorrection";
            this.lbl_SortCorrection.Size = new System.Drawing.Size(133, 15);
            this.lbl_SortCorrection.TabIndex = 14;
            this.lbl_SortCorrection.Text = "Сортировка корректна";
            this.lbl_SortCorrection.UseMnemonic = false;
            this.lbl_SortCorrection.Visible = false;
            // 
            // formResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 202);
            this.Controls.Add(this.lbl_SortCorrection);
            this.Controls.Add(this.btn_CheckSortCorrected);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx_Bx_time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonChoice);
            this.Controls.Add(this.labelNameFile);
            this.Controls.Add(this.txBxName);
            this.Controls.Add(this.chBxNew);
            this.Controls.Add(this.labelPathToFile);
            this.Controls.Add(this.txBxPath);
            this.Controls.Add(this.chBxSaveFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txBxResult);
            this.Name = "formResult";
            this.Text = "formResult";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txBxResult;
        private Label label1;
        private CheckBox chBxSaveFile;
        private TextBox txBxPath;
        private Label labelPathToFile;
        private CheckBox chBxNew;
        private TextBox txBxName;
        private Label labelNameFile;
        private Button buttonChoice;
        private OpenFileDialog openFileDialog1;
        private Button buttonSave;
        private Label label2;
        private TextBox tx_Bx_time;
        private Label label3;
        private Button btn_CheckSortCorrected;
        private Label lbl_SortCorrection;
    }
}