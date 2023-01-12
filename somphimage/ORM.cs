using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;
using FerretLib.WinForms.Controls;
using System.Drawing;

namespace somphimage
{
    class ORM
    {
        public static MySqlConnection conn = null;
        public static MySqlCommand cmd = null;
        public static MemoryStream ms;
        public static void ConnexionCompte(string UnUser, string UnMdp)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select cd_user,type_user,mdp,prenom,nom from user where cd_user='" + UnUser + "'and mdp='" + UnMdp + "'";
            MySqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            int count = dt.Rows.Count;
            if (count > 0)
            {
                MessageBox.Show("connexion réussie");
                string cduser = (string)dt.Rows[0]["cd_user"];
                string typeUser = (string)dt.Rows[0]["type_user"];
                string prenom = (string)dt.Rows[0]["prenom"];
                string nom = (string)dt.Rows[0]["nom"];
                User user = new User(cduser,typeUser, prenom, nom);
                User.currentUser = user;
                new Accueil().Show();
                new Connexion().Hide();

            }
            else
            {
                MessageBox.Show("données incorrectes, veuillez réessayer");
                new Connexion().Show();
            }

        }

        public static void InscriptionCompte(string unPseudo, string unMdp, string unNom, string unPrenom)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "insert into user(cd_user,type_user,nom,prenom,mdp) values('" + unPseudo + "', 'membre' ,'" + unNom + "','" + unPrenom + "','" + unMdp + "')";
            cmd.ExecuteNonQuery();

        }

        public static void AjouterImg(string cdUser, string uneDescription, List<string> tags, string unFilePath)
        {

            cmd = conn.CreateCommand();
            byte[] tab = File.ReadAllBytes(unFilePath);
            //string convTab = "";
            //foreach (byte b in tab)
            //{
            //    convTab += b + " ";
            //}


            cmd.CommandText = "insert into image(cd_user,description,img_blob) values('" + cdUser + "','" + uneDescription + "',@img)";
            cmd.Parameters.AddWithValue("@img", tab);
            cmd.ExecuteNonQuery();

            cmd.CommandText = "SELECT LAST_INSERT_ID();";
            ulong x = (ulong)cmd.ExecuteScalar(); // recupere le dernier autoincrement id

            foreach (string tag in tags)
            {
                cmd.CommandText = "insert ignore into tag(notag) values('" + tag + "')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into asso(no_image,notag) values('" + x + "','" + tag + "')";
                cmd.ExecuteNonQuery();
            }



        }

        public static void afficherImgPbSelect(int unNoImg, PictureBox unePb, RichTextBox uneRtbDescription, RichTextBox uneRtbCommentaire)
        {

            cmd = conn.CreateCommand();
            cmd.CommandText = "select i.description,i.img_blob from image i where i.no_image =" + unNoImg;
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            byte[] blob = (byte[])dr["img_blob"];
            MemoryStream ms = new MemoryStream(blob);
            System.Drawing.Bitmap sdb = new System.Drawing.Bitmap(ms);
            unePb.Image = sdb;
            uneRtbDescription.Text = (string)dr["description"];
            dr.Close();

            cmd.CommandText = "select p.cd_user,u.prenom,p.commentaire from publication p,user u where p.cd_user=u.cd_user and p.no_image =" + unNoImg;
            MySqlDataReader dr2 = cmd.ExecuteReader();

            while (dr2.Read())
            {
                string cdUser = (string)dr2["cd_user"];
                string prenom = (string)dr2["prenom"];
                string commentaire = (string)dr2["commentaire"];
                uneRtbCommentaire.Text += prenom + " : " + commentaire + Environment.NewLine;
            }
            dr2.Close();
        }

        public static void ajouterCommentaire(string unCommentaire, string unCdUser, int unNoImg)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "insert into publication(cd_user,no_image,commentaire)values('" + unCdUser + "','" + unNoImg + "','" + unCommentaire + "')" +
                            " ON DUPLICATE KEY UPDATE commentaire='" + unCommentaire + "'";
            cmd.ExecuteNonQuery();
        }

        public static void listBoxTagCpt(System.Windows.Forms.ListBox uneLb)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from tag";
            MySqlDataReader dr = cmd.ExecuteReader();
            List<string> listTag = new List<string>();
            while (dr.Read())
            {
                listTag.Add((string)dr["notag"]);
            }
            dr.Close();

            foreach (string s in listTag)
            {
                cmd.CommandText = "select count(*) from asso where notag='" + s + "'";
                long x = (long)cmd.ExecuteScalar();
                uneLb.Items.Add(s + ":" + x); //x nb tot de tag utilisé et s le nom du tag
            }
        }
        public static void tagSelection(string unTagSelect, List<PictureBox> uneListPb)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select img_blob from asso a, image i where a.no_image=i.no_image and a.notag='" + unTagSelect + "'";
            MySqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                byte[] blob = (byte[])dr["img_blob"];
                MemoryStream ms = new MemoryStream(blob);
                System.Drawing.Bitmap sdb = new System.Drawing.Bitmap(ms);
                uneListPb[i++].Image = sdb;

            }
            for (; i < uneListPb.Count; i++)
            {
                uneListPb[i].Image = null;
            }
            dr.Close();

        }

        public static List<KeyValuePair<int, Bitmap>> getAllImg(string tag = null, bool signalement = false)
        {
            List<KeyValuePair<int, Bitmap>> listImg = new List<KeyValuePair<int, Bitmap>>();
            cmd.CommandText = "select i.img_blob,i.no_image from image i";
            if (tag != null)
            {
                cmd.CommandText += ",asso a where i.no_image= a.no_image And a.notag ='" + tag + "'";

            }
            if (signalement)
            {
                cmd.CommandText += ",signalement s where i.no_image= s.no_image";
            }
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int noImage = (int)dr["no_image"];
                byte[] blob = (byte[])dr["img_blob"];
                MemoryStream ms = new MemoryStream(blob);
                System.Drawing.Bitmap sdb = new System.Drawing.Bitmap(ms);
                listImg.Add(new KeyValuePair<int, Bitmap>(noImage, sdb));
            }
            dr.Close();
            return listImg;
        }
        public static void signalerImg(int unNoImg, string unCdUser, string uneRaison)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "insert into signalement(cd_user,no_image,raison)values('" + unCdUser + "','" + unNoImg + "','" + uneRaison + "')";
            cmd.ExecuteNonQuery();


        }

        public static List<KeyValuePair<int, Bitmap>> chercherImagesBarreRecherche(string elemBarreRecherche)
        {
            List<KeyValuePair<int, Bitmap>> listImg = new List<KeyValuePair<int, Bitmap>>();
            cmd = conn.CreateCommand();
            cmd.CommandText = "select i.img_blob,i.no_image from image i, asso a where i.no_image=a.no_image and a.notag like'" + elemBarreRecherche + "'";
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int noImage = (int)dr["no_image"];
                byte[] blob = (byte[])dr["img_blob"];
                MemoryStream ms = new MemoryStream(blob);
                System.Drawing.Bitmap sdb = new System.Drawing.Bitmap(ms);
                listImg.Add(new KeyValuePair<int, Bitmap>(noImage, sdb));
            }
            dr.Close();
            return listImg;
        }
        public static void AfficherMotifSignalement(Label unLabel,int noImg,string unUser)
        {

            cmd.CommandText = "select s.raison,i.no_image from signalement s,image i where i.no_image=s.no_image and i.no_image="+noImg+" and s.cd_user='"+unUser+"'";
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string raison = (string)dr["raison"];
                unLabel.Text = raison;
            }
            dr.Close();

        }
        public static void SupprimerImgSignalement(int noImg)
        {
            //cmd.CommandText = "delete from image i,signalement s,publication p,asso a where i.no_image=s.no_image and i.no_image=p.no_image "+
            //                  "and i.no_image=a.no_image and i.no_image=" + noImg;
            cmd.CommandText= "delete from asso  where no_image=" + noImg;
            cmd.CommandText += ";delete from publication  where no_image=" + noImg;
            cmd.CommandText += ";delete from signalement  where no_image=" + noImg;
            cmd.CommandText += ";delete from image  where no_image=" + noImg;
            cmd.ExecuteNonQuery();

        }
    }
}
