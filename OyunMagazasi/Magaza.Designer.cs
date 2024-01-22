namespace OyunMagazasi
{
    partial class Magaza
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
            this.components = new System.ComponentModel.Container();
            this.gamesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.gamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gamesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gamesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
           
            this.listView1.BackgroundImageTiled = true;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1262, 673);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(96, 96);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Coral;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.Black;
            this.buttonBack.Location = new System.Drawing.Point(1137, 624);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(113, 37);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "GERI DON";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Magaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.listView1);
            this.Name = "Magaza";
            this.Text = "Magaza";
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
       
        private System.Windows.Forms.BindingSource gamesBindingSource;
      
        private System.Windows.Forms.BindingSource gamesBindingSource1;
        
        private System.Windows.Forms.BindingSource gamesBindingSource2;
       
        private System.Windows.Forms.BindingSource gamesBindingSource3;
     
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonBack;
    }
}