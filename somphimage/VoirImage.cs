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
    public partial class VoirImage : Form
    {
        int noImg;
        public VoirImage(object tag)
        {
            InitializeComponent();
             noImg = (int)tag;
        }

        private void VoirImage_Load(object sender, EventArgs e)
        {
            ORM.afficherImgPbSelect(noImg, pictureBox1, rtbDescription,rtbCommentaires);
            if (User.currentUser == null)
            {
                btPoster.Hide();
                MessageBox.Show("connectez vous pour poster un commentaire");
            }
        }

        private void btPoster_Click(object sender, EventArgs e)
        {
            string commentaire = rtbPosterComment.Text;
            ORM.ajouterCommentaire(commentaire, User.currentUser.getCdUser(), noImg);
            MessageBox.Show("Commentaire bien ajouté");
        }

        private void btSignaler_Click(object sender, EventArgs e)
        {
            string raison ="";
            if (rbSpam.Checked)
            {
                raison = "spam";
            }
            else if (rbInapproprié.Checked)
            {
                raison = "innaproprié";
            }
            else if (rbAutre.Checked)
            {
                raison = "autre";
            }
            else
            {
                MessageBox.Show("Sélectionnez un bouton avant de signaler");
                return;
            }
            ORM.signalerImg(noImg, User.currentUser.getCdUser(), raison);
        }

        private void linkLabAccueil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            new Accueil().Show();
        }
    }
}
