namespace _14_Klasa_Process
{
    partial class Form1
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
            this.fInfo = new System.Windows.Forms.Button();
            this.fWord = new System.Windows.Forms.Button();
            this.fExcel = new System.Windows.Forms.Button();
            this.fExplorer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fInfo
            // 
            this.fInfo.Location = new System.Drawing.Point(185, 108);
            this.fInfo.Name = "fInfo";
            this.fInfo.Size = new System.Drawing.Size(113, 61);
            this.fInfo.TabIndex = 7;
            this.fInfo.Text = "Start Info";
            this.fInfo.UseVisualStyleBackColor = true;
            this.fInfo.Click += new System.EventHandler(this.fInfo_Click_1);
            // 
            // fWord
            // 
            this.fWord.Location = new System.Drawing.Point(29, 108);
            this.fWord.Name = "fWord";
            this.fWord.Size = new System.Drawing.Size(127, 61);
            this.fWord.TabIndex = 6;
            this.fWord.Text = "Word";
            this.fWord.UseVisualStyleBackColor = true;
            this.fWord.Click += new System.EventHandler(this.fWord_Click_1);
            // 
            // fExcel
            // 
            this.fExcel.Location = new System.Drawing.Point(185, 29);
            this.fExcel.Name = "fExcel";
            this.fExcel.Size = new System.Drawing.Size(113, 56);
            this.fExcel.TabIndex = 5;
            this.fExcel.Text = "Excel";
            this.fExcel.UseVisualStyleBackColor = true;
            this.fExcel.Click += new System.EventHandler(this.fExcel_Click_1);
            // 
            // fExplorer
            // 
            this.fExplorer.Location = new System.Drawing.Point(29, 29);
            this.fExplorer.Name = "fExplorer";
            this.fExplorer.Size = new System.Drawing.Size(127, 56);
            this.fExplorer.TabIndex = 4;
            this.fExplorer.Text = "Internet explorer";
            this.fExplorer.UseVisualStyleBackColor = true;
            this.fExplorer.Click += new System.EventHandler(this.fExplorer_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 205);
            this.Controls.Add(this.fInfo);
            this.Controls.Add(this.fWord);
            this.Controls.Add(this.fExcel);
            this.Controls.Add(this.fExplorer);
            this.Name = "Form1";
            this.Text = "Klasa Process";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fInfo;
        private System.Windows.Forms.Button fWord;
        private System.Windows.Forms.Button fExcel;
        private System.Windows.Forms.Button fExplorer;
    }
}

