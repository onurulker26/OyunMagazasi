
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OyunMagazasi
{
    public partial class YorumYap : Form
    {
        public int UserID { get; set; }
        public int GameID { get; set; }

        public YorumYap(int userID)
        {
            InitializeComponent();
            UserID = userID;
            LoadGames();
        }

       
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profil profil = new Profil(UserID);
            profil.UserID = UserID;
            profil.ShowDialog();
            this.Close();
        }
        private void LoadGames()
        {
            
            string query = "SELECT GameID, GameName FROM Games";

            using (SqlConnection connection = new SqlConnection("Data Source=ONUR\\SQLEXPRESS;Initial Catalog=OyunPlatformuV4;Integrated Security=True"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read()) // Veritabanından okunan her oyunu ComboBox'a ekle
                        {
                            int gameID = reader.GetInt32(0);
                            string gameName = reader.GetString(1);

                            // ComboBox'a oyunları ekle
                            comboBoxGames.Items.Add(new { GameID = gameID, GameName = gameName });
                        }
                    }
                }
            }

            comboBoxGames.DisplayMember = "GameName"; // ComboBox'ta görünen değeri ve değeri belirle
            comboBoxGames.ValueMember = "GameID";
        }

        private void buttonYorumOnay_Click(object sender, EventArgs e)
        {
           
            int rating = (int)numericUpDownRating.Value;
            string comment = richTextBoxYorum.Text;

            GameID = ((dynamic)comboBoxGames.SelectedItem).GameID;

           
            string query = "INSERT INTO Reviews (UserID, GameID, Rating, Comment, DatePosted) " +
                           "VALUES (@UserID, @GameID, @Rating, @Comment, @DatePosted)";

            using (SqlConnection connection = new SqlConnection("Data Source=ONUR\\SQLEXPRESS;Initial Catalog=OyunPlatformuV4;Integrated Security=True"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@GameID", GameID);
                    command.Parameters.AddWithValue("@Rating", rating);
                    command.Parameters.AddWithValue("@Comment", comment);
                    command.Parameters.AddWithValue("@DatePosted", DateTime.Now);

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Yorumunuz başarıyla eklendi!");
        }

     
    }
}
