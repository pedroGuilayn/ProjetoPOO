using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPOO
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

     

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = "C:\\Users\\pedro\\Documents\\Lightshot\\biomedicina.wav";
                player.Load();
                player.PlaySync();
            }
            catch (Win32Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }

        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = "C:\\Users\\pedro\\Documents\\Lightshot\\casacomigo.wav";
                player.Load();
                player.PlaySync();
            }
            catch (Win32Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}


