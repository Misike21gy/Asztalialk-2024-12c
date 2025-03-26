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
    public partial class Form1 : Form
    {
        private MySqlConnection mysqlConn;
        private MySqlDataReader mysqlDr;




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MysqlConnect;
        }

        private void mysqlConnect()
        {
            MySqlConnectionStringBuilder sb= new MySqlConnectionStringBuilder();
            sb.Server= "localhost";
            sb.UserID= "root";
            sb.Password= "";
            sb.Database = "iktat";

            try
            {
                mysqlConn = new MySqlConnection(sb.ToString());
                mysqlConn.Open();
                MessageBox.Show(openSikeres);

                FormState = FormState.Opened;
                buttonSwitch(formState);
            }
            catch(Exception ex)
            {
                MessageBox
            }


        }
    }
}
