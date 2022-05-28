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
    public partial class urunlerList : UserControl
    {
        public urunlerList(String id,String urunIsim,String urunFiyat,String urunStok,String urunBoyut)
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
        private void urunlerList_Load(object sender, EventArgs e)
        {
            label1.Text = _id;
            label2.Text = _urunIsim;
            label3.Text = _urunFiyat;
            label4.Text = _urunStok;
            label5.Text = _urunBoyut;
             
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            urunlerGuncelle form = new urunlerGuncelle(label1.Text, label2.Text, label3.Text, label4.Text, label5.Text);
            form.Show();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                command = new SqlCommand("delete from urunler where id=@id", connection);
                command.Parameters.AddWithValue("id", _id);
                command.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Sildiniz");
                connection.Close();
                personel.ActiveForm.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir Hata Oluştu" + ex);

            }
        }
    }
}
