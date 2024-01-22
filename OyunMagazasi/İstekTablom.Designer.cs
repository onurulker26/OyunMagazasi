namespace OyunMagazasi
{
    partial class İstekTablom
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelGames = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(82, 55);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(143, 140);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // flowLayoutPanelGames
            // 
           
            this.flowLayoutPanelGames.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanelGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelGames.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelGames.Name = "flowLayoutPanelGames";
            this.flowLayoutPanelGames.Size = new System.Drawing.Size(828, 485);
            this.flowLayoutPanelGames.TabIndex = 2;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Black;
            this.buttonBack.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonBack.Location = new System.Drawing.Point(700, 437);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(116, 36);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "GERI DON";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click_1);
            // 
            // İstekTablom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 485);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.flowLayoutPanelGames);
            this.Controls.Add(this.pictureBox);
            this.Name = "İstekTablom";
            this.Text = "İstekTablom";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelGames;
        private System.Windows.Forms.Button buttonBack;
    }
}