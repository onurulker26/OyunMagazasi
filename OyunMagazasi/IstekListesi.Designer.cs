namespace OyunMagazasi
{
    partial class IstekListesi
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
            this.comboBoxGames = new System.Windows.Forms.ComboBox();
            this.buttonAddToWishlist = new System.Windows.Forms.Button();
            this.buttonRemoveFromWishlist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(656, 382);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(132, 41);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Geri Don";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // comboBoxGames
            // 
            this.comboBoxGames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.comboBoxGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxGames.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboBoxGames.FormattingEnabled = true;
            this.comboBoxGames.Location = new System.Drawing.Point(264, 29);
            this.comboBoxGames.Name = "comboBoxGames";
            this.comboBoxGames.Size = new System.Drawing.Size(293, 24);
            this.comboBoxGames.TabIndex = 3;
            // 
            // buttonAddToWishlist
            // 
            this.buttonAddToWishlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonAddToWishlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddToWishlist.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAddToWishlist.Location = new System.Drawing.Point(299, 93);
            this.buttonAddToWishlist.Name = "buttonAddToWishlist";
            this.buttonAddToWishlist.Size = new System.Drawing.Size(230, 36);
            this.buttonAddToWishlist.TabIndex = 4;
            this.buttonAddToWishlist.Text = "İstek listeme ekle";
            this.buttonAddToWishlist.UseVisualStyleBackColor = false;
            this.buttonAddToWishlist.Click += new System.EventHandler(this.buttonAddToWishlist_Click);
            // 
            // buttonRemoveFromWishlist
            // 
            this.buttonRemoveFromWishlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonRemoveFromWishlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveFromWishlist.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRemoveFromWishlist.Location = new System.Drawing.Point(299, 156);
            this.buttonRemoveFromWishlist.Name = "buttonRemoveFromWishlist";
            this.buttonRemoveFromWishlist.Size = new System.Drawing.Size(230, 36);
            this.buttonRemoveFromWishlist.TabIndex = 5;
            this.buttonRemoveFromWishlist.Text = "İstek listemden çıkar";
            this.buttonRemoveFromWishlist.UseVisualStyleBackColor = false;
            this.buttonRemoveFromWishlist.Click += new System.EventHandler(this.buttonRemoveFromWishlist_Click);
            // 
            // IstekListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRemoveFromWishlist);
            this.Controls.Add(this.buttonAddToWishlist);
            this.Controls.Add(this.comboBoxGames);
            this.Controls.Add(this.buttonBack);
            this.Name = "IstekListesi";
            this.Text = "IstekListesi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ComboBox comboBoxGames;
        private System.Windows.Forms.Button buttonAddToWishlist;
        private System.Windows.Forms.Button buttonRemoveFromWishlist;
    }
}