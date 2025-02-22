﻿using System;
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

        private void btnFel_Click(object sender, EventArgs e)
        {

        }

        private void btnFelul_Click(object sender, EventArgs e)
        {
            //Form elhelyezése a képernyő tetejére
            Location = new Point(Location.X,0);
        }

        private void btnCsok_Click(object sender, EventArgs e)
        {
            //A form méretének csökkentése, ha a méret nem kisebb a minimum méretnél
            if (Width>=Width-valtSzeles)
            {
                Width -= valtSzeles;
            }
            Width = Width - valtSzeles >= minWidth ? valtSzeles : 0;
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
