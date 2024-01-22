using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OyunMagazasi
{
    public partial class İstekTablom : Form
    {
            public int UserID { get; set; }
        public İstekTablom(int userID)  // Kullanıcı ID'sini saklamak için özellik
        {
            InitializeComponent();
            UserID = userID;
            LoadWishlistItems();
        }

        private void LoadWishlistItems()
        {
            string connectionString = "Data Source=ONUR\\SQLEXPRESS;Initial Catalog=OyunPlatformuV4;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Games.GameID, GameName, ImageData, DateAdded FROM Wishlist " + // İstek listesi ve oyun bilgilerini getiren sorgu
                               "INNER JOIN Games ON Wishlist.GameID = Games.GameID " +
                               "WHERE Wishlist.UserID = @UserID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read()) // Oyun bilgilerini oku
                        {
                            int gameID = reader.GetInt32(0);
                            string gameName = reader.GetString(1);
                            byte[] imageData = reader["ImageData"] as byte[];
                            DateTime dateAdded = reader.GetDateTime(3);

                            DisplayGameInfo(gameID, gameName, imageData, dateAdded);  // Oyun bilgilerini görüntüleme metodunu çağır
                        }
                    }
                }
            }
        }

        private void DisplayGameInfo(int gameID, string gameName, byte[] imageData, DateTime dateAdded)
        {
            PictureBox pictureBox = new PictureBox // PictureBox oluştur
            {
                Size = new Size(100, 100),
                BorderStyle = BorderStyle.FixedSingle,
                Tag = gameID,
                Image = (imageData != null) ? ByteArrayToImage(imageData) : null,
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            ToolTip toolTip = new ToolTip();  // ToolTip oluştur ve oyun bilgilerini göster
            //kullanıcı arayüzünde bir denetimin üzerine gelindiğinde veya üzerine gelindiğinde belirli bilgilerin görüntülenmesini sağlayan bir yardımcı araçtır. 
            toolTip.SetToolTip(pictureBox, $"Oyun Adı: {gameName}\nEklenme Tarihi: {dateAdded}");

            flowLayoutPanelGames.Controls.Add(pictureBox); // FlowLayoutPanel'e PictureBox eklendi.
            
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }


        

        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AnaMenu anamenu = new AnaMenu();
            anamenu.UserID = UserID;
            anamenu.ShowDialog();
            this.Close();
        }
    }
}
