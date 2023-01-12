using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace somphimage
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void btConnexion_Click(object sender, EventArgs e)
        {
            string user = tbPseudo.Text;
            string mdp = tbMdp.Text;
            ORM.ConnexionCompte(user, mdp);
            this.Close();

        }

        private void tbPseudo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Connexion_Load(object sender, EventArgs e)
        {

        }
    }
}
