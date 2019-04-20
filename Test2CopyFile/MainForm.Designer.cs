namespace Test2CopyFile
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.sourceListFile = new System.Windows.Forms.ListBox();
            this.distanationListFile = new System.Windows.Forms.ListBox();
            this.btnCopyFile = new System.Windows.Forms.Button();
            this.cbListDrivesDistanation = new System.Windows.Forms.ComboBox();
            this.cbListDrivesSource = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // sourceListFile
            // 
            this.sourceListFile.FormattingEnabled = true;
            this.sourceListFile.Location = new System.Drawing.Point(12, 12);
            this.sourceListFile.Name = "sourceListFile";
            this.sourceListFile.Size = new System.Drawing.Size(306, 381);
            this.sourceListFile.TabIndex = 0;
            this.sourceListFile.DoubleClick += new System.EventHandler(this.sourceListFile_DoubleClick);
            // 
            // distanationListFile
            // 
            this.distanationListFile.FormattingEnabled = true;
            this.distanationListFile.Location = new System.Drawing.Point(349, 12);
            this.distanationListFile.Name = "distanationListFile";
            this.distanationListFile.Size = new System.Drawing.Size(306, 381);
            this.distanationListFile.TabIndex = 1;
            this.distanationListFile.DoubleClick += new System.EventHandler(this.distanationListFile_DoubleClick);
            // 
            // btnCopyFile
            // 
            this.btnCopyFile.Location = new System.Drawing.Point(286, 399);
            this.btnCopyFile.Name = "btnCopyFile";
            this.btnCopyFile.Size = new System.Drawing.Size(96, 23);
            this.btnCopyFile.TabIndex = 2;
            this.btnCopyFile.Text = "Копировать";
            this.btnCopyFile.UseVisualStyleBackColor = true;
            this.btnCopyFile.Click += new System.EventHandler(this.btnCopyFile_Click);
            // 
            // cbListDrivesDistanation
            // 
            this.cbListDrivesDistanation.FormattingEnabled = true;
            this.cbListDrivesDistanation.Location = new System.Drawing.Point(388, 401);
            this.cbListDrivesDistanation.Name = "cbListDrivesDistanation";
            this.cbListDrivesDistanation.Size = new System.Drawing.Size(267, 21);
            this.cbListDrivesDistanation.TabIndex = 3;
            this.cbListDrivesDistanation.SelectedIndexChanged += new System.EventHandler(this.cbListDrivesDistanation_SelectedIndexChanged);
            this.cbListDrivesDistanation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbListDrivesDistanation_KeyPress);
            // 
            // cbListDrivesSource
            // 
            this.cbListDrivesSource.FormattingEnabled = true;
            this.cbListDrivesSource.Location = new System.Drawing.Point(12, 401);
            this.cbListDrivesSource.Name = "cbListDrivesSource";
            this.cbListDrivesSource.Size = new System.Drawing.Size(268, 21);
            this.cbListDrivesSource.TabIndex = 4;
            this.cbListDrivesSource.SelectedIndexChanged += new System.EventHandler(this.cbListDrivesSource_SelectedIndexChanged);
            this.cbListDrivesSource.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbListDrivesSource_KeyPress);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 429);
            this.Controls.Add(this.cbListDrivesSource);
            this.Controls.Add(this.cbListDrivesDistanation);
            this.Controls.Add(this.btnCopyFile);
            this.Controls.Add(this.distanationListFile);
            this.Controls.Add(this.sourceListFile);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Асинхронное копирование файлов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox sourceListFile;
        private System.Windows.Forms.ListBox distanationListFile;
        private System.Windows.Forms.Button btnCopyFile;
        private System.Windows.Forms.ComboBox cbListDrivesDistanation;
        private System.Windows.Forms.ComboBox cbListDrivesSource;
    }
}

