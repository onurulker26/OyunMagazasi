using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OyunMagazasi
{
    public partial class AnaMenu : Form
    {

        // Kullanıcı ID'sini saklamak için özellik
        public int UserID { get; set; }


        public AnaMenu()

        {
            InitializeComponent();

        }
        private void AnaMenu_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde kullanıcının bakiyesini göster
            GosterBakiye(UserID);
        }
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            // Çıkış yap düğmesi tıklandığında formu kapat
            this.Close();
        }

        private void buttonStore_Click(object sender, EventArgs e)
        {
            this.Hide();
            Magaza magaza = new Magaza();
            magaza.UserID = UserID;
            magaza.ShowDialog();
            this.Close();
        }

        private void buttonUserLibrary_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserLibrary userLibrary = new UserLibrary();
            userLibrary.UserID = UserID;    
            userLibrary.ShowDialog();
            this.Close();
          
        }
       
        public void GosterBakiye(int userID)  // Kullanıcının bakiyesini gösteren metod
        {

            using (SqlConnection connection = new SqlConnection("Data Source=ONUR\\SQLEXPRESS;Initial Catalog=OyunPlatformuV4;Integrated Security=True"))
            {

                string sqlQuery = "SELECT Balance FROM Users WHERE UserID = @UserID"; // Kullanıcının bakiyesini getiren SQL sorgusu


                using (SqlCommand command = new SqlCommand(sqlQuery, connection))  // SQL sorgusu ve bağlantı ile bir komut oluştur
                {
                     
                    command.Parameters.AddWithValue("@UserID", userID);  // Komuta parametre ekle

                    try
                    {

                        connection.Open();



                        object result = command.ExecuteScalar();  // Sorguyu çalıştır ve bakiyeyi al
                        decimal balance = result != null ? (decimal)result : 0;


                        labelBakiye.Text = balance.ToString("0.00");   // Labela bakiyeyi yaz
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void buttonYukle_Click(object sender, EventArgs e)
        {
            this.Hide();
            BakiyeYukle bakiye=new BakiyeYukle();
            bakiye.UserID=UserID;
            bakiye.ShowDialog();
            this.Close();
        }

        private void buttonDev_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gelistirici gelistirici = new Gelistirici();
            gelistirici.UserID=UserID;
            gelistirici.ShowDialog();
            this.Close();
        }

        private void pictureBoxProfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profil profil = new Profil(UserID);   
            profil.UserID=UserID;
            profil.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            İstekTablom tablo=new İstekTablom(UserID);
            tablo.UserID=UserID;
            tablo.ShowDialog();
            this.Close();
        }

        private void buttonYorum_Click(object sender, EventArgs e)
        {
            this.Hide();
            Yorum yorum=new Yorum(UserID);
            yorum.UserID=UserID;
            yorum.ShowDialog();
            this.Close();
        }
    }
    
    
    
    
    }


