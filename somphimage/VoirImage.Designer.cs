namespace somphimage
{
    partial class VoirImage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rtbPosterComment = new System.Windows.Forms.RichTextBox();
            this.btPoster = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btSignaler = new System.Windows.Forms.Button();
            this.rbSpam = new System.Windows.Forms.RadioButton();
            this.rbInapproprié = new System.Windows.Forms.RadioButton();
            this.rbAutre = new System.Windows.Forms.RadioButton();
            this.linkLabAccueil = new System.Windows.Forms.LinkLabel();
            this.rtbCommentaires = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(411, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(496, 335);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // rtbPosterComment
            // 
            this.rtbPosterComment.Location = new System.Drawing.Point(8, 529);
            this.rtbPosterComment.Name = "rtbPosterComment";
            this.rtbPosterComment.Size = new System.Drawing.Size(636, 185);
            this.rtbPosterComment.TabIndex = 6;
            this.rtbPosterComment.Text = "";
            // 
            // btPoster
            // 
            this.btPoster.Location = new System.Drawing.Point(686, 599);
            this.btPoster.Name = "btPoster";
            this.btPoster.Size = new System.Drawing.Size(75, 64);
            this.btPoster.TabIndex = 7;
            this.btPoster.Text = "Poster";
            this.btPoster.UseVisualStyleBackColor = true;
            this.btPoster.Click += new System.EventHandler(this.btPoster_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 493);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Poster votre commentaire";
            // 
            // btSignaler
            // 
            this.btSignaler.Location = new System.Drawing.Point(1092, 67);
            this.btSignaler.Name = "btSignaler";
            this.btSignaler.Size = new System.Drawing.Size(75, 64);
            this.btSignaler.TabIndex = 9;
            this.btSignaler.Text = "Signaler";
            this.btSignaler.UseVisualStyleBackColor = true;
            this.btSignaler.Click += new System.EventHandler(this.btSignaler_Click);
            // 
            // rbSpam
            // 
            this.rbSpam.AutoSize = true;
            this.rbSpam.Location = new System.Drawing.Point(980, 179);
            this.rbSpam.Name = "rbSpam";
            this.rbSpam.Size = new System.Drawing.Size(52, 17);
            this.rbSpam.TabIndex = 10;
            this.rbSpam.TabStop = true;
            this.rbSpam.Text = "Spam";
            this.rbSpam.UseVisualStyleBackColor = true;
            // 
            // rbInapproprié
            // 
            this.rbInapproprié.AutoSize = true;
            this.rbInapproprié.Location = new System.Drawing.Point(1065, 179);
            this.rbInapproprié.Name = "rbInapproprié";
            this.rbInapproprié.Size = new System.Drawing.Size(121, 17);
            this.rbInapproprié.TabIndex = 11;
            this.rbInapproprié.TabStop = true;
            this.rbInapproprié.Text = "Contenu Inapproprié";
            this.rbInapproprié.UseVisualStyleBackColor = true;
            // 
            // rbAutre
            // 
            this.rbAutre.AutoSize = true;
            this.rbAutre.Location = new System.Drawing.Point(1204, 179);
            this.rbAutre.Name = "rbAutre";
            this.rbAutre.Size = new System.Drawing.Size(50, 17);
            this.rbAutre.TabIndex = 12;
            this.rbAutre.TabStop = true;
            this.rbAutre.Text = "Autre";
            this.rbAutre.UseVisualStyleBackColor = true;
            // 
            // linkLabAccueil
            // 
            this.linkLabAccueil.AutoSize = true;
            this.linkLabAccueil.Location = new System.Drawing.Point(96, 46);
            this.linkLabAccueil.Name = "linkLabAccueil";
            this.linkLabAccueil.Size = new System.Drawing.Size(80, 13);
            this.linkLabAccueil.TabIndex = 13;
            this.linkLabAccueil.TabStop = true;
            this.linkLabAccueil.Text = "SOMPHIMAGE";
            this.linkLabAccueil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabAccueil_LinkClicked);
            // 
            // rtbCommentaires
            // 
            this.rtbCommentaires.Location = new System.Drawing.Point(905, 529);
            this.rtbCommentaires.Name = "rtbCommentaires";
            this.rtbCommentaires.Size = new System.Drawing.Size(424, 185);
            this.rtbCommentaires.TabIndex = 14;
            this.rtbCommentaires.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1090, 493);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Commentaires";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(330, 366);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ReadOnly = true;
            this.rtbDescription.Size = new System.Drawing.Size(649, 88);
            this.rtbDescription.TabIndex = 16;
            this.rtbDescription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Description de l\'image :";
            // 
            // VoirImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 761);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbCommentaires);
            this.Controls.Add(this.linkLabAccueil);
            this.Controls.Add(this.rbAutre);
            this.Controls.Add(this.rbInapproprié);
            this.Controls.Add(this.rbSpam);
            this.Controls.Add(this.btSignaler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btPoster);
            this.Controls.Add(this.rtbPosterComment);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VoirImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image";
            this.Load += new System.EventHandler(this.VoirImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox rtbPosterComment;
        private System.Windows.Forms.Button btPoster;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSignaler;
        private System.Windows.Forms.RadioButton rbSpam;
        private System.Windows.Forms.RadioButton rbInapproprié;
        private System.Windows.Forms.RadioButton rbAutre;
        private System.Windows.Forms.LinkLabel linkLabAccueil;
        private System.Windows.Forms.RichTextBox rtbCommentaires;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label label1;
    }
}