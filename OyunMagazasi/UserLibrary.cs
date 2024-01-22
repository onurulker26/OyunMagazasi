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
    public partial class UserLibrary : Form
    {
        public int UserID { get; set; }
       
        public UserLibrary()
        {
            InitializeComponent();

            // ListView ayarları
            listView1.View = View.Details;
            listView1.Columns.Add("Oyun Adı", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Tür", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Yayın Tarihi", -2, HorizontalAlignment.Left);
       


        }
        private void UserLibrary_Load(object sender, EventArgs e)
        {
            GetGameData();

            // ListView sütun genişliklerinin otomatik ayarlanması
            listView1.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.None);
            listView1.Columns[0].Width = 70;
            listView1.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.None);
            listView1.Columns[1].Width = 70;
            listView1.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.Columns[2].AutoResize(ColumnHeaderAutoResizeStyle.None);
            listView1.Columns[2].Width = 150;
                
                
                
          
          
        }
       
        private void GetGameData()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=ONUR\\SQLEXPRESS;Initial Catalog=OyunPlatformuV4;Integrated Security=True"))
            {
                connection.Open();

                string query = "SELECT Games.GameID, Games.GameName, Games.Genre, Games.ReleaseDate FROM Games INNER JOIN UserLibrary ON Games.GameID = UserLibrary.GameID WHERE UserLibrary.UserID = @UserID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {


                        while (reader.Read())
                        {
                            int gameId = reader.GetInt32(0);
                            string gameName = reader.GetString(1);
                            string genre = reader.GetString(2);
                            DateTime releaseDate = reader.GetDateTime(3);
                            

                           

                            ListViewItem item = new ListViewItem(gameName);
                            item.SubItems.Add(genre);
                            item.SubItems.Add(releaseDate.ToString("dd/MM/yyy"));
                            listView1.Items.Add(item);
                           

                            

                        }
                        reader.Close();
                    }
                }
            }



        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaMenu anamenu= new AnaMenu();
            anamenu.UserID=UserID;
            anamenu.ShowDialog();
            this.Close();
        }

       






    }
}