namespace OyunMagazasi
{
    partial class OyunDetaylari
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelReleaseDate = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.buttonSatinAl = new System.Windows.Forms.Button();
            this.labelDeveloper = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Orchid;
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelName.Location = new System.Drawing.Point(369, 40);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(39, 16);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.BackColor = System.Drawing.Color.Orchid;
            this.labelGenre.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGenre.Location = new System.Drawing.Point(470, 107);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(40, 16);
            this.labelGenre.TabIndex = 1;
            this.labelGenre.Text = "Genre";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.Orchid;
            this.labelPrice.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPrice.Location = new System.Drawing.Point(369, 205);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(36, 16);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Price";
            // 
            // labelReleaseDate
            // 
            this.labelReleaseDate.AutoSize = true;
            this.labelReleaseDate.BackColor = System.Drawing.Color.Orchid;
            this.labelReleaseDate.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelReleaseDate.Location = new System.Drawing.Point(285, 136);
            this.labelReleaseDate.Name = "labelReleaseDate";
            this.labelReleaseDate.Size = new System.Drawing.Size(37, 16);
            this.labelReleaseDate.TabIndex = 3;
            this.labelReleaseDate.Text = "Tarih";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Orchid;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(654, 386);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(134, 52);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Geri Don";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // buttonSatinAl
            // 
            this.buttonSatinAl.BackColor = System.Drawing.Color.Orchid;
            this.buttonSatinAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSatinAl.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSatinAl.Location = new System.Drawing.Point(288, 296);
            this.buttonSatinAl.Name = "buttonSatinAl";
            this.buttonSatinAl.Size = new System.Drawing.Size(222, 49);
            this.buttonSatinAl.TabIndex = 5;
            this.buttonSatinAl.Text = "Satın Al";
            this.buttonSatinAl.UseVisualStyleBackColor = false;
            this.buttonSatinAl.Click += new System.EventHandler(this.buttonSatinAl_Click);
            // 
            // labelDeveloper
            // 
            this.labelDeveloper.AutoSize = true;
            this.labelDeveloper.Location = new System.Drawing.Point(369, 13);
            this.labelDeveloper.Name = "labelDeveloper";
            this.labelDeveloper.Size = new System.Drawing.Size(0, 16);
            this.labelDeveloper.TabIndex = 6;
            // 
            // OyunDetaylari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDeveloper);
            this.Controls.Add(this.buttonSatinAl);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.labelReleaseDate);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelName);
            this.Name = "OyunDetaylari";
            this.Text = "OyunDetaylari";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelReleaseDate;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button buttonSatinAl;
        private System.Windows.Forms.Label labelDeveloper;
    }
}