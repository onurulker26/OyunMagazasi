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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OyunMagazasi
{
    public partial class OyunDetaylari : Form
    {
        public int UserID { get; set; }  // Kullanıcı ID'sini saklamak için özellik
        private dynamic gameInfo;   // Seçilen oyunun bilgilerini saklamak için dinamik bir nesne
        public OyunDetaylari(int userID, dynamic gameInfo)
        { 
            InitializeComponent();
            UserID = userID;   // Kullanıcı ID'si ve oyun bilgilerini sınıfa atar
            this.gameInfo = gameInfo;
        }

        public void OyunDetaylariGoster(int UserID, dynamic gameInfo)  // Oyun detaylarını gösteren metod

        {

            labelName.Text = gameInfo.Name; 
            labelGenre.Text = "Tür :   "+gameInfo.Genre;
            labelPrice.Text = "Fiyat :   " +gameInfo.Price.ToString();
            labelReleaseDate.Text = "Cikis tarihi :   "+gameInfo.ReleaseDate.ToString("dd/MM/yyyy");

           
        
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Magaza magaza = new Magaza();
            magaza.UserID = UserID;
            magaza.ShowDialog();
            this.Close();
        }


        private void buttonSatinAl_Click(object sender, EventArgs e)
        {
            if (gameInfo != null) // Eğer oyun bilgisi mevcutsa
            {
                // Kullanıcıya satın alma işlemini onaylatma
                DialogResult result = MessageBox.Show($"'{gameInfo.Name}' oyununu satın almak istiyor musunuz?", "Satın Alma Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)  // Eğer kullanıcı evet derse
                {
                    SatinAl(); // Satın alma işlemini gerçekleştiren metod
                }
            }
            else
            {
                MessageBox.Show("Oyun bilgileri bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SatinAl()
        {
            decimal oyunFiyati = gameInfo.Price;

            if (BakiyeYeterliMi(oyunFiyati))   // Eğer bakiye yeterliyse
            {
                if (!UserOyunuZatenAlmisMi())  // Eğer kullanıcı oyunu daha önce satın almamışsa
                {
                    BakiyedenDus(oyunFiyati); // Kullanıcının bakiyesinden ücreti düş
                    SatinAlmaKaydiEkle();       // Satın alma kaydını veritabanına ekle
                    UserLibraryKaydiEkle();  // Kullanıcının kütüphanesine oyunu ekle

                    MessageBox.Show("Satın alma işlemi başarılı!");
                }
                else
                {
                    MessageBox.Show("Bu oyun zaten kütüphanede bulunmaktadır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Satın alma işlemi için yeterli bakiye bulunmamaktadır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool BakiyeYeterliMi(decimal oyunFiyati)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=ONUR\\SQLEXPRESS;Initial Catalog=OyunPlatformuV4;Integrated Security=True")) 
            {
                connection.Open();

                // Kullanıcının bakiyesini kontrol etmek için sorgu
                string query = $"SELECT Balance FROM Users WHERE UserID = {UserID}";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    decimal kullaniciBakiyesi = (decimal)command.ExecuteScalar(); // Bakiyeyi al

                    return kullaniciBakiyesi >= oyunFiyati;   // Bakiye yeterli mi kontrol et
                }
            }
        }

        private void BakiyedenDus(decimal oyunFiyati)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=ONUR\\SQLEXPRESS;Initial Catalog=OyunPlatformuV4;Integrated Security=True")) 
            {
                connection.Open();

          
                string updateQuery = "UPDATE Users SET Balance = Balance - @OyunFiyati WHERE UserID = @UserID";  // Kullanıcının bakiyesinden düşme sorgusu
                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                {

                    updateCommand.Parameters.AddWithValue("@OyunFiyati", oyunFiyati);
                    updateCommand.Parameters.AddWithValue("@UserID", UserID);

                    updateCommand.ExecuteNonQuery();
                }
            }
        }

        private void SatinAlmaKaydiEkle()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=ONUR\\SQLEXPRESS;Initial Catalog=OyunPlatformuV4;Integrated Security=True")) // connectionString'i kendi veritabanı bilgilerinizle değiştirin
            {
                connection.Open();

                
                string insertQuery = "INSERT INTO Purchases(UserID, GameID, PurchaseDate) VALUES(@UserID, @GameID, GETDATE())"; // Satın alma kaydı ekleme sorgusu

                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@UserID", UserID); 
                    insertCommand.Parameters.AddWithValue("@GameID", gameInfo.Id);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        private void UserLibraryKaydiEkle()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=ONUR\\SQLEXPRESS;Initial Catalog=OyunPlatformuV4;Integrated Security=True"))  
            {
                connection.Open();

              
                string insertQuery = "INSERT INTO UserLibrary (UserID, GameID) VALUES (@UserID, @GameID)";

                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@UserID", UserID);  
                    insertCommand.Parameters.AddWithValue("@GameID", gameInfo.Id);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        private bool UserOyunuZatenAlmisMi()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=ONUR\\SQLEXPRESS;Initial Catalog=OyunPlatformuV4;Integrated Security=True"))
            {
                connection.Open();

                string query = $"SELECT COUNT(*) FROM UserLibrary WHERE UserID = {UserID} AND GameID = {gameInfo.Id}"; // Kullanıcının oyunu zaten almış olup olmadığını kontrol etmek için sorgu

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int count = (int)command.ExecuteScalar(); // Kayıt sayısını al

                    return count > 0;   // Kayıt var mı kontrol et
                }
            }
        }

       



    }
        }







 