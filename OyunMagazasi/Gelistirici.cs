using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OyunMagazasi
{
    public partial class Gelistirici : Form
    {
        public int UserID{get;set; }    // Kullanıcı ID'sini saklamak için özellik

        public Gelistirici()
        {
            InitializeComponent();
            listView1.View = View.Details;
            LoadDeveloperData();

            // ListView sütunları eklenir ve başlıkları belirlenir...
            listView1.Columns.Add("Gelistirici", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Oyun Adı", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Tür", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Cikis Tarihi", -2, HorizontalAlignment.Left);

            // Sütun genişlikleri belirlenir bazı şeyler sığmıyordu ondan yaptım.
            listView1.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.None);
            listView1.Columns[0].Width = 70;
            listView1.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.None);
            listView1.Columns[1].Width = 70;
            listView1.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.Columns[2].AutoResize(ColumnHeaderAutoResizeStyle.None);
            listView1.Columns[2].Width = 70;
            listView1.Columns[2].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.Columns[3].AutoResize(ColumnHeaderAutoResizeStyle.None);
            listView1.Columns[3].Width = 150;
           


        }
        private void Gelistirici_Load(object sender, EventArgs e)
        {
           
        }
        private void LoadDeveloperData()
        {
            string connectionString = "Data Source=ONUR\\SQLEXPRESS;Initial Catalog=OyunPlatformuV4;Integrated Security=True";

            // SQL sorgusu - Geliştiriciler, Oyun Geliştiricileri ve Oyunları birleştirilir
            string query = "SELECT * FROM Developers JOIN GameDevelopers ON Developers.DeveloperID = GameDevelopers.DeveloperID JOIN Games ON GameDevelopers.GameID = Games.GameID"; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //verileri oku
                    string developerName = reader["DeveloperName"].ToString();
                    string gameName = reader["GameName"].ToString() ;
                    string genre = reader["Genre"].ToString();
                    DateTime releaseDate = Convert.ToDateTime(reader["ReleaseDate"]);

                    // ListView öğesi oluştur
                    ListViewItem item = new ListViewItem(developerName);
                    item.SubItems.Add(gameName); 
                    item.SubItems.Add(genre); 
                    item.SubItems.Add(releaseDate.ToString("dd/MM/yyy"));

                    listView1.Items.Add(item);  // ListView'a öğeyi ekle
                }

                reader.Close();
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaMenu anamenu = new AnaMenu();
            anamenu.UserID = UserID;
            anamenu.ShowDialog();
            this.Close();
        }
    }
}
