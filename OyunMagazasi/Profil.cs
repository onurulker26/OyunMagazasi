using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OyunMagazasi
{
    public partial class Profil : Form
    {


        public int UserID { get; set; }
       
        public Profil(int userID) // Profil formu oluşturulurken kullanıcının idsini alarak başlatan constructor...
        {
            InitializeComponent();
            UserID = userID;
            GetGameUserInfo();
        }
           
        
        public void GetGameUserInfo()
        {
            string connectionString= "Data Source=ONUR\\SQLEXPRESS;Initial Catalog=OyunPlatformuV4;Integrated Security=True";
            string query = "SELECT UserID ,Username FROM Users WHERE UserID=@UserID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@UserID", UserID);

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader(); 
                while (reader.Read())
                {
                    string username = reader.GetString(1);
                    labelUserName.Text = username;  
                }
                        reader.Close();
            }
                    
        
        }
        
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaMenu anamenu = new AnaMenu();
            anamenu.UserID = UserID;
            anamenu.ShowDialog();
            this.Close();
        }

        private void buttonPurchases_Click(object sender, EventArgs e)
        {
            this.Hide();
            Purchase purchase = new Purchase(UserID); 
            purchase.UserID=UserID;
            purchase.ShowDialog();
            this.Close();
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            SifreDegistir sifreDegistir = new SifreDegistir(UserID);
            sifreDegistir.UserID = UserID;
            sifreDegistir.ShowDialog();
            this.Close();
        }

        private void buttonWishlist_Click(object sender, EventArgs e)
        {
            this.Hide();
            IstekListesi istek=new IstekListesi(UserID);
            istek.UserID=UserID;
            istek.ShowDialog();
            this.Close();

        }

        private void buttonYorumYap_Click(object sender, EventArgs e)
        {
            this.Hide();
            YorumYap yorumYap = new YorumYap(UserID);
            yorumYap.ShowDialog();
            this.Close();
        }
    }
}








       
       
        

