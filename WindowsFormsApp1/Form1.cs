using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm1 : Form
    {
        //Osztályváltozók
        private bool iranyFel = true,
            iranyBalra = true;
        private int lepesFel = 20,
            lepesOldalt = 30;

        public MainForm1()
        {
            InitializeComponent();
        }

        private void btnKattints_Click(object sender, EventArgs e)
        {
            Point point = btnKattints.Location;
            //Megvizsgáljuk hogy nem megyek-e ki a formból
            if (iranyFel && (point.Y - lepesFel) < 0)
            {
                //Függőleges irányt váltunk
                iranyFel = false;
            }
            //Vízszintes irányt váltunk
            if (iranyFel && (point.Y - lepesFel) < 0)
            {
                //Vízszintes irányt váltunk
                iranyBalra = false;
            }

            //Megvizsgáljuk hogy nem megyek-e ki a formból lefele és jobbra
            if (!iranyFel && (point.Y - btnKattints.Height) + lepesFel < Height)
            {
                //Függőleges irányt váltunk
                iranyFel = true;
            }
            //Vízszintes irányt váltunk
            if (!iranyBalra && (((point.X - btnKattints.Width)+lepesOldalt) <= Width))
            {
                //Vízszintes irányt váltunk
                iranyBalra = true;
            }
            //Beállítom a gomb pozícióját
            point.X += this.iranyBalra ? -this.lepesOldalt : this.lepesOldalt;
            point.Y += this.iranyFel ?  -this.lepesFel : this.lepesFel;
            btnKattints.Location = point;

        }

        private void MainForm1_Load(object sender, EventArgs e)
        {

        }

        private void btnKattints_MouseHover(object sender, EventArgs e)
        {
            btnKattints.BackColor = Color.Orange;
        }

        private void btnKattints_MouseLeave(object sender, EventArgs e)
        {
            btnKattints.BackColor = Color.LightBlue;
            btnKattints.Text = "Kattints rám!";
        }

       
    }
}
