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
    public partial class girisPaneli : Form
    {
        public girisPaneli()
        {
            InitializeComponent();
        }

        private void bunifuTextBox2_Enter(object sender, EventArgs e)
        {
            
            if(bunifuTextBox2.Text=="")
            {
              
            }
            else
            {
                bunifuTextBox2.PasswordChar = '*';
            }
           
        }

    
        

     

        private void bunifuTextBox2_TextChanged_1(object sender, EventArgs e)
        {
            if (bunifuTextBox2.Text == "")
            {
                bunifuTextBox2.UseSystemPasswordChar = false;
            }
            else
            {
                bunifuTextBox2.UseSystemPasswordChar = true;
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            kayitPaneli form = new kayitPaneli();
            form.Show();
            this.Hide();
        }

        bool move = false;
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
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            try
            { 
           if(bunifuTextBox1.Text==""|| bunifuTextBox2.Text=="")
            {
                    MessageBox.Show("Lütfen Boşlukları Doldurunuz!");
                }
                else
                {
                    connection.Open();
                    command = new SqlCommand("select * from girisTablo where kullaniciadi=@kullaniciadi and sifre=@sifre", connection);
                    command.Parameters.AddWithValue("kullaniciadi", bunifuTextBox1.Text);
                    command.Parameters.AddWithValue("sifre", bunifuTextBox2.Text);


                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {

                        anaSayfa form = new anaSayfa();
                        form.Show();
                        this.Hide();

                    }

                    else
                    {

                        MessageBox.Show("Giriş Yapılamadı kullanıcı adı veya şifre yanlış!");
                    }
                    connection.Close();
                    reader.Close();
                }

               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Bağlantı Hatası" + ex);
            }
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
