namespace OyunMagazasi
{
    partial class SifreDegistir
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.textBoxCurrentPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(677, 391);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(108, 37);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "GERI DON";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textBoxCurrentPassword
            // 
            this.textBoxCurrentPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.textBoxCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCurrentPassword.ForeColor = System.Drawing.Color.Black;
            this.textBoxCurrentPassword.Location = new System.Drawing.Point(335, 33);
            this.textBoxCurrentPassword.Name = "textBoxCurrentPassword";
            this.textBoxCurrentPassword.Size = new System.Drawing.Size(229, 22);
            this.textBoxCurrentPassword.TabIndex = 1;
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.textBoxNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNewPassword.ForeColor = System.Drawing.Color.Black;
            this.textBoxNewPassword.Location = new System.Drawing.Point(335, 75);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(229, 22);
            this.textBoxNewPassword.TabIndex = 2;
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangePassword.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangePassword.ForeColor = System.Drawing.Color.Black;
            this.buttonChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChangePassword.Location = new System.Drawing.Point(389, 142);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(137, 44);
            this.buttonChangePassword.TabIndex = 3;
            this.buttonChangePassword.Text = "DEGISTIR";
            this.buttonChangePassword.UseVisualStyleBackColor = false;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(146, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mevcut şifrenizi giriniz.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(146, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yeni şifrenizi giriniz";
            // 
            // SifreDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonChangePassword);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.textBoxCurrentPassword);
            this.Controls.Add(this.buttonBack);
            this.Name = "SifreDegistir";
            this.Text = "SifreDegistir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox textBoxCurrentPassword;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}