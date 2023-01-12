using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FerretLib.WinForms.Controls;
using System.IO;

namespace somphimage
{
    public partial class AjoutImage : Form
    {
        public string filePath;
        public AjoutImage()
        {
            InitializeComponent();
        }

        private void btLoadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "";
            ofd.Filter = "Images supportées |*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath=ofd.FileName;
                MessageBox.Show(filePath);
                pbLoadImg.Load(filePath); // CHEMIN DE LiMAGE
            }
        }

        private void btAjouterImg_Click(object sender, EventArgs e)
        {
    
            string descript = richtbDescriptionImg.Text;
            List<string> tag = tlcTag.Tags;
            if(tag.Count==0)
            {
                MessageBox.Show("Veuillez mettre un tag au minimum");
            }
            else
            {
                ORM.AjouterImg(User.currentUser.getCdUser(), descript, tag, filePath);
                MessageBox.Show("image bien ajoutée");
            }
        }

        private void AjoutImage_Load(object sender, EventArgs e)
        {

        }

        private void linkLabAccueil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            new Accueil().Show();
        }
    }
}
