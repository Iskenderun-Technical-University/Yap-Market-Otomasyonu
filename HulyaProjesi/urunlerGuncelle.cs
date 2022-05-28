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
    public partial class urunlerGuncelle : Form
    {
        public urunlerGuncelle(String id,String urunIsim,String urunFiyat,String urunStok,String urunBoyut)
        {
            InitializeComponent();
            this.id = id;
            this.urunIsim = urunIsim;
            this.urunFiyat = urunFiyat;
            this.urunStok = urunStok;
            this.urunBoyut = urunBoyut;
        }
        private String id;

        public String _id
        {
            get { return id; }
            set { id = value; }
        }
        private String urunIsim;

        public String _urunIsim
        {
            get { return urunIsim; }
            set { urunIsim = value; }
        }
        private String urunFiyat;

        public String _urunFiyat
        {
            get { return urunFiyat; }
            set { urunFiyat = value; }
        }
        private String urunStok;

        public String _urunStok
        {
            get { return urunStok; }
            set { urunStok = value; }
        }

        private String urunBoyut;

        public String _urunBoyut
        {
            get { return urunBoyut; }
            set { urunBoyut = value; }
        }


        SqlConnection connection = new SqlConnection(@"Data source=DESKTOP-L8BF6LM\SQLEXPRESS;Initial Catalog=hulyaotomasyon;Integrated Security=True");
        SqlCommand command;
        SqlDataReader reader;

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = new SqlCommand("update urunler set urunIsim= @isim ,urunFiyat=@soyisim ,urunStok=@maas,urunBoyut=@email where id=@id", connection);
                command.Parameters.AddWithValue("isim", bunifuTextBox1.Text);
                command.Parameters.AddWithValue("soyisim", bunifuTextBox2.Text);
                command.Parameters.AddWithValue("maas", bunifuTextBox3.Text);
                command.Parameters.AddWithValue("email", bunifuTextBox4.Text);
               
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

        private void urunlerGuncelle_Load(object sender, EventArgs e)
        {
            bunifuTextBox1.Text = _urunIsim;
            bunifuTextBox2.Text = _urunFiyat;
            bunifuTextBox3.Text = _urunStok;
            bunifuTextBox4.Text = _urunBoyut;
    
        }
    }
}
