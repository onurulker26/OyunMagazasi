
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OyunMagazasi
{
    public partial class IstekListesi : Form
    {
        private string connectionString = "Data Source=ONUR\\SQLEXPRESS;Initial Catalog=OyunPlatformuV4;Integrated Security=True";

        public int UserID { get; set; }

        public IstekListesi(int userID)
        {
            InitializeComponent();
            UserID = userID;

            
            FillGamesComboBox();
        }

        
        private void FillGamesComboBox()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

              
                string query = "SELECT GameID, GameName FROM Games"; // Oyunları getiren sorgu
                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataReader reader = cmd.ExecuteReader();

                
                while (reader.Read()) // Her bir oyunu ComboBox'a ekle
                {
                    int gameID = (int)reader["GameID"];
                    string gameName = (string)reader["GameName"];
                    comboBoxGames.Items.Add(new GameItem(gameID, gameName));
                }

                reader.Close();
            }

            
            comboBoxGames.DisplayMember = "GameName";   // ComboBox'te görünen metni GameName olarak ayarla
        }


      
            

       

        private class GameItem // ComboBox'ta seçilen oyunu temsil eden sınıf
        {
            public int GameID { get; set; }
            public string GameName { get; set; }

            public GameItem(int gameID, string gameName)
            {
                GameID = gameID;
                GameName = gameName;
            }

            public override string ToString()  // ToString metodunu GameID'yi döndürecek şekilde uyarla
            {
                return GameID.ToString(); 
            }
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profil profil = new Profil(UserID);
            profil.UserID = UserID;
            profil.ShowDialog();
            this.Close();
        }

        private void buttonAddToWishlist_Click(object sender, EventArgs e)
        {
            if (comboBoxGames.SelectedItem != null) 
            {
                GameItem selectedGame = (GameItem)comboBoxGames.SelectedItem; // ComboBox'tan seçilen oyunu al
                int gameID = selectedGame.GameID; 

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // İstek listesine ekleme sorgusu
                    string addToWishlistQuery = "INSERT INTO Wishlist (UserID, GameID, DateAdded) VALUES (@UserID, @GameID, GETDATE())";
                    SqlCommand addToWishlistCmd = new SqlCommand(addToWishlistQuery, connection);
                    addToWishlistCmd.Parameters.AddWithValue("@UserID", UserID);
                    addToWishlistCmd.Parameters.AddWithValue("@GameID", gameID);

                    try
                    {
                        addToWishlistCmd.ExecuteNonQuery();
                        MessageBox.Show("Oyun istek listesine eklendi.");
                    }
                    catch (SqlException ex)// SQL hatası kontrolü
                    {
                        if (ex.Number == 2627) // 2627 hatası, benzersiz anahtar ihlali anlamına gelir(onur)
                        {
                            MessageBox.Show("Bu oyun zaten istek listesinde bulunuyor.");
                        }
                        else
                        {
                            MessageBox.Show("Oyun istek listesine eklenirken bir hata oluştu.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir oyun seçin.");
            }
        }


        private void buttonRemoveFromWishlist_Click(object sender, EventArgs e)
        {
            if (comboBoxGames.SelectedItem != null)
            {
                GameItem selectedGame = (GameItem)comboBoxGames.SelectedItem;
                int gameID = selectedGame.GameID;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    
                    string removeFromWishlistQuery = "DELETE FROM Wishlist WHERE UserID = @UserID AND GameID = @GameID";
                    SqlCommand removeFromWishlistCmd = new SqlCommand(removeFromWishlistQuery, connection);
                    removeFromWishlistCmd.Parameters.AddWithValue("@UserID", UserID);
                    removeFromWishlistCmd.Parameters.AddWithValue("@GameID", gameID);

                    int rowsAffected = removeFromWishlistCmd.ExecuteNonQuery();  // Etkilenen satır sayısını kontrol et

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Oyun istek listesinden kaldırıldı.");
                    }
                    else
                    {
                        MessageBox.Show("Oyun istek listesinden kaldırılırken bir hata oluştu.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir oyun seçin.");
            }
        }
    }
    
    }


