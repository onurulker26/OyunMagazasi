namespace OyunMagazasi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGiris = new System.Windows.Forms.Button();
            this.buttonKayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGiris
            // 
            this.buttonGiris.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGiris.Font = new System.Drawing.Font("Showcard Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGiris.Location = new System.Drawing.Point(160, 193);
            this.buttonGiris.Name = "buttonGiris";
            this.buttonGiris.Size = new System.Drawing.Size(244, 140);
            this.buttonGiris.TabIndex = 0;
            this.buttonGiris.Text = "Giris Yap";
            this.buttonGiris.UseVisualStyleBackColor = false;
            this.buttonGiris.Click += new System.EventHandler(this.buttonGiris_Click);
            // 
            // buttonKayit
            // 
            this.buttonKayit.BackColor = System.Drawing.Color.Firebrick;
            this.buttonKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKayit.Font = new System.Drawing.Font("Showcard Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKayit.Location = new System.Drawing.Point(499, 193);
            this.buttonKayit.Name = "buttonKayit";
            this.buttonKayit.Size = new System.Drawing.Size(244, 140);
            this.buttonKayit.TabIndex = 1;
            this.buttonKayit.Text = "Kayit Ol";
            this.buttonKayit.UseVisualStyleBackColor = false;
            this.buttonKayit.Click += new System.EventHandler(this.buttonKayit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(905, 527);
            this.Controls.Add(this.buttonKayit);
            this.Controls.Add(this.buttonGiris);
            this.Name = "Form1";
            this.Text = "OE GAMES";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGiris;
        private System.Windows.Forms.Button buttonKayit;
    }
}

