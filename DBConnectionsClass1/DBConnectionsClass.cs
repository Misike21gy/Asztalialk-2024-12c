using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnectionsClass1
{
    public DBConnectionsClass
{
    public static string GetConnectionString_2(string connectionStringName)
    {
        // string connectionName: A konfigugurációs fájlban megadott connection string neve, amelyet kulcsként használunk.
        try
        {
            // Az App .config fájlban lévő <connectionStrings> szekcióból próbálja kiolvasni a connectionName nevű kapcsolatot.
            string connectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
            return connectionString;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hiba történt a kapcsolat létrehozásakor: " + ex.Message);
            return null;
        }

    }
    public static string GetConnectionString_1(string connectionStringName)
    {
        /* 
         * A metódus dinamikusan épít fel egy SQL Server kapcsolat karakterláncot (connection string) a konfigurációs állományból (App.config)  beolvasott értékek alapján majd visszaadja azt.
         */
        SqlConnectionStringBuilder cnstrBuilder = new SqlConnectionStringBuilder();
        cnstrBuilder.DataSource = ConfigurationManager.AppSettings["server"];
        cnstrBuilder.InitialCatalog = ConfigurationManager.AppSettings["database"];
        cnstrBuilder.UserID = ConfigurationManager.AppSettings["user"];
        cnstrBuilder.Password = ConfigurationManager.AppSettings["password"];

        cnstrBuilder.IntegratedSecurity = true;
        /*
         * Az 'IntegratedSecurity = true' azt jelenti hogy a Windows hitelesítést használja a kapcsolat létrehozásához, tehát nem kell felhasználónév és jelszó a kapcsolat létrehozásához.
         * Tehát a 'UserID' és 'Password' sorok feleslegesek ebben az esetbenm mert az 'IntegratedSecurity = true' azokat figyelmen kívül hagyja. Az 'IntegratedSecurity = 'false' esetben viszont szükséges.
         */
        cnstrBuilder.ConnectTimeout = 30; // 30 másdoperces kapcsolódási időkorlátot állít be az SQL szerverhez.

        //A kapcsolat objektumot csak azért hozza létre, hogy belőle visszadja a connection stringet.
        //A kapcsolat nem kerül megnyitásra, tehát nem történik hálózati művelet.
        SqlConnection cn = new SqlConnection();
        cn.ConnectionString = cnstrBuilder.ConnectionString;

    }

}
