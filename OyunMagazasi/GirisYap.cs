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
    public partial class GirisYap : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=ONUR\\SQLEXPRESS;Initial Catalog=OyunPlatformuV4;Integrated Security=True");
        public int UserID { get; private set; } // Kullanıcı ID'sini saklamak için özellik


        public GirisYap()
        {
            InitializeComponent();
        }



        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            String username, password;
            username = textBoxUserName.Text;
            password = textBoxPassword.Text;

            SqlCommand cmd = new SqlCommand("SELECT UserID, Username, Password FROM Users WHERE Username=@username AND Password=@password", conn);
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("password", password);

         

            try
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) // Eğer veri varsa
                {
                    reader.Read();

                    int userID = reader.GetInt32(0); // Kullanıcı ID'sini al

                    this.Hide();
                    AnaMenu anamenu = new AnaMenu();
                    anamenu.UserID = userID;
                    anamenu.ShowDialog();
                    this.Close();

                }

                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış");
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu :" + ex.Message);
            }

            finally { conn.Close(); }
        }

        
    }
}
            
            
            

            


        
    

