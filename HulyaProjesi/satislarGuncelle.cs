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
    public partial class satislarGuncelle : Form
    {
        public satislarGuncelle(String id,String satisIsim,String satisFiyat)
        {
            InitializeComponent();
            this.id = id;
            this.satisIsim = satisIsim;
            this.satisFiyat = satisFiyat;
        }
        private String id;

        public String _id
        {
            get { return id; }
            set { id = value; }
        }

        private String satisIsim;

        public String _satisIsim
        {
            get { return satisIsim; }
            set { satisIsim = value; }
        }
        private String satisFiyat;

        public String _satisFiyat
        {
            get { return satisFiyat; }
            set { satisFiyat = value; }
        }
        SqlConnection connection = new SqlConnection(@"Data source=DESKTOP-L8BF6LM\SQLEXPRESS;Initial Catalog=hulyaotomasyon;Integrated Security=True");
        SqlCommand command;
        SqlDataReader reader;

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = new SqlCommand("update satislar set satisIsim= @isim ,satisFiyat=@soyisim  where id=@id", connection);
                command.Parameters.AddWithValue("isim", bunifuTextBox1.Text);
                command.Parameters.AddWithValue("soyisim", bunifuTextBox2.Text);
                
                command.Parameters.AddWithValue("id", Convert.ToInt32(_id));
                command.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Güncellendi");
                connection.Close();
                

            }
            catch (Exception ex)
            {

                MessageBox.Show("Bilinmeyen Bir Hata Oluştu:" + ex);
            }
        }

        private void satislarGuncelle_Load(object sender, EventArgs e)
        {
            bunifuTextBox1.Text = _satisIsim;
            bunifuTextBox2.Text = _satisFiyat;
     
        }
    }
}
