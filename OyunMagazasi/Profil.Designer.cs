namespace OyunMagazasi
{
    partial class Profil
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
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonPurchases = new System.Windows.Forms.Button();
            this.buttonWishlist = new System.Windows.Forms.Button();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.buttonYorumYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(673, 407);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(115, 31);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Geri Don";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelUserName.Font = new System.Drawing.Font("Trebuchet MS", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelUserName.Location = new System.Drawing.Point(349, 9);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(0, 42);
            this.labelUserName.TabIndex = 1;
            // 
            // buttonPurchases
            // 
            this.buttonPurchases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonPurchases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPurchases.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonPurchases.Location = new System.Drawing.Point(12, 263);
            this.buttonPurchases.Name = "buttonPurchases";
            this.buttonPurchases.Size = new System.Drawing.Size(776, 40);
            this.buttonPurchases.TabIndex = 2;
            this.buttonPurchases.Text = "Satın Alma Gemişi";
            this.buttonPurchases.UseVisualStyleBackColor = false;
            this.buttonPurchases.Click += new System.EventHandler(this.buttonPurchases_Click);
            // 
            // buttonWishlist
            // 
            this.buttonWishlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonWishlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWishlist.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonWishlist.Location = new System.Drawing.Point(12, 108);
            this.buttonWishlist.Name = "buttonWishlist";
            this.buttonWishlist.Size = new System.Drawing.Size(776, 40);
            this.buttonWishlist.TabIndex = 3;
            this.buttonWishlist.Text = "İstek Listesi";
            this.buttonWishlist.UseVisualStyleBackColor = false;
            this.buttonWishlist.Click += new System.EventHandler(this.buttonWishlist_Click);
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangePassword.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonChangePassword.Location = new System.Drawing.Point(12, 337);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(776, 40);
            this.buttonChangePassword.TabIndex = 4;
            this.buttonChangePassword.Text = "Sifre Değiştir";
            this.buttonChangePassword.UseVisualStyleBackColor = false;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // buttonYorumYap
            // 
            this.buttonYorumYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonYorumYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonYorumYap.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonYorumYap.Location = new System.Drawing.Point(12, 185);
            this.buttonYorumYap.Name = "buttonYorumYap";
            this.buttonYorumYap.Size = new System.Drawing.Size(776, 40);
            this.buttonYorumYap.TabIndex = 5;
            this.buttonYorumYap.Text = "Yorum ve Değerlendirme Yap";
            this.buttonYorumYap.UseVisualStyleBackColor = false;
            this.buttonYorumYap.Click += new System.EventHandler(this.buttonYorumYap_Click);
            // 
            // Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonYorumYap);
            this.Controls.Add(this.buttonChangePassword);
            this.Controls.Add(this.buttonWishlist);
            this.Controls.Add(this.buttonPurchases);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.buttonBack);
            this.Name = "Profil";
            this.Text = "Profil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonPurchases;
        private System.Windows.Forms.Button buttonWishlist;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.Button buttonYorumYap;
    }
}