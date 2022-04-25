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
    public partial class gunlukGuncelle : Form
    {
        public gunlukGuncelle(String id,String satistoplam)
        {
            InitializeComponent();
            this.id = id;
            this.satistoplam = satistoplam;
        }
        private String id;

        public String _id
        {
            get { return id; }
            set { id = value; }

        }
        private String satistoplam;

        public String _satistoplam
        {
            get { return satistoplam; }
            set { satistoplam = value; }
        }
        SqlConnection connection = new SqlConnection(@"Data source=DESKTOP-L8BF6LM\SQLEXPRESS;Initial Catalog=hulyaotomasyon;Integrated Security=True");
        SqlCommand command;
        SqlDataReader reader;
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = new SqlCommand("update gunluk set isim= @isim  where id=@id", connection);
                command.Parameters.AddWithValue("isim", bunifuTextBox1.Text);
         
                command.Parameters.AddWithValue("id", Convert.ToInt32(_id));
                command.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Güncellendi");
                connection.Close();
                personel.ActiveForm.Refresh();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Bilinmeyen Bir Hata Oluştu:" + ex);
            }
        }

        private void gunlukGuncelle_Load(object sender, EventArgs e)
        {
            bunifuTextBox1.Text = _satistoplam;
        }
    }
}
