namespace Student_Management.UI
{
    partial class Update_Score
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GKtb = new System.Windows.Forms.TextBox();
            this.Tongtb = new System.Windows.Forms.TextBox();
            this.Khactb = new System.Windows.Forms.TextBox();
            this.CKtb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Điểm GK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Điểm CK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điểm Khác";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điểm Tổng";
            // 
            // GKtb
            // 
            this.GKtb.Location = new System.Drawing.Point(69, 13);
            this.GKtb.Name = "GKtb";
            this.GKtb.Size = new System.Drawing.Size(42, 20);
            this.GKtb.TabIndex = 4;
            // 
            // Tongtb
            // 
            this.Tongtb.Location = new System.Drawing.Point(69, 83);
            this.Tongtb.Name = "Tongtb";
            this.Tongtb.Size = new System.Drawing.Size(42, 20);
            this.Tongtb.TabIndex = 5;
            // 
            // Khactb
            // 
            this.Khactb.Location = new System.Drawing.Point(69, 60);
            this.Khactb.Name = "Khactb";
            this.Khactb.Size = new System.Drawing.Size(42, 20);
            this.Khactb.TabIndex = 6;
            // 
            // CKtb
            // 
            this.CKtb.Location = new System.Drawing.Point(69, 37);
            this.CKtb.Name = "CKtb";
            this.CKtb.Size = new System.Drawing.Size(42, 20);
            this.CKtb.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Update_Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 156);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CKtb);
            this.Controls.Add(this.Khactb);
            this.Controls.Add(this.Tongtb);
            this.Controls.Add(this.GKtb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Update_Score";
            this.Text = "Update_Score";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GKtb;
        private System.Windows.Forms.TextBox Tongtb;
        private System.Windows.Forms.TextBox Khactb;
        private System.Windows.Forms.TextBox CKtb;
        private System.Windows.Forms.Button button1;
    }
}