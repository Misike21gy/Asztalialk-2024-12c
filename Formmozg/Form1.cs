using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formmozg
{
    public partial class Form1 : Form
    {
        //Osztályváltozók
        private int valtMagas = 10,
            valtSzeles = 10,
            maxWidth = 0,
            maxHeight = 0,
            minWidth = 0,
            minHeight = 0;

        private double opValtoz=0.2;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKozep_Click(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void btnLe_Click(object sender, EventArgs e)
        {
            //A formot lefelé visszük a ValtMAgas értékkel, ha a form nem megy ki a képernyőről
            Location = new Point(Location.X, (Location.Y + Height + valtMagas) >= Screen.GetWorkingArea(this).Height ? Location.Y : Location.Y + valtMagas);

        }

        private void btnAlul_Click(object sender, EventArgs e)
        {
            Location = new Point(Location.X, Screen.GetWorkingArea(this).Height - Height);

        }

        private void btnBalszel_Click(object sender, EventArgs e)
        {
            //A formot balra szélre visszük
            Location=new Point(0,Location.Y);
        }

        private void btnBalra_Click(object sender, EventArgs e)
        {
            //Balra igazítjuk
            Location = new Point(Location.X - valtSzeles < 0 ? 0 : Location.X-valtSzeles,Location.Y);
        }

        private void btnJobb_Click(object sender, EventArgs e)
        {
            //Jobbra igazítjuk
            Location = new Point(Location.X + Width + valtSzeles >= Screen.PrimaryScreen.Bounds.Width ? Screen.PrimaryScreen.Bounds.Width - Width : Location.X + valtSzeles, Location.Y);
        }

        private void btnJobbszel_Click(object sender, EventArgs e)
        {
            //A formot jobbra szélre illesztjük
            Location=new Point(Screen.PrimaryScreen.Bounds.Width-Width, Location.Y);
        }

        private void btnAtlatNo_Click(object sender, EventArgs e)
        {
            //Az átlátszóság növelése
            Opacity += opValtoz;
        }

        private void btnAtlatCsok_Click(object sender, EventArgs e)
        {
            //Az átlátszóság csökkentése
            Opacity -= opValtoz;
        }

        private void btnFel_Click(object sender, EventArgs e)
        {
            //A formot felfelé visszük a ValtMAgas értékkel, ha a form nem megy ki a képernyőről
            Location = new Point(Location.X,(Location.Y-valtMagas)<=0 ? 0 : Location.Y-valtMagas);
        }

        private void btnFelul_Click(object sender, EventArgs e)
        {
            //Form elhelyezése a képernyő tetejére
            Location = new Point(Location.X,0);
        }

        private void btnCsok_Click(object sender, EventArgs e)
        {
            //A form méretének csökkentése, ha a méret nem kisebb a minimum méretnél
            Width -= Width - valtSzeles >= minWidth ? valtSzeles : 0;
            Height -= Height- valtMagas >= minHeight ? valtMagas : 0;
        }

        public Form1()
        {
            InitializeComponent();
            //Form korlátok beállítása
            maxHeight=Screen.GetWorkingArea(this).Height;
            maxWidth = Screen.GetWorkingArea(this).Width;
            minHeight= maxHeight / 2;
            minWidth= maxWidth / 2;
            //Opacity = 0.5;
        }

        private void btnMeretNo_Click(object sender, EventArgs e)
        {
            //Form méretének növelése, ha a méret nem haladja meg a képernyő méretét
            if ((Location.X+Height)<=maxHeight)
            {
                Height += valtMagas;
            }
            if((Location.Y + Width) <= maxWidth)
            {
                Width += valtSzeles;
            }


        }
    }
}
