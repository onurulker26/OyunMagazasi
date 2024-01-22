using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OyunMagazasi
{
    public partial class Magaza : Form
    {

        public int UserID { get; set; }     // Kullanıcı ID'sini saklamak için özellik
        public Magaza()
        {
            InitializeComponent();
            GetGameData();
        }

        public void GetGameData()  // Oyun verilerini veritabanından alıp ListView'a ekleyen metod
        {
            string connectionString = "Data Source=ONUR\\SQLEXPRESS;Initial Catalog=OyunPlatformuV4;Integrated Security=True";
            string query = "SELECT GameID, GameName, Genre, Price, ImageData, ReleaseDate FROM Games"; // Oyun verilerini almak için SQL sorgusu

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader(); // Verileri okumak için SqlDataReader kullan
                while (reader.Read())  // Veritabanından okunan her bir oyun için işlem yap
                {
                    int gameId = reader.GetInt32(0);
                    string gameName = reader.GetString(1);
                    string genre = reader.GetString(2);
                    decimal price = reader.GetDecimal(3);
                    byte[] imageData = (byte[])reader[4];
                    DateTime releaseDate = reader.GetDateTime(5);

                    MemoryStream ms = new MemoryStream(imageData);  // Byte dizisinden resim oluştur
                    Image image = Image.FromStream(ms);

                    imageList1.Images.Add(image);
                    ListViewItem item = new ListViewItem { ImageIndex = imageList1.Images.Count - 1 };

                    // Oyun bilgilerini bir nesnede saklamak için yazdım(onur)
                    var gameInfo = new
                    {
                        Id = gameId,
                        Name = gameName,
                        Genre = genre,
                        Price = price,
                        ReleaseDate = releaseDate
                    };
                    
                    // Bu bilgileri ListViewItem'ın Tag özelliğinde saklanmak için yazdım.(onur)
                    item.Tag = gameInfo;

                    listView1.Items.Add(item);
                }

                reader.Close();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) // ListView'da öğeye tıklanma olayı
        {

            var selectedItem = listView1.SelectedItems[0]; // Seçilen öğeyi al


            var gameInfo = (dynamic)selectedItem.Tag;   // Seçilen oyunun bilgilerini al
            this.Hide();

            var oyunDetaylari = new OyunDetaylari(UserID, gameInfo);   // Mevcut formu gizle, OyunDetaylari formunu aç ve kullanıcı ID'si ve oyun bilgilerini ilet.
            oyunDetaylari.OyunDetaylariGoster(UserID,gameInfo);
            oyunDetaylari.ShowDialog();
            this.Close();


           

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaMenu anamenu = new AnaMenu();
            anamenu.UserID = UserID;
            anamenu.ShowDialog();
            this.Close();
        }

       




       


    }
}
