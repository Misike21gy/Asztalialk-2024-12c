using kepekkorbe.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kepekkorbe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void label_jobbra_Click(object sender, EventArgs e)
        {
            Image elso = pictureBox1.Image;
            pictureBox1.Image = pictureBox2.Image;
            pictureBox2.Image = pictureBox3.Image;
            pictureBox3.Image = pictureBox4.Image;
            pictureBox4.Image = pictureBox5.Image;
            pictureBox5.Image = pictureBox6.Image;
            pictureBox6.Image = pictureBox7.Image;
            pictureBox7.Image = pictureBox8.Image;
            pictureBox8.Image = elso;
        }

        private void label_balra_Click(object sender, EventArgs e)
        {
            Image elso = pictureBox1.Image;
            pictureBox1.Image = pictureBox8.Image;
            pictureBox8.Image = pictureBox7.Image;
            pictureBox7.Image = pictureBox6.Image;
            pictureBox6.Image = pictureBox5.Image;
            pictureBox5.Image = pictureBox4.Image;
            pictureBox4.Image = pictureBox3.Image;
            pictureBox3.Image = pictureBox2.Image;
            pictureBox2.Image = elso;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
