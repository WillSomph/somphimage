using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace somphimage
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MySqlConnection conn;
            string sConn = @"server=localhost;userid=root;password=;database=biblimage";
            ORM.conn = new MySqlConnection(sConn);
            ORM.conn.Open();

            Application.Run(new Accueil());

        }
    }
}
