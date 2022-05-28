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
    public partial class personelEkle : Form
    {
        public personelEkle()
        {
            InitializeComponent();
        }

        private void bunifuTextBox4_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection connection = new SqlConnection(@"Data source=DESKTOP-L8BF6LM\SQLEXPRESS;Initial Catalog=hulyaotomasyon;Integrated Security=True");
        SqlCommand command;
        SqlDataReader reader;
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = new SqlCommand("insert into personel(isim,soyisim,maas,email,telno,adres) values(@isim,@soyisim,@maas,@email,@telno,@adres)",connection);
                command.Parameters.AddWithValue("isim", bunifuTextBox1.Text);
                command.Parameters.AddWithValue("soyisim", bunifuTextBox2.Text);
                command.Parameters.AddWithValue("maas", bunifuTextBox3.Text);
                command.Parameters.AddWithValue("email", bunifuTextBox4.Text);
                command.Parameters.AddWithValue("telno", bunifuTextBox5.Text);
                command.Parameters.AddWithValue("adres", bunifuTextBox6.Text);
                MessageBox.Show("Kayıt Başarıyla Eklendi");
                command.ExecuteNonQuery();
                connection.Close();
                personel.ActiveForm.Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Bir hatadan dolayı eklenmedi" + ex);
            }
        }

        private void personelEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
