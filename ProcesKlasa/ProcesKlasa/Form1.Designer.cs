namespace ProcesKlasa
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
            this.btnInternet = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInternet
            // 
            this.btnInternet.Location = new System.Drawing.Point(48, 12);
            this.btnInternet.Name = "btnInternet";
            this.btnInternet.Size = new System.Drawing.Size(197, 115);
            this.btnInternet.TabIndex = 0;
            this.btnInternet.Text = "Internet";
            this.btnInternet.UseVisualStyleBackColor = true;
            this.btnInternet.Click += new System.EventHandler(this.btnInternet_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(269, 12);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(197, 115);
            this.btnExcel.TabIndex = 1;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // btnWord
            // 
            this.btnWord.Location = new System.Drawing.Point(48, 149);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(197, 115);
            this.btnWord.TabIndex = 2;
            this.btnWord.Text = "Word";
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(269, 149);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(197, 115);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 286);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnInternet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInternet;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Button btnInfo;
    }
}

