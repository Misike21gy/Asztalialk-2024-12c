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
    public partial class irodalom : Form
    {
        public irodalom()
        {
            InitializeComponent();
        }

        private void irodalom_Load(object sender, EventArgs e)
        {
            label_kerdes1.Visible = false;
            label_kerdes2.Visible = false;
            label_kerdes3.Visible = false;

            label_bedeanna.Visible = false;
            label_csongor.Visible = false;
            label_tothlajos.Visible = false;

            ja_karó.Visible = false;
            ja_tisztaszív.Visible = false;
            ja_hamis.Visible = false;
            ja_szülinap.Visible = false;

            checkBox_ja_karó.Visible = false;
            checkBox_ja_tisztasziv.Visible = false;
            checkBox_ja_hamis.Visible = false;
            checkBox_ja_szülinapra.Visible = false;

            label_szavak_gógmagóg.Visible = false;

            textBox_bedeanna.Visible = false;
            textBox_csongor.Visible = false;
            textBox_tothlajos.Visible = false;
            textBox_góg.Visible = false;
            textBox_magóg.Visible = false;

            label_vers.Visible = false;

            btn_end.Visible = false;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            
            label_kerdes1.Visible = true;
            label_kerdes2.Visible = true;
            label_kerdes3.Visible = true;

            label_bedeanna.Visible = true;
            label_csongor.Visible = true;
            label_tothlajos.Visible = true;

            ja_karó.Visible = true;
            ja_tisztaszív.Visible = true;
            ja_hamis.Visible = true;
            ja_szülinap.Visible = true;

            checkBox_ja_karó.Visible = true;
            checkBox_ja_tisztasziv.Visible = true;
            checkBox_ja_hamis.Visible = true;
            checkBox_ja_szülinapra.Visible = true;

            label_szavak_gógmagóg.Visible = true;

            textBox_bedeanna.Visible = true;
            textBox_csongor.Visible = true;
            textBox_tothlajos.Visible = true;
            textBox_góg.Visible = true;
            textBox_magóg.Visible = true;

            label_vers.Visible = true;

            btn_end.Visible = true;
            
            label_alcim.Visible = false;

            btn_start.Visible = false;
        }
    }
}
