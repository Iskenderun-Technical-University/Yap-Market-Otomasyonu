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
    public partial class gunlukList : UserControl
    {
        public gunlukList(String id,String gunluksatis)
        {
            InitializeComponent();
            this.id = id;
            this.gunluksatis = gunluksatis;
        }
        private String id;

        public String _id
        {
            get { return id; }
            set { id = value; }
        }
        private String gunluksatis;

        public String _gunluksatis
        {
            get { return gunluksatis; }
            set { gunluksatis = value; }
        }

        private void gunlukList_Load(object sender, EventArgs e)
        {
            label1.Text = _id;
            label2.Text = _gunluksatis;
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
            catch (Exception ex)
            {
                MessageBox.Show("Bir Hata Oluştu" + ex);

            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            gunlukGuncelle form = new gunlukGuncelle(label1.Text, label2.Text);
            form.Show();
        }
    }
}
