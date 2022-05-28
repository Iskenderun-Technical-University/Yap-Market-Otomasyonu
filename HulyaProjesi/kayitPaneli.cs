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

namespace HulyaProjesi
{
    public partial class kayitPaneli : Form
    {
        public kayitPaneli()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuTextBox3_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            girisPaneli form = new girisPaneli();
            form.Show();
            this.Hide();
        }

        bool move;
        int mouse_x;
        int mouse_y;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
        
        }
        SqlConnection connection = new SqlConnection(@"Data source=DESKTOP-L8BF6LM\SQLEXPRESS;Initial Catalog=hulyaotomasyon;Integrated Security=True");
        SqlCommand command;
        SqlDataReader reader;
        private void bunifuButton2_Click_1(object sender, EventArgs e)
        {
            if (bunifuTextBox1.Text == "" || bunifuTextBox2.Text == "" || bunifuTextBox3.Text == "")
            {
                MessageBox.Show("Lütfen boşlukları doldurunuz");


            }
            else
            {
                try
                {
                    connection.Open();
                    command = new SqlCommand("insert into girisTablo(email,kullaniciadi,sifre) values(@email,@kullaniciadi,@sifre)", connection);
                    command.Parameters.AddWithValue("email", bunifuTextBox1.Text);
                    command.Parameters.AddWithValue("kullaniciadi", bunifuTextBox2.Text);
                    command.Parameters.AddWithValue("sifre", bunifuTextBox3.Text);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Başarıyla Kayıt Yapıldı!");
                    
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Bağlantı hatası" + ex);
                }

            }
        }

        private void bunifuTextBox3_TextChanged_1(object sender, EventArgs e)
        {
            if (bunifuTextBox3.Text == "")
            {
                bunifuTextBox3.UseSystemPasswordChar = false;
            }
            else
            {
                bunifuTextBox3.UseSystemPasswordChar = true;
            }
        }
    }
}
