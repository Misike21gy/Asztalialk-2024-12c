using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mysql.users
{
    public partial class BeosztasokForm : Form
    {
        //Osztályváltozók
        private MySqlConnection connection;
        private DataSet DataSet;
        private MySqlDataAdapter dataadapter;
        private BindingSource bindingSource;
        private BeosztasokForm beosztasClass;


        public BeosztasokForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
