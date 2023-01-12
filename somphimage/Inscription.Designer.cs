namespace somphimage
{
    partial class Inscription
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
            this.tbMdp = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbPseudo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btInscription = new System.Windows.Forms.Button();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabAccueil = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(644, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inscription";
            // 
            // tbMdp
            // 
            this.tbMdp.Location = new System.Drawing.Point(631, 224);
            this.tbMdp.Name = "tbMdp";
            this.tbMdp.Size = new System.Drawing.Size(100, 20);
            this.tbMdp.TabIndex = 1;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(631, 316);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(100, 20);
            this.tbPrenom.TabIndex = 2;
            // 
            // tbPseudo
            // 
            this.tbPseudo.Location = new System.Drawing.Point(631, 134);
            this.tbPseudo.Name = "tbPseudo";
            this.tbPseudo.Size = new System.Drawing.Size(100, 20);
            this.tbPseudo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pseudo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mot de passe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prenom";
            // 
            // btInscription
            // 
            this.btInscription.Location = new System.Drawing.Point(647, 570);
            this.btInscription.Name = "btInscription";
            this.btInscription.Size = new System.Drawing.Size(75, 23);
            this.btInscription.TabIndex = 7;
            this.btInscription.Text = "S\'inscrire";
            this.btInscription.UseVisualStyleBackColor = true;
            this.btInscription.Click += new System.EventHandler(this.btInscription_Click);
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(631, 414);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(100, 20);
            this.tbNom.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(508, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nom";
            // 
            // linkLabAccueil
            // 
            this.linkLabAccueil.AutoSize = true;
            this.linkLabAccueil.Location = new System.Drawing.Point(1210, 45);
            this.linkLabAccueil.Name = "linkLabAccueil";
            this.linkLabAccueil.Size = new System.Drawing.Size(80, 13);
            this.linkLabAccueil.TabIndex = 10;
            this.linkLabAccueil.TabStop = true;
            this.linkLabAccueil.Text = "SOMPHIMAGE";
            // 
            // Inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 727);
            this.Controls.Add(this.linkLabAccueil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.btInscription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPseudo);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.tbMdp);
            this.Controls.Add(this.label1);
            this.Name = "Inscription";
            this.Text = "Inscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMdp;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbPseudo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btInscription;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabAccueil;
    }
}