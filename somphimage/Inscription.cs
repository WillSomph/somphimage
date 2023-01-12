using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace somphimage
{
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
        }

        private void btInscription_Click(object sender, EventArgs e)
        {
            string pseudo = tbPseudo.Text;
            string mdp = tbMdp.Text;
            string prenom = tbPrenom.Text;
            string nom = tbNom.Text;
            ORM.InscriptionCompte(pseudo, mdp, prenom, nom);
            this.Close();
            new Accueil().Show();
            this.Close();
        }
    }
}
