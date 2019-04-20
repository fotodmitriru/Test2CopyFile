namespace Test2CopyFile
{
    partial class ListFilesCopies
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
            this.listCopies = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listCopies
            // 
            this.listCopies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listCopies.FormattingEnabled = true;
            this.listCopies.Location = new System.Drawing.Point(12, 12);
            this.listCopies.Name = "listCopies";
            this.listCopies.Size = new System.Drawing.Size(443, 420);
            this.listCopies.TabIndex = 0;
            // 
            // ListFilesCopies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 440);
            this.Controls.Add(this.listCopies);
            this.Name = "ListFilesCopies";
            this.Text = "ListFilesCopies";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListFilesCopies_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox listCopies;
    }
}