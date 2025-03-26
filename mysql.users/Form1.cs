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
        #region kapcsolat properties
        private MySqlConnection mysqlConn;
        private MySqlDataReader mysqlDr;
        #endregion kapcsolat properties

        #region Üzenet szövegek
        private string openSikeres = "Sikeres kapcsolat az adatbázissal!";
        private string openNemSikeres = "Sikertelen kapcsolat az adatbázissal :(";
        private string canToRead = "Az olvasás megkezdődött az adatbázisról!";
        private string closeDB = "Az adatbázis bezárva!!!";
        #endregion Üzenet szövegek  

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mysqlConnect();
        }

        private void mysqlConnect()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "iktat";

            try
            {
                mysqlConn = new MySqlConnection(sb.ToString());
                mysqlConn.Open();
                MessageBox.Show(openSikeres);

            }
            catch (Exception ex)
            {
                MessageBox.Show(openNemSikeres);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            mysqlConn.Close();
            MessageBox.Show(closeDB);

        }

        #region A Form és az adatbázis állapotai
        private enum FormState
        {
            Closed, //Zárva, nincs csatlakoztatva
            Opened, //Adatbázishoz csatlakoztatva
            Reading, //OLvasás közben
            EditInsert, //Beszúrás adatainak beírása közben
            EditUpdate  //Rekord szerekesztése közben

        }

        private FormState formState = FormState.Closed;

        #endregion A Form és az adatbázis állapotai

    }
}
