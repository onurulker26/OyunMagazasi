namespace OyunMagazasi
{
    partial class YorumYap
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
            this.buttonYorumOnay = new System.Windows.Forms.Button();
            this.numericUpDownRating = new System.Windows.Forms.NumericUpDown();
            this.comboBoxGames = new System.Windows.Forms.ComboBox();
            this.richTextBoxYorum = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRating)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(685, 394);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(103, 44);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "gerı don";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonYorumOnay
            // 
            this.buttonYorumOnay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonYorumOnay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonYorumOnay.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYorumOnay.Location = new System.Drawing.Point(318, 322);
            this.buttonYorumOnay.Name = "buttonYorumOnay";
            this.buttonYorumOnay.Size = new System.Drawing.Size(142, 36);
            this.buttonYorumOnay.TabIndex = 1;
            this.buttonYorumOnay.Text = "gonder";
            this.buttonYorumOnay.UseVisualStyleBackColor = false;
            this.buttonYorumOnay.Click += new System.EventHandler(this.buttonYorumOnay_Click);
            // 
            // numericUpDownRating
            // 
            this.numericUpDownRating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.numericUpDownRating.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownRating.Location = new System.Drawing.Point(27, 395);
            this.numericUpDownRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownRating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRating.Name = "numericUpDownRating";
            this.numericUpDownRating.Size = new System.Drawing.Size(130, 18);
            this.numericUpDownRating.TabIndex = 3;
            this.numericUpDownRating.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxGames
            // 
            this.comboBoxGames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.comboBoxGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxGames.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxGames.FormattingEnabled = true;
            this.comboBoxGames.Location = new System.Drawing.Point(339, 12);
            this.comboBoxGames.Name = "comboBoxGames";
            this.comboBoxGames.Size = new System.Drawing.Size(121, 23);
            this.comboBoxGames.TabIndex = 5;
            // 
            // richTextBoxYorum
            // 
            this.richTextBoxYorum.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBoxYorum.Location = new System.Drawing.Point(12, 55);
            this.richTextBoxYorum.Name = "richTextBoxYorum";
            this.richTextBoxYorum.Size = new System.Drawing.Size(764, 261);
            this.richTextBoxYorum.TabIndex = 6;
            this.richTextBoxYorum.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(43, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Puan verin 1-5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(184, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Oyun seçiniz >>>>";
            // 
            // YorumYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxYorum);
            this.Controls.Add(this.comboBoxGames);
            this.Controls.Add(this.numericUpDownRating);
            this.Controls.Add(this.buttonYorumOnay);
            this.Controls.Add(this.buttonBack);
            this.Name = "YorumYap";
            this.Text = "YorumYap";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonYorumOnay;
        private System.Windows.Forms.NumericUpDown numericUpDownRating;
        private System.Windows.Forms.ComboBox comboBoxGames;
        private System.Windows.Forms.RichTextBox richTextBoxYorum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}