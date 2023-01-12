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

    public partial class Signalements : Form
    {
        List<KeyValuePair<int, Bitmap>> listImg = new List<KeyValuePair<int, Bitmap>>();
        List<PictureBox> listPb = new List<PictureBox>();
        PictureBox pbSelectionne;

        public Signalements()
        {
            InitializeComponent();
        }

        private void Signalements_Load(object sender, EventArgs e)
        {
            listPb.Add(pictureBox1);
            listPb.Add(pictureBox2);
            listPb.Add(pictureBox3);
            listImg=ORM.getAllImg(null, true);
            for(int i = 0; i < listPb.Count; i++)
            {
                if (i >= listImg.Count)
                {
                    return;
                }
                listPb[i].Image = listImg[i].Value;
                listPb[i].Tag = listImg[i].Key;
            }

        }
        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            if (pb.Tag != null)
            {
                pbSelectionne = pb;
                ORM.AfficherMotifSignalement(lbMotif, (int)pb.Tag, User.currentUser.getCdUser());
            }
        }

        private void linkLabAccueil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            new Accueil().Show();
        }

        private void btSupprImg_Click(object sender, EventArgs e)
        {
            if (pbSelectionne!=null)
            {
                int id = (int)this.pbSelectionne.Tag;
                ORM.SupprimerImgSignalement(id);
                MessageBox.Show("bien supprimée");
                this.Close();
                new Signalements().Show();
            }
        }
    }
}
