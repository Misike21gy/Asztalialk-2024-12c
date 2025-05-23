using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace értékelő_app
{
    public partial class angol : Form
    {
        public angol()
        {
            InitializeComponent();
        }

        private void angol_Load(object sender, EventArgs e)
        {
            btn_fomenu.Visible = false;
            btn_end.Visible = false;
            label_jó.Visible = false;
            label_hibás1.Visible = false;

            label_kerdes1.Visible = false;
            szöveg1.Visible = false;
            felvetes1.Visible = false;
            felvetes2.Visible = false;
            igaz1.Visible = false;
            igaz2.Visible = false;
            hamis1.Visible = false;
            hamis2.Visible = false;
            nemdki1.Visible = false;
            nemdki2.Visible = false;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            label_alcim.Visible = false;
            btn_start.Visible = false;
            btn_end.Visible = true;

            label_kerdes1.Visible = true;
            szöveg1.Visible = true;
            felvetes1.Visible = true;
            felvetes2.Visible = true;
            igaz1.Visible = true;
            igaz2.Visible = true;
            hamis1.Visible = true;
            hamis2.Visible = true;
            nemdki1.Visible = true;
            nemdki2.Visible = true;

        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            if (hamis1.Checked == true && nemdki2.Checked == true)
            {
                label_jó.Visible = true;
                label_hibás1.Visible = false;
                btn_fomenu.Visible = true;
                btn_end.Visible = false;
            }
            else
            {
                label_hibás1.Visible = true;
                label_jó.Visible = false;
                btn_fomenu.Visible = false;
                btn_end.Visible = true;
            }


        }

        private void btn_fomenu_Click(object sender, EventArgs e)
        {
            var Form1 = new Form1();
            Form1.Show();

            this.Hide();
        }
    }
}
