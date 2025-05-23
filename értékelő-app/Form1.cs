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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_irodalom_Click(object sender, EventArgs e)
        {
            var irodalomForm = new irodalom();
            irodalomForm.Show();

            this.Hide();
        }

        private void btn_töri_Click(object sender, EventArgs e)
        {

            var történelemForm = new történelem();
            történelemForm.Show();

            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_angol_Click(object sender, EventArgs e)
        {
            var angolForm = new angol();
            angolForm.Show();

            this.Hide();
        }

        private void btn_matek_Click(object sender, EventArgs e)
        {
            var matekForm = new matek();
            matekForm.Show();

            this.Hide();
        }

        private void btn_nyelvtan_Click(object sender, EventArgs e)
        {
            var nyelvtanForm = new nyelvtan();
            nyelvtanForm.Show();

            this.Hide();
        }
    }
}
