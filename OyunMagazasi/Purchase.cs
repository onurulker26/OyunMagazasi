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
    public partial class Purchase : Form
    {
            public int UserID { get; set; }
        
        public Purchase(int userID) // Satın alımlar formu oluşturulurken kullanıcının kimliğini alarak başlatan constructor
        
        {
            InitializeComponent();
            UserID = userID;
            GetInfo(); // Satın alma geçmişi bilgilerini alacak metodu çağırma..
        }

        public void GetInfo()
        {
            // Satın alma geçmişi sorgusu
            string connectionString = "Data Source=ONUR\\SQLEXPRESS;Initial Catalog=OyunPlatformuV4;Integrated Security=True";
            string query = "SELECT P.PurchaseID, U.Username, G.GameName, P.PurchaseDate " +
                           "FROM Purchases P " +
                           "INNER JOIN Users U ON P.UserID = U.UserID " +
                           "INNER JOIN Games G ON P.GameID = G.GameID " +
                           "WHERE U.UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@UserID", UserID);

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                
                

                listBoxPurchases.Items.Clear(); 

                while (reader.Read())
                {
                    string purchaseInfo = $"{reader["GameName"]} - {reader["PurchaseDate"]}"; // Satın alma geçmişi bilgilerini birleştirip listbox'a ekleyerek gösterme
                    listBoxPurchases.Items.Add(purchaseInfo);
                }

                reader.Close();
            }
        }

    
        private void backButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            Profil profil = new Profil(UserID);
            profil.ShowDialog();
            this.Close();
        }
    }
}

