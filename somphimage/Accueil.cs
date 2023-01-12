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
using System.IO;

namespace somphimage
{
    public partial class Accueil : Form
    {
        int numPage = 1;
        int lbTagIndexActuel = -1;
        List<KeyValuePair<int, Bitmap>> listImg = new List<KeyValuePair<int, Bitmap>>();
        List<PictureBox> listPb = new List<PictureBox>();
        public Accueil()
        {

            InitializeComponent();
            if (User.currentUser != null)
            {
                btInscrire.Hide();
                btConnexion.Hide();
                btDeconnexion.Show();
                btAjouterImg.Show();
                btSignalement.Show();
            }

        }
        public void refreshPbox()
        {
            clearAllPBox();
            for(int i = 0; i < listPb.Count; i++)
            {
                int numImg =(numPage - 1) * listPb.Count + i;
                if (numImg < listImg.Count)
                {
                    KeyValuePair<int, Bitmap> kv = listImg[numImg];
                    listPb[i].Image = kv.Value;
                    listPb[i].Tag = kv.Key;
                }
            }
        }

        private void clearAllPBox()
        {
            foreach (PictureBox b in listPb)
            {
                b.Image = null;
            }
        }
        private void btConnexion_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Connexion().Show();
        }
        private void btDeconnexion_Click(object sender, EventArgs e)
        {
            User.currentUser = null;
            new Accueil().Show();
            this.Close();
        }
        private void btRechercher_Click(object sender, EventArgs e)
        {
            string elembarreRecherche = tbBarreRecherche.Text;
            listImg = ORM.chercherImagesBarreRecherche(elembarreRecherche);
            refreshPbox();

        }

        private void btInscrire_Click(object sender, EventArgs e)
        {
            new Inscription().Show();
            this.Hide();
        }

        private void btAjouterImg_Click(object sender, EventArgs e)
        {
            new AjoutImage().Show();
            this.Hide();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            if (User.currentUser != null)
            {
                if (User.currentUser.getTypeUser() == "membre")
                {
                    btSignalement.Hide();
                }
            }

            listPb.Add(pictureBox1);
            listPb.Add(pictureBox2);
            listPb.Add(pictureBox3);
            listPb.Add(pictureBox4);
            listPb.Add(pictureBox5);
            listPb.Add(pictureBox6);
            ORM.listBoxTagCpt(lbTag);
            listImg=ORM.getAllImg();
            refreshPbox();


        }

        private void lbTag_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbTag.SelectedIndex;
            numPage = 1;

            if(index==lbTagIndexActuel)
            {
                lbTag.SelectedIndex = -1;
                listImg = ORM.getAllImg();
            }
            else if (lbTag.SelectedIndex!=-1)
            {
                lbTagIndexActuel = index;
                string tag = (string)lbTag.SelectedItem;
                tag = tag.Remove(tag.IndexOf(":")); // retire ce qui est apres les :
                listImg = ORM.getAllImg(tag);
            }
            refreshPbox();
        }
        private void btSuivant_Click(object sender, EventArgs e)
        {
            int pageMax = (int)Math.Round((double)(listImg.Count/listPb.Count),MidpointRounding.AwayFromZero);
            if (numPage <= pageMax)
            {
                numPage++;
            }
            refreshPbox();
        }

        private void btPrecedent_Click(object sender, EventArgs e)
        {
            if (numPage > 1)
            {
                numPage--;
                refreshPbox();
            }

        }
        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender; // recup la pb selectionné
            new VoirImage(pb.Tag).Show();
            this.Hide();
        }

        private void btSignalement_Click(object sender, EventArgs e)
        {

            {
                this.Hide();
                new Signalements().Show();
            }
        }
    }
}
