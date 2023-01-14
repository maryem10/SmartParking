using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//using UI_UX_Dashboard_P1;

namespace SmartParking
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new authentification());

        }
        //public static MySqlConnection cnx = new MySqlConnection("SERVER=127.0.0.1; DATABASE=smartparking; UID=root; PASSWORD= ;  pooling = false; convert zero datetime=True");
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=smartparking";
            MySqlConnection cnn = new MySqlConnection(sql);

            try
            {
                cnn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Can not open connection ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return cnn;
        }

    }
}
