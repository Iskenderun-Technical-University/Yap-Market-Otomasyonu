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
    public partial class personelList : UserControl
    {
        public personelList(String id,String isim,String soyisim,String maas,String email,String telno,String adres)
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
            set { id = value;  label1.Text=value; }
        }

        private String isim;

        public String _isim
        {
            get { return isim; }
            set { isim = value; label2.Text=value; }
        }
        private String soyisim;

        public String _soyisim
        {
            get { return soyisim; }
            set { soyisim = value;  label3.Text=value; }
        }
        private String maas;

        public String _maas
        {
            get { return maas; }
            set { maas = value; label4.Text=value; }
        }

        private String email;

        public String _email
        {
            get { return email; }
            set { email = value;  label5.Text=value; }
        }

        private String telno;

        public String _telno
        {
            get { return telno; }
            set { telno = value;  label6.Text=value; }
        }

        private String adres;

        public String _adres
        {
            get { return adres; }
            set { adres = value;  label7.Text=value; }
        }
        SqlConnection connection = new SqlConnection(@"Data source=DESKTOP-L8BF6LM\SQLEXPRESS;Initial Catalog=hulyaotomasyon;Integrated Security=True");
        SqlCommand command;
        SqlDataReader reader;
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                command = new SqlCommand("delete from personel where id=@id", connection);
                command.Parameters.AddWithValue("id", _id);
                command.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Sildiniz");
                connection.Close();
                personel.ActiveForm.Refresh();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Bir Hata Oluştu" + ex);

            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            personelGuncelle form = new personelGuncelle(label1.Text,label2.Text,label3.Text,label4.Text,label5.Text,label6.Text,label7.Text);
            form.Show();
        }

        private void personelList_Load(object sender, EventArgs e)
        {
            label1.Text = _id;
            label2.Text = _isim;
            label3.Text = _soyisim;
            label4.Text = _maas;
            label5.Text = _email;
            label6.Text = _telno;
            label7.Text = _adres;
        }
    }
}
