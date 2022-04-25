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
    public partial class gunlukEkle : Form
    {
        public gunlukEkle()
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
                command = new SqlCommand("insert into gunluk(gunlukSatis) values(@isim)", connection);
                command.Parameters.AddWithValue("isim", bunifuTextBox1.Text);
           
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
    }
}
