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
    public partial class KayitOl : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=ONUR\\SQLEXPRESS;Initial Catalog=OyunPlatformuV4;Integrated Security=True");
        public KayitOl()
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

        private void buttonKayit_Click(object sender, EventArgs e)
        {
            String username, password, email;
            username = textBoxUserName.Text;
            password = textBoxPassword.Text;
            email = textBoxEmail.Text;


            try
            {
                conn.Open();
                
                SqlCommand cmd = new SqlCommand("INSERT INTO Users (Username,Password,Email,DateRegistered)  VALUES(@username,@password,@email,GETDATE())", conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@email", email);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Kaydiniz olusturuldu");

            }

            catch (SqlException ex)
            {

                if (ex.Number == 2627)
                {
                    // 2627 numaralı hata, bir benzersizlik ihlali anlamına gelir.
                    MessageBox.Show("Bu kullanıcı adı veya e-posta adresi zaten kullanımda. Lütfen başka bir tane deneyin.");
                }

                else
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);

                }
            }
            finally
            {
                conn.Close();
            }



        }





        }
    }

