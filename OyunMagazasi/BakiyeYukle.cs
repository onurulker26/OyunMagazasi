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
   
    public partial class BakiyeYukle : Form
    {
        public int UserID { get; set; } // Kullanıcı ID'sini saklamak için özellik
        public BakiyeYukle()
        {
            InitializeComponent();
        }

        private void buttonYukle_Click(object sender, EventArgs e)
        {
            decimal amount = 0;  // Yüklenecek miktarı saklamak için değişken
            bool isParsed = Decimal.TryParse(textBox1.Text, out amount);// TextBox'tan alınan miktarı decimal türüne dönüştürmeye çalış

            if (isParsed) // Dönüştürme başarılı ise
            {
                AddBalance(UserID, amount); // Kullanıcının bakiyesine miktarı ekleyen metod çağrılır

            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir miktar girin.");
            }
            
        }


        public void AddBalance(int userID, decimal amount)  // Kullanıcının bakiyesine miktar ekleyen metod
        {
            string connectionString = "Data Source=ONUR\\SQLEXPRESS;Initial Catalog=OyunPlatformuV4;Integrated Security=True";
            string query = $"UPDATE Users SET Balance = Balance + @Amount WHERE UserID = @UserId"; // Veritabanında kullanıcının bakiyesini güncelleyen SQL sorgusu

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", UserID);
                command.Parameters.AddWithValue("@Amount", amount);

                connection.Open();
                

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0) // Eğer herhangi bir satır güncellendiyse
                {
                    MessageBox.Show("Bakiye yükleme işlemi başarılı!");
                }
                else
                {
                    MessageBox.Show("Bakiye yükleme işlemi başarısız. Lütfen tekrar deneyin.");
                }



            }


        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaMenu anaMenu = new AnaMenu();
            anaMenu.UserID = UserID;    
            anaMenu.ShowDialog();   
            this.Close();

        }
    }
}
