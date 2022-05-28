using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HulyaProjesi
{
    public partial class anaSayfa : Form
    {
        public anaSayfa()
        {
            InitializeComponent();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            satislar form = new satislar();
            form.Show();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            gunluk form = new gunluk();
            form.Show();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            urunler form = new urunler();
            form.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            personel form = new personel();
            form.Show();
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if(openFileDialog1.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                mediaprogress.Enabled = true;
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.previous();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.next();
        }

        private void mediaprogress_Tick(object sender, EventArgs e)
        {
            try
            {
                bunifuProgressBar1.Value =(int) axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                label2.Text  = "Name:"+axWindowsMediaPlayer1.currentMedia.name.ToString();

            }catch(Exception ex)
            {

            }
        }
    }
}
