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
    
    public partial class SifreDegistir : Form
    {
            public int UserID { get; set; }
        public SifreDegistir(int userID)
        {
            InitializeComponent();
            UserID = userID;// Kullanıcının kimliğini alarak sınıfın özelliğine atar
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profil profil = new Profil(UserID);
            profil.UserID = UserID;
            profil.ShowDialog();
            this.Close();
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            string currentPassword = textBoxCurrentPassword.Text; // Kullanıcının girdiği mevcut ve yeni şifreleri alır
            string newPassword = textBoxNewPassword.Text;

           
            if (CheckCurrentPassword(UserID, currentPassword))  // Mevcut şifrenin kontrolü
            {
                if (string.IsNullOrEmpty(currentPassword) || string.IsNullOrEmpty(newPassword)) // Boş alan var mı onun için kontrol...
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.");
                    return;
                }

                if (currentPassword != newPassword)
                {
                   
                    if (ChangePassword(UserID, newPassword))
                    {
                        MessageBox.Show("Şifre değiştirme başarılı!");
                    }
                    else
                    {
                        MessageBox.Show("Şifre değiştirme sırasında bir hata oluştu!");
                    }
                }
                else
                {
                    MessageBox.Show("Yeni şifre, eski şifre ile aynı olamaz!");
                }
            }
            else
            {
                MessageBox.Show("Geçerli şifreyi yanlış girdiniz!");
            }
        }

        private bool CheckCurrentPassword(int userID, string currentPassword) // Mevcut şifreyi kontrol eden metod
        {
            
            string connectionString = "Data Source=ONUR\\SQLEXPRESS;Initial Catalog=OyunPlatformuV4;Integrated Security=True";
            string query = "SELECT 1 FROM Users WHERE UserID = @UserID AND Password = @CurrentPassword";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@UserID", userID);
                cmd.Parameters.AddWithValue("@CurrentPassword", currentPassword);

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                bool passwordMatch = reader.HasRows; // Şifrelerin eşleşip eşleşmediğini kontrol etme

                reader.Close();

                return passwordMatch && currentPassword != textBoxNewPassword.Text; // Şifreler eşleşiyorsa ve yeni şifre eski şifre ile aynı değilse true döner
            }
        }

        private bool ChangePassword(int userID, string newPassword)
        {
           
            try
            {
                string connectionString = "Data Source=ONUR\\SQLEXPRESS;Initial Catalog=OyunPlatformuV4;Integrated Security=True";
                string query = "UPDATE Users SET Password = @NewPassword WHERE UserID = @UserID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    cmd.Parameters.AddWithValue("@NewPassword", newPassword);

                    connection.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0; // Güncelleme başarılıysa etkilenen satır sayısı sıfırdan büyük olacaktır, bu yüzden true döner
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda loglama veya uygun bir şekilde yönetme yapılabilir
                MessageBox.Show($"Hata: {ex.Message}");
                return false;
            }
        }



    }
}
