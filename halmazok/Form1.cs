using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace halmazok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ahalmaz_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_general_Click(object sender, EventArgs e)
        {
            Random randomszam = new Random();
            int szam1 = randomszam.Next(10, 101);
            int szam2 = randomszam.Next(10, 101);
            Ahalmaz.Text = szam1.ToString();
            Bhalmaz.Text = szam2.ToString();

            int A = szam1 - szam2;
            AbolBeredm.Text = A.ToString();

            int B = szam2 - szam1;
            BbolAeredm.Text = B.ToString();

            ABunio.Text = $"{szam1}, {szam2}";

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void AbolB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
