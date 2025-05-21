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
    public partial class történelem : Form
    {
        public történelem()
        {
            InitializeComponent();
        }

        private void történelem_Load(object sender, EventArgs e)
        {
            label_kerdes1.Visible = false;
            label_kerdes2.Visible = false;
            label_kerdes3.Visible = false;
            label_kerdes4.Visible = false;
            label_kerdes5.Visible = false;

            btn_fomenu.Visible = false;
            btn_end.Visible = false;

            textBox_valasz1.Visible = false;
            textBox_valasz2.Visible = false;
            textBox_valasz3.Visible = false;
            textBox_valasz4.Visible = false;

            ih_kerdes1.Visible = false;
            ih_kerdes2.Visible = false;
            ih_kerdes3.Visible = false;
            ih_kerdes4.Visible = false;

            igaz1.Visible = false;
            igaz2.Visible = false;
            igaz3.Visible = false;
            igaz4.Visible = false;

            hamis1.Visible = false;
            hamis2.Visible = false;
            hamis3.Visible = false;
            hamis4.Visible = false;

            label_jó.Visible = false;
            label_hibás.Visible = false;

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            label_alcim.Visible = false;

            label_kerdes1.Visible = true;
            label_kerdes2.Visible = true;
            label_kerdes3.Visible = true;
            label_kerdes4.Visible = true;
            label_kerdes5.Visible = true;

            btn_fomenu.Visible = false;
            btn_start.Visible = false;
            btn_end.Visible = true;

            textBox_valasz1.Visible = true;
            textBox_valasz2.Visible = true;
            textBox_valasz3.Visible = true;
            textBox_valasz4.Visible = true;

            ih_kerdes1.Visible = true;
            ih_kerdes2.Visible = true;
            ih_kerdes3.Visible = true;
            ih_kerdes4.Visible = true;

            igaz1.Visible = true;
            igaz2.Visible = true;
            igaz3.Visible = true;
            igaz4.Visible = true;

            hamis1.Visible = true;
            hamis2.Visible = true;
            hamis3.Visible = true;
            hamis4.Visible = true;

            label_jó.Visible = false;
            label_hibás.Visible = false;
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            if (textBox_valasz1.Text == "Primogenitúra" && textBox_valasz2.Text == "Santa Maria" && textBox_valasz3.Text == "Fekete sereg" && textBox_valasz4.Text == "TSZ" && igaz1.Checked == true && hamis2.Checked == true && igaz3.Checked == true && igaz4.Checked == true)
            {
                label_jó.Visible = true;
                label_hibás.Visible = false;
                btn_fomenu.Visible = true;
            }

            else
            {
                label_hibás.Visible = true;
                label_jó.Visible = false;
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
