namespace OyunMagazasi
{
    partial class Purchase
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
            this.backButton = new System.Windows.Forms.Button();
            this.listBoxPurchases = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(677, 393);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(111, 45);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "geri don";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // listBoxPurchases
            // 
            this.listBoxPurchases.BackColor = System.Drawing.SystemColors.Highlight;
            this.listBoxPurchases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPurchases.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxPurchases.FormattingEnabled = true;
            this.listBoxPurchases.ItemHeight = 22;
            this.listBoxPurchases.Location = new System.Drawing.Point(0, 0);
            this.listBoxPurchases.Name = "listBoxPurchases";
            this.listBoxPurchases.Size = new System.Drawing.Size(800, 450);
            this.listBoxPurchases.TabIndex = 1;
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.listBoxPurchases);
            this.Name = "Purchase";
            this.Text = "Purchase";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ListBox listBoxPurchases;
    }
}