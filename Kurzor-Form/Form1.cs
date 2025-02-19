using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurzor_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //Kimentem az egér új pozícióját
            int n = e.X;
            int m=e.Y;

            //A pocíziciókat kiírom a labelre
            lblSzoveg.Text=($"X:{n} Y:{m}");
            lblSzoveg.Top = m;
            lblSzoveg.Left = n;
        }
    }
}
