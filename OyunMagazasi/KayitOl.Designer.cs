namespace OyunMagazasi
{
    partial class KayitOl
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
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonKayit = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUserName.Font = new System.Drawing.Font("Arial Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxUserName.Location = new System.Drawing.Point(355, 92);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(270, 26);
            this.textBoxUserName.TabIndex = 0;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxEmail.Font = new System.Drawing.Font("Arial Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxEmail.Location = new System.Drawing.Point(355, 150);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(270, 26);
            this.textBoxEmail.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Font = new System.Drawing.Font("Arial Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxPassword.Location = new System.Drawing.Point(343, 219);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(270, 26);
            this.textBoxPassword.TabIndex = 2;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.DarkSlateGray;
            this.labelUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelUserName.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(92, 92);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(152, 26);
            this.labelUserName.TabIndex = 3;
            this.labelUserName.Text = "Kullanıcı adı";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.DarkSlateGray;
            this.labelEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelEmail.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(92, 150);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(94, 26);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "E-posta";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.DarkSlateGray;
            this.labelPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPassword.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(92, 219);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(65, 26);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Sifre";
            // 
            // buttonKayit
            // 
            this.buttonKayit.BackColor = System.Drawing.Color.Khaki;
            this.buttonKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKayit.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKayit.Location = new System.Drawing.Point(407, 323);
            this.buttonKayit.Name = "buttonKayit";
            this.buttonKayit.Size = new System.Drawing.Size(169, 47);
            this.buttonKayit.TabIndex = 6;
            this.buttonKayit.Text = "Kayıt Ol";
            this.buttonKayit.UseVisualStyleBackColor = false;
            this.buttonKayit.Click += new System.EventHandler(this.buttonKayit_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Khaki;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(752, 470);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(141, 45);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Geri Don";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // KayitOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(905, 527);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonKayit);
            this.Controls.Add(this.buttonBack);
            this.Name = "KayitOl";
            this.Text = "OE GAMES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonKayit;
        private System.Windows.Forms.Button buttonBack;
    }
}