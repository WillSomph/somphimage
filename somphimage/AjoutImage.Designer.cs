namespace somphimage
{
    partial class AjoutImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutImage));
            this.btAjouterImg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btLoadImg = new System.Windows.Forms.Button();
            this.linkLabAccueil = new System.Windows.Forms.LinkLabel();
            this.richtbDescriptionImg = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tlcTag = new FerretLib.WinForms.Controls.TagListControl();
            this.pbLoadImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadImg)).BeginInit();
            this.SuspendLayout();
            // 
            // btAjouterImg
            // 
            this.btAjouterImg.Location = new System.Drawing.Point(1096, 548);
            this.btAjouterImg.Margin = new System.Windows.Forms.Padding(6);
            this.btAjouterImg.Name = "btAjouterImg";
            this.btAjouterImg.Size = new System.Drawing.Size(193, 34);
            this.btAjouterImg.TabIndex = 0;
            this.btAjouterImg.Text = "ajouter l\'image";
            this.btAjouterImg.UseVisualStyleBackColor = true;
            this.btAjouterImg.Click += new System.EventHandler(this.btAjouterImg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(696, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Poster une image";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btLoadImg
            // 
            this.btLoadImg.Location = new System.Drawing.Point(281, 210);
            this.btLoadImg.Margin = new System.Windows.Forms.Padding(6);
            this.btLoadImg.Name = "btLoadImg";
            this.btLoadImg.Size = new System.Drawing.Size(155, 69);
            this.btLoadImg.TabIndex = 3;
            this.btLoadImg.Text = "Parcourir l\'explorateur de fichiers";
            this.btLoadImg.UseVisualStyleBackColor = true;
            this.btLoadImg.Click += new System.EventHandler(this.btLoadImg_Click);
            // 
            // linkLabAccueil
            // 
            this.linkLabAccueil.AutoSize = true;
            this.linkLabAccueil.Location = new System.Drawing.Point(1233, 45);
            this.linkLabAccueil.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLabAccueil.Name = "linkLabAccueil";
            this.linkLabAccueil.Size = new System.Drawing.Size(80, 13);
            this.linkLabAccueil.TabIndex = 6;
            this.linkLabAccueil.TabStop = true;
            this.linkLabAccueil.Text = "SOMPHIMAGE";
            this.linkLabAccueil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabAccueil_LinkClicked);
            // 
            // richtbDescriptionImg
            // 
            this.richtbDescriptionImg.Location = new System.Drawing.Point(191, 486);
            this.richtbDescriptionImg.Margin = new System.Windows.Forms.Padding(6);
            this.richtbDescriptionImg.Name = "richtbDescriptionImg";
            this.richtbDescriptionImg.Size = new System.Drawing.Size(395, 164);
            this.richtbDescriptionImg.TabIndex = 7;
            this.richtbDescriptionImg.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 444);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Description de l\'image";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2248, 813);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(830, 444);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "tags";
            // 
            // tlcTag
            // 
            this.tlcTag.Location = new System.Drawing.Point(699, 486);
            this.tlcTag.Margin = new System.Windows.Forms.Padding(12);
            this.tlcTag.Name = "tlcTag";
            this.tlcTag.Size = new System.Drawing.Size(331, 164);
            this.tlcTag.TabIndex = 14;
            this.tlcTag.Tags = ((System.Collections.Generic.List<string>)(resources.GetObject("tlcTag.Tags")));
            // 
            // pbLoadImg
            // 
            this.pbLoadImg.Location = new System.Drawing.Point(579, 108);
            this.pbLoadImg.Margin = new System.Windows.Forms.Padding(6);
            this.pbLoadImg.Name = "pbLoadImg";
            this.pbLoadImg.Size = new System.Drawing.Size(352, 329);
            this.pbLoadImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoadImg.TabIndex = 5;
            this.pbLoadImg.TabStop = false;
            // 
            // AjoutImage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1534, 761);
            this.Controls.Add(this.tlcTag);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richtbDescriptionImg);
            this.Controls.Add(this.linkLabAccueil);
            this.Controls.Add(this.pbLoadImg);
            this.Controls.Add(this.btLoadImg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAjouterImg);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AjoutImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjoutImage";
            this.Load += new System.EventHandler(this.AjoutImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAjouterImg;
        private System.Windows.Forms.Label label1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.LinkLabel linkLabAccueil;
        private System.Windows.Forms.Button btLoadImg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richtbDescriptionImg;
        private FerretLib.WinForms.Controls.TagListControl tlcTag;
        private System.Windows.Forms.PictureBox pbLoadImg;
    }
}