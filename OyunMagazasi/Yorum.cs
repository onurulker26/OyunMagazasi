using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OyunMagazasi
{
    public partial class Yorum : Form
    {
        public int UserID { get; set; }

        public Yorum(int userID)
        {
            InitializeComponent();
            UserID = userID;
            LoadAllReviews();
            InitializeContextMenu();
        }

        private ContextMenu contextMenu;

        private void InitializeContextMenu()
        {
            contextMenu = new ContextMenu();
            MenuItem deleteMenuItem = new MenuItem("Yorumu Sil", OnDeleteReviewClicked);
            contextMenu.MenuItems.Add(deleteMenuItem);
        }

        private void LoadAllReviews()
        {
            // Veritabanından bütün incelemeleri çekmek için SQL sorgusu
            string query = "SELECT Reviews.ReviewID, Reviews.Rating, Reviews.Comment, Reviews.DatePosted, Games.GameName, Users.Username " +
                           "FROM Reviews " +
                           "INNER JOIN Games ON Reviews.GameID = Games.GameID " +
                           "INNER JOIN Users ON Reviews.UserID = Users.UserID " +
                           "ORDER BY Reviews.DatePosted DESC";

            using (SqlConnection connection = new SqlConnection("Data Source=ONUR\\SQLEXPRESS;Initial Catalog=OyunPlatformuV4;Integrated Security=True"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int reviewID = reader.GetInt32(0);
                            int rating = reader.GetInt32(1);
                            string comment = reader.GetString(2);
                            DateTime datePosted = reader.GetDateTime(3);
                            string gameName = reader.GetString(4);
                            string username = reader.GetString(5);

                            listBoxReviews.Items.Add($"{username} - {gameName} - Rating: {rating}, Comment: {comment}, Date: {datePosted} (ID: {reviewID})");
                        }
                    }
                }
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

        private void listBoxReviews_MouseDown(object sender, MouseEventArgs e)  // ListBox üzerinde sağ tıklandığında çalışan metod
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = listBoxReviews.IndexFromPoint(e.Location);
                listBoxReviews.SelectedIndex = index;

                if (index != -1)
                {
                    contextMenu.Show(listBoxReviews, e.Location);
                }
            }
        }

        private void OnDeleteReviewClicked(object sender, EventArgs e) // İncelemeyi silme işlemi
        {
            string selectedReview = listBoxReviews.SelectedItem.ToString();
            int reviewID = int.Parse(selectedReview.Split(' ').Last().Trim(')')); // ID'yi al

            // Kullanıcının kendi yorumlarını çek
            List<int> userReviews = GetUserReviews(UserID);

            // Eğer seçilen yorum, kullanıcının yorumları arasında ise silme işlemi
            if (userReviews.Contains(reviewID))
            {
                DeleteReview(reviewID);
                listBoxReviews.Items.Remove(selectedReview);
                MessageBox.Show("Yorum başarıyla silindi.");
            }
            else
            {
                MessageBox.Show("Bu yorumu silemezsiniz, çünkü bu yorum sizin değil.");
            }
        }

        private void DeleteReview(int reviewID)  // İncelemeyi silen metod
        {
            string deleteQuery = "DELETE FROM Reviews WHERE ReviewID = @ReviewID";

            using (SqlConnection connection = new SqlConnection("Data Source=ONUR\\SQLEXPRESS;Initial Catalog=OyunPlatformuV4;Integrated Security=True"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@ReviewID", reviewID);

                    // Silme işlemini gerçekleştir
                    command.ExecuteNonQuery();
                }
            }
        }

        private List<int> GetUserReviews(int userID)
        {
            List<int> userReviews = new List<int>();

            string query = "SELECT ReviewID FROM Reviews WHERE UserID = @UserID";

            using (SqlConnection connection = new SqlConnection("Data Source=ONUR\\SQLEXPRESS;Initial Catalog=OyunPlatformuV4;Integrated Security=True"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int reviewID = reader.GetInt32(0);
                            userReviews.Add(reviewID);
                        }
                    }
                }
            }

            return userReviews;
        }

        
    }
}
