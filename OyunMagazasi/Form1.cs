using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OyunMagazasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            this.Hide();
            GirisYap girisyap = new GirisYap();
            girisyap.ShowDialog();
            this.Close();
        }

        private void buttonKayit_Click(object sender, EventArgs e)
        {
            
            
            this.Hide();
            KayitOl kayitol= new KayitOl();
            kayitol.ShowDialog();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
