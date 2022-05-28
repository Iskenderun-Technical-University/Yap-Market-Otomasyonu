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
    public partial class personel : Form
    {
        public personel()
        {
            InitializeComponent();
        }
       
        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            personelEkle form = new personelEkle();
            form.Show();
            
        }

        private void personel_Load(object sender, EventArgs e)
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
                command = new SqlCommand("select * from personel",connection);
                reader = command.ExecuteReader();
                while(reader.Read())
                {
                    flowLayoutPanel1.Controls.Add(new personelList(Convert.ToString(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]), Convert.ToString(reader[3]), Convert.ToString(reader[4]), Convert.ToString(reader[5]), Convert.ToString(reader[6])));



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

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
