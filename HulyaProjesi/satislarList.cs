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
    public partial class satislarList : UserControl
    {
        public satislarList(String id,String satisisim,String satisdeger)
        {
            InitializeComponent();
            this.id = id;
            this.satisisim = satisisim;
            this.satisdeger = satisdeger;
        }
        private String id;

        public String _id
        {
            get { return id; }
            set { id = value; }
        }
        private String satisisim;

        public String _satisisim
        {
            get { return satisisim; }
            set { satisisim = value; }
        }
        private String  satisdeger;

        public String  _satisdeger
        {
            get { return satisdeger; }
            set { satisdeger = value; }
        }

        private void satislarList_Load(object sender, EventArgs e)
        {
            label1.Text = _id;
            label2.Text = _satisisim;
            label3.Text = _satisdeger;
        }
        SqlConnection connection = new SqlConnection(@"Data source=DESKTOP-L8BF6LM\SQLEXPRESS;Initial Catalog=hulyaotomasyon;Integrated Security=True");
        SqlCommand command;
        SqlDataReader reader;
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                command = new SqlCommand("delete from satislar where id=@id", connection);
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
            satislarGuncelle form = new satislarGuncelle(label1.Text, label2.Text, label3.Text);
            form.Show();
        }
    }
}
