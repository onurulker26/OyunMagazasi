namespace OyunMagazasi
{
    partial class Yorum
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
            this.listBoxReviews = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Black;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonBack.Location = new System.Drawing.Point(699, 443);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(111, 37);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Geri Don";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // listBoxReviews
            // 
            this.listBoxReviews.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listBoxReviews.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxReviews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxReviews.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxReviews.FormattingEnabled = true;
            this.listBoxReviews.ItemHeight = 17;
            this.listBoxReviews.Location = new System.Drawing.Point(0, 0);
            this.listBoxReviews.Name = "listBoxReviews";
            this.listBoxReviews.Size = new System.Drawing.Size(822, 492);
            this.listBoxReviews.TabIndex = 1;
            this.listBoxReviews.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxReviews_MouseDown);
            // 
            // Yorum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 492);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.listBoxReviews);
            this.Name = "Yorum";
            this.Text = "Yorum";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ListBox listBoxReviews;
    }
}