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
    public partial class personelGuncelle : Form
    {
        public personelGuncelle(String id,String isim,String soyisim,String maas,String email ,String telno,String adres)
        {
            InitializeComponent();
            this.id = id;
            this.isim = isim;
            this.soyisim = soyisim;
            this.maas = maas;
            this.email = email;
            this.telno = telno;
            this.adres = adres;
        }
        private String id;

        public String _id
        {
            get { return id; }
            set { id = value;  }
        }

        private String isim;

        public String _isim
        {
            get { return isim; }
            set { isim = value; value = bunifuTextBox1.Text; }
        }
        private String soyisim;

        public String _soyisim
        {
            get { return soyisim; }
            set { soyisim = value; value = bunifuTextBox2.Text; }
        }
        private String maas;

        public String _maas
        {
            get { return maas; }
            set { maas = value; value = bunifuTextBox3.Text; }
        }

        private String email;

        public String _email
        {
            get { return email; }
            set { email = value; value = bunifuTextBox4.Text; }
        }

        private String telno;

        public String _telno
        {
            get { return telno; }
            set { telno = value; value = bunifuTextBox5.Text; }
        }

        private String adres;

        public String _adres
        {
            get { return adres; }
            set { adres = value; value = bunifuTextBox6.Text; }
        }
        SqlConnection connection = new SqlConnection(@"Data source=DESKTOP-L8BF6LM\SQLEXPRESS;Initial Catalog=hulyaotomasyon;Integrated Security=True");
        SqlCommand command;
        SqlDataReader reader;
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = new SqlCommand("update personel set isim= @isim ,soyisim=@soyisim ,maas=@maas,email=@email,telno=@telno,adres=@adres where id=@id",connection);
                command.Parameters.AddWithValue("isim", bunifuTextBox1.Text);
                command.Parameters.AddWithValue("soyisim", bunifuTextBox2.Text);
                command.Parameters.AddWithValue("maas", bunifuTextBox3.Text);
                command.Parameters.AddWithValue("email", bunifuTextBox4.Text);
                command.Parameters.AddWithValue("telno", bunifuTextBox5.Text);
                command.Parameters.AddWithValue("adres", bunifuTextBox6.Text);
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

        private void personelGuncelle_Load(object sender, EventArgs e)
        {
            bunifuTextBox1.Text = _isim;
            bunifuTextBox2.Text = _soyisim;
            bunifuTextBox3.Text = _maas;
            bunifuTextBox4.Text = _email;
            bunifuTextBox5.Text = _telno;
            bunifuTextBox6.Text = _adres;
        }
    }
}
