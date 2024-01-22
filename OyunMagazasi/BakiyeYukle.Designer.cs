namespace OyunMagazasi
{
    partial class BakiyeYukle
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
            this.buttonYukle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonYukle
            // 
            this.buttonYukle.BackColor = System.Drawing.Color.LavenderBlush;
            this.buttonYukle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonYukle.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYukle.ForeColor = System.Drawing.Color.Red;
            this.buttonYukle.Location = new System.Drawing.Point(345, 240);
            this.buttonYukle.Name = "buttonYukle";
            this.buttonYukle.Size = new System.Drawing.Size(269, 105);
            this.buttonYukle.TabIndex = 0;
            this.buttonYukle.Text = "YUKLE";
            this.buttonYukle.UseVisualStyleBackColor = false;
            this.buttonYukle.Click += new System.EventHandler(this.buttonYukle_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(345, 162);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.LavenderBlush;
            this.buttonBack.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.Red;
            this.buttonBack.Location = new System.Drawing.Point(711, 435);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(111, 36);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Geri Don";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LavenderBlush;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(25, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yuklemek istediginiz miktar >>\r\n";
            // 
            // BakiyeYukle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            
            this.ClientSize = new System.Drawing.Size(834, 483);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonYukle);
            this.Name = "BakiyeYukle";
            this.Text = "BakiyeYuklecs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonYukle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
    }
}