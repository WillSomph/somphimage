namespace somphimage
{
    partial class Connexion
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
            this.tbPseudo = new System.Windows.Forms.TextBox();
            this.tbMdp = new System.Windows.Forms.TextBox();
            this.btConnexion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabAccueil = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(633, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connexion";
            // 
            // tbPseudo
            // 
            this.tbPseudo.Location = new System.Drawing.Point(618, 221);
            this.tbPseudo.Name = "tbPseudo";
            this.tbPseudo.Size = new System.Drawing.Size(100, 20);
            this.tbPseudo.TabIndex = 4;
            this.tbPseudo.TextChanged += new System.EventHandler(this.tbPseudo_TextChanged);
            // 
            // tbMdp
            // 
            this.tbMdp.Location = new System.Drawing.Point(618, 319);
            this.tbMdp.Name = "tbMdp";
            this.tbMdp.Size = new System.Drawing.Size(100, 20);
            this.tbMdp.TabIndex = 5;
            // 
            // btConnexion
            // 
            this.btConnexion.Location = new System.Drawing.Point(636, 503);
            this.btConnexion.Name = "btConnexion";
            this.btConnexion.Size = new System.Drawing.Size(75, 23);
            this.btConnexion.TabIndex = 8;
            this.btConnexion.Text = "Connexion";
            this.btConnexion.UseVisualStyleBackColor = true;
            this.btConnexion.Click += new System.EventHandler(this.btConnexion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pseudo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mot de passe";
            // 
            // linkLabAccueil
            // 
            this.linkLabAccueil.AutoSize = true;
            this.linkLabAccueil.Location = new System.Drawing.Point(1193, 63);
            this.linkLabAccueil.Name = "linkLabAccueil";
            this.linkLabAccueil.Size = new System.Drawing.Size(80, 13);
            this.linkLabAccueil.TabIndex = 11;
            this.linkLabAccueil.TabStop = true;
            this.linkLabAccueil.Text = "SOMPHIMAGE";
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 727);
            this.Controls.Add(this.linkLabAccueil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btConnexion);
            this.Controls.Add(this.tbMdp);
            this.Controls.Add(this.tbPseudo);
            this.Controls.Add(this.label1);
            this.Name = "Connexion";
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Connexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPseudo;
        private System.Windows.Forms.TextBox tbMdp;
        private System.Windows.Forms.Button btConnexion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabAccueil;
    }
}