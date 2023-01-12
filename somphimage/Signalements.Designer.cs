namespace somphimage
{
    partial class Signalements
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.linkLabAccueil = new System.Windows.Forms.LinkLabel();
            this.btSupprImg = new System.Windows.Forms.Button();
            this.lbMotif = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(694, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Signalements";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(247, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(572, 166);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(254, 198);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(882, 166);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(267, 198);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // linkLabAccueil
            // 
            this.linkLabAccueil.AutoSize = true;
            this.linkLabAccueil.Location = new System.Drawing.Point(1188, 58);
            this.linkLabAccueil.Name = "linkLabAccueil";
            this.linkLabAccueil.Size = new System.Drawing.Size(80, 13);
            this.linkLabAccueil.TabIndex = 7;
            this.linkLabAccueil.TabStop = true;
            this.linkLabAccueil.Text = "SOMPHIMAGE";
            this.linkLabAccueil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabAccueil_LinkClicked);
            // 
            // btSupprImg
            // 
            this.btSupprImg.Location = new System.Drawing.Point(655, 577);
            this.btSupprImg.Name = "btSupprImg";
            this.btSupprImg.Size = new System.Drawing.Size(156, 23);
            this.btSupprImg.TabIndex = 9;
            this.btSupprImg.Text = "Supprimer l\'image";
            this.btSupprImg.UseVisualStyleBackColor = true;
            this.btSupprImg.Click += new System.EventHandler(this.btSupprImg_Click);
            // 
            // lbMotif
            // 
            this.lbMotif.AutoSize = true;
            this.lbMotif.Location = new System.Drawing.Point(716, 449);
            this.lbMotif.Name = "lbMotif";
            this.lbMotif.Size = new System.Drawing.Size(29, 13);
            this.lbMotif.TabIndex = 10;
            this.lbMotif.Text = "motif";
            // 
            // Signalements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 761);
            this.Controls.Add(this.lbMotif);
            this.Controls.Add(this.btSupprImg);
            this.Controls.Add(this.linkLabAccueil);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Signalements";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signalements";
            this.Load += new System.EventHandler(this.Signalements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.LinkLabel linkLabAccueil;
        private System.Windows.Forms.Button btSupprImg;
        private System.Windows.Forms.Label lbMotif;
    }
}