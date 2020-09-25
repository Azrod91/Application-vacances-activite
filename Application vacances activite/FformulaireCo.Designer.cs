namespace Application_vacances_activite
{
    partial class FformulaireCo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FformulaireCo));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.logoCo = new System.Windows.Forms.PictureBox();
            this.utilisteur = new System.Windows.Forms.Label();
            this.mdp = new System.Windows.Forms.Label();
            this.Sutilisateur = new System.Windows.Forms.TextBox();
            this.Smdp = new System.Windows.Forms.TextBox();
            this.validerCo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoCo)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(326, 144);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(58, 20);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Retour";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // logoCo
            // 
            this.logoCo.Image = ((System.Drawing.Image)(resources.GetObject("logoCo.Image")));
            this.logoCo.Location = new System.Drawing.Point(12, 12);
            this.logoCo.Name = "logoCo";
            this.logoCo.Size = new System.Drawing.Size(233, 152);
            this.logoCo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoCo.TabIndex = 1;
            this.logoCo.TabStop = false;
            // 
            // utilisteur
            // 
            this.utilisteur.AutoSize = true;
            this.utilisteur.Location = new System.Drawing.Point(279, 35);
            this.utilisteur.Name = "utilisteur";
            this.utilisteur.Size = new System.Drawing.Size(80, 20);
            this.utilisteur.TabIndex = 2;
            this.utilisteur.Text = "Utilisateur";
            // 
            // mdp
            // 
            this.mdp.AutoSize = true;
            this.mdp.Location = new System.Drawing.Point(279, 94);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(105, 20);
            this.mdp.TabIndex = 3;
            this.mdp.Text = "Mot de passe";
            // 
            // Sutilisateur
            // 
            this.Sutilisateur.Location = new System.Drawing.Point(390, 35);
            this.Sutilisateur.Name = "Sutilisateur";
            this.Sutilisateur.Size = new System.Drawing.Size(176, 26);
            this.Sutilisateur.TabIndex = 4;
            // 
            // Smdp
            // 
            this.Smdp.Location = new System.Drawing.Point(390, 88);
            this.Smdp.Name = "Smdp";
            this.Smdp.Size = new System.Drawing.Size(186, 26);
            this.Smdp.TabIndex = 5;
            // 
            // validerCo
            // 
            this.validerCo.Location = new System.Drawing.Point(458, 131);
            this.validerCo.Name = "validerCo";
            this.validerCo.Size = new System.Drawing.Size(118, 33);
            this.validerCo.TabIndex = 6;
            this.validerCo.Text = "Valider";
            this.validerCo.UseVisualStyleBackColor = true;
            this.validerCo.Click += new System.EventHandler(this.validerFco_Click);
            // 
            // FformulaireCo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 202);
            this.Controls.Add(this.validerCo);
            this.Controls.Add(this.Smdp);
            this.Controls.Add(this.Sutilisateur);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.utilisteur);
            this.Controls.Add(this.logoCo);
            this.Controls.Add(this.linkLabel1);
            this.Name = "FformulaireCo";
            this.Text = "FformulaireCo";
            ((System.ComponentModel.ISupportInitialize)(this.logoCo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox logoCo;
        private System.Windows.Forms.Label utilisteur;
        private System.Windows.Forms.Label mdp;
        private System.Windows.Forms.TextBox Sutilisateur;
        private System.Windows.Forms.TextBox Smdp;
        private System.Windows.Forms.Button validerCo;
    }
}