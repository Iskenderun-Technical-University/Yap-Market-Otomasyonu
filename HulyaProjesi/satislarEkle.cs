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
    public partial class satislarEkle : Form
    {
        public satislarEkle()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data source=DESKTOP-L8BF6LM\SQLEXPRESS;Initial Catalog=hulyaotomasyon;Integrated Security=True");
        SqlCommand command;
        SqlDataReader reader;
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = new SqlCommand("insert into satislar(satisIsim,satisFiyat) values(@isim,@soyisim)", connection);
                command.Parameters.AddWithValue("isim", bunifuTextBox1.Text);
                command.Parameters.AddWithValue("soyisim", bunifuTextBox2.Text);
               
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

        private void satislarEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
