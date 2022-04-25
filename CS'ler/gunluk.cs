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
    public partial class gunluk : Form
    {
        public gunluk()
        {
            InitializeComponent();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void gunluk_Load(object sender, EventArgs e)
        {
            refresh();
        }
        SqlConnection connection = new SqlConnection(@"Data source=DESKTOP-L8BF6LM\SQLEXPRESS;Initial Catalog=hulyaotomasyon;Integrated Security=True");
        SqlCommand command;
        SqlDataReader reader;
        public void refresh()
        {

            try
            {
                flowLayoutPanel1.Controls.Clear();
                connection.Open();
                command = new SqlCommand("select * from gunluk", connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    flowLayoutPanel1.Controls.Add(new gunlukList(Convert.ToString(reader[0]), Convert.ToString(reader[1])));



                }
                connection.Close();
            }
            catch (Exception ex)
            {


            }

        }

        private void controlFlow_Tick(object sender, EventArgs e)
        {
            refresh();
            
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            gunlukEkle form = new gunlukEkle();
            form.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
