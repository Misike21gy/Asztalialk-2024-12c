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

        #region Adatbázis megnyitása
        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (MySqlCommand sqlComm = new MySqlCommand("userTeljesLista", mysqlConn))
            {
                sqlComm.CommandType = CommandType.StoredProcedure;
                try
                {
                    //OLvasás a táblából
                    mysqlDr = sqlComm.ExecuteReader();
                    MessageBox.Show(canToRead);
                    formState = FormState.Reading;
                    buttonSwitch(formState);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            mysqlConn.Close();
            MessageBox.Show(closeDB);
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            NextUser();
        }

        #region A következő rekord olvasása
        private void NextUser()
        {
            //A következő rekord olvasása
            mysqlDr.Read();
            tbxID.Text = mysqlDr[0].ToString().Trim();
            tbxNev.Text = mysqlDr[1].ToString().Trim();
            tbxJelszo.Text = mysqlDr[2].ToString().Trim();
            cbxAdmin.Checked = (bool)mysqlDr[3];
        }
        #endregion A következő rekord olvasása

        private void btnInsert_Click(object sender, EventArgs e)
        {
            switch (formState)
            {
                case FormState.Opened:
                    formState = FormState.EditInsert;
                    buttonSwitch(formState);
                    break;
                case FormState.Reading:
                    mysqlDr.Close();
                    formState = FormState.EditInsert;
                    buttonSwitch(formState);
                    break;
                case FormState.EditInsert:
                    InsertUser(tbxNev.Text, tbxJelszo.Text, (cbxAdmin.Checked) ? 1 : 0);
                    formState = FormState.Opened;
                    buttonSwitch(formState);
                    break;
            }
        }

        #region Új rekord beszúrása
        private void InsertUser(string pNev, string pJelszo, int pAdmin)
        {
            using (MySqlCommand sqlComm = new MySqlCommand("userInsert", mysqlConn))
            {
                sqlComm.CommandType = CommandType.StoredProcedure;

                //Paraméterek beállítása
                MySqlParameter p = new MySqlParameter();

                try
                {
                    //Olvasás a listából
                    sqlComm.ExecuteNonQuery();
                    MessageBox.Show("Az új rekord beszúrva!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion Új rekord beszúrása

        #region Tárolt eljárások

        #endregion

        #region A Form és az adatbázis állapotai
        private enum FormState
        {
            Closed, //Zárva, nincs csatlakoztatva
            Opened, //Adatbázishoz csatlakoztatva
            Reading, //Olvasás közben
            EditInsert, //Beszúrás adatainak beírása közben
            EditUpdate  //Rekord szerekesztése közben
        }

        private FormState formState = FormState.Closed;
        #endregion A Form és az adatbázis állapotai

        #region Gomb feliratok

        #endregion Gomb feliratok

        #region Gomb elérhetőségeknek beállítása
        private void buttonSwitch(FormState fs)
        {
            switch (fs)
            {
                case FormState.Closed:
                    btnConn.Enabled = true;
                    btnOpen.Enabled = false;
                    btnRead.Enabled = false;
                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnClose.Enabled = false;
                    break;
                case FormState.Opened:
                    btnConn.Enabled = false;
                    btnOpen.Enabled = true;
                    btnRead.Enabled = false;
                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnClose.Enabled = true;

                    tbxID.Enabled = false;
                    tbxNev.Enabled = false;
                    tbxJelszo.Enabled = false;
                    cbxAdmin.Enabled = false;

                    //Gomb feliratok
                    btnClose.Text = "Close";
                    btnUpdate.Text = "Update";
                    break;

                case FormState.Reading:
                    btnConn.Enabled = false;
                    btnOpen.Enabled = false;
                    btnRead.Enabled = true;
                    break;

                case FormState.EditInsert:
                    btnConn.Enabled = false;
                    btnOpen.Enabled = false;
                    btnRead.Enabled = false;
                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnClose.Enabled = true;
                    break;
            }
        }
        #endregion Gomb elérhetőségeknek beállítása
    }

        private void btnClose_Click(object sender, EventArgs e)
        {
            mysqlConn.Close();
            MessageBox.Show(closeDB);

        }


        private void btnRead_Click(object sender, EventArgs e)
        {
            NextUser();
        }

    #region A következő rekord olvasása
    private void NextUser()
    {
        //A következő rekord olvasása
        mysqlDr.Read();
        tbxID.text = mysqlDr[0].ToString().Trim();
        tbxNev.text = mysqlDr[1].ToString().Trim();
        tbxJelszo.text = mysqlDr[2].ToString().Trim();
        cbxAdmin.Checked = (bool)mysqlDr[3];
    }
    #endregion A következő rekord olvasása

    private void btnInsert_Click(object sender, EventArgs e)
    {
        switch (formState)
        {
            case FormState.Opened:
                formState = FormState.EditInsert;
                buttonSwitch(formState);
                break;
            case FormState.Reading:
                mysqlDr.Close();
                formState = FormState.EditInsert;
                buttonSwitch(formState);
                break;
            case FormState.EditInsert:
                InsertUser(tbxNev.Text,tbxJelszo.Text, (cbxAdmin.Checked)? 1:0);
                formState = FormState.Opened;
                Buttonswitch(formState);
        }
    }

    #region Új rekord beszúrása
    private void InsertUser(string pNev, string pJelszo, int pAdmin)
    {
        using (MySqlCommand sqlComm = new MySqlCommand(userInsert, mysqlConn))
        {
            sqlComm.CommandType = CommandType.StoredProcedure;

            //Paraméterek beállítása
            MySqlParameter p=new MySqlParameter();

            try
            {
                //Olvasás a listából
                sqlComm.ExecuteNonQuery();
                MessageBox.Show("Az új rekord beszúrva!");
            }
            catch(Exception e)
            {
                MessageBox.Show(ex.Messasge);
            }
        }
    }
    #endregion Új rekord beszúrása

    private void UpdateUser(int pID, string pNev, string pJelszo,int pAdmin)
    {
        using (MySqlCommand sqlComm = new MySqlCommand(userUpdate, mysqlConn))
        {
            sqlComm.CommandType = CommandType.StoredProcedure;

            //Paraméterek beállítása
            sqlComm.Parameters.AddWithValue("ID", pID);

            MySqlParameter p = new MySqlParameter();
            p.ParameterName = "Nev";
            p.Value = pNev;
            p.MySqlDbType = MySqlDbType.String;
            sqlComm.Parameters.Add(p);

            sqlComm.Parameters.AddWithValue("Jelszo", pJelszo);
            sqlComm.Parameters.AddWithValue("Admin", pAdmin);
        }
    }

    #region Tárolt eljárások

    #endregion

    #region A Form és az adatbázis állapotai
    private enum FormState
        {
            Closed, //Zárva, nincs csatlakoztatva
            Opened, //Adatbázishoz csatlakoztatva
            Reading, //Olvasás közben
            EditInsert, //Beszúrás adatainak beírása közben
            EditUpdate  //Rekord szerekesztése közben

        }

        private FormState formState = FormState.Closed;
        #endregion A Form és az adatbázis állapotai

        #region Gomb feliratok

        #endregion Gomb feliratok

        #region Gomb elérhetőségeknek beállítása
        private void buttonSwitch()
        {
            switch (fs)
            {
                case FormState.Closed:
                    btnConn.Enabled = true;
                    btnOpen.Enabled = false;
                    btnRead.Enabled = false;
                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnClose.Enabled = false;
                    break;
                case FormState.Opened:
                    btnConn.Enabled = false;
                    btnOpen.Enabled = true;
                    btnRead.Enabled = false;
                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnClose.Enabled = true;
                    
                    tbxID.Enabled = false;
                    tbxnev.Enabled = false;
                    tbxjelszo.Enabled = false;
                    cbxAdmin.Enabled = false;

                    //Gomb feliratok
                    btnClose.Text = insBasic;
                    btnUpdate.Text = updBasic;
                    break;

                case FormState.Reading:
                    btnConn.Enabled = false;
                    btnOpen.Enabled = false;
                    btnRead.Enabled = true;

                case FormState.EditInsert:
                    btnConn.Enabled = false;
                    btnOpen.Enabled = false;
                    btnRead.Enabled = false;
                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnClose.Enabled = true;

                    //Beviteli mezők előrhetősége
                    tbxID.Enabled = true;
                    tbxnev.Enabled = true;
                    tbxjelszo.Enabled = true;
                    cbxAdmin.Enabled = true;

                    //Beviteli mezők ürítése
                    tbxnev.Text = String.Empty;
                    tbxjelszo.Text = String.Empty;
                    cbxAdmin.Checked = false;

                    //Gomb feliratok
                    btnInsert.Text = insEdit ;
                    break;

                    case FormState.EditUpdate:
                    btnConn.Enabled = false;
                    btnOpen.Enabled = false;
                    btnRead.Enabled = false;
                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = false;
                    btnClose.Enabled = true;

                    tbxnev.Enabled = true;
                    tbxjelszo.Enabled = true;
                    cbxAdmin.Enabled = true;

                    //Gomb feliratok
                    btnUpdate.Text = updEdit;
                    break;

            }
        }

        #region Üzenet szövegek
        private string openSikeres = "Sikeres kapcsolat az adatbázissal!",
            openNemSikeres = "Sikertelen kapcsolat az adatbázissal :(",
            canToRead = "Az olvasás megkezdődött az adatbázisról!",
            closeDB = "Az adatbázis bezárva!!!";
        #endregion

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        switch (formState)
        {
            case FormState.Opened:
                formState = FormState.EditUpdate;
                buttonSwitch(formState);
                break;
            case FormState.Reading:
                mysqlDr.Close();
                formState = FormState.EditUpdate;
                buttonSwitch(formState);
                break;
            case FormState.EditUpdate:
                UpdateUser(Covert.ToInt32(tbxID.text),tbxNev.Text, tbxJelszo.Text, (cbxAdmin.Checked)?1:0);
                formState = FormState.Opened;
                buttonSwitch(formState);
                break;
        }

    }
}
