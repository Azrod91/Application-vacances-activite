namespace Application_vacances_activite
{
    partial class Faccueil1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Faccueil1));
            this.acces_inscription = new System.Windows.Forms.Button();
            this.panelAccueil1 = new System.Windows.Forms.Panel();
            this.titre1 = new System.Windows.Forms.Label();
            this.acces_connexion = new System.Windows.Forms.Button();
            this.imageAccueil1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DescrAccueil1 = new System.Windows.Forms.Label();
            this.acces_deconnexion = new System.Windows.Forms.Button();
            this.typeActivite = new System.Windows.Forms.ComboBox();
            this.recherche = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Nom_act = new System.Windows.Forms.Label();
            this.NomActivite = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nbrParticipants = new System.Windows.Forms.TextBox();
            this.dateAct = new System.Windows.Forms.DateTimePicker();
            this.titreDate = new System.Windows.Forms.Label();
            this.TitretypeAct = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbActivite = new System.Windows.Forms.ListBox();
            this.panelAccueil1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageAccueil1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // acces_inscription
            // 
            this.acces_inscription.Location = new System.Drawing.Point(925, 137);
            this.acces_inscription.Name = "acces_inscription";
            this.acces_inscription.Size = new System.Drawing.Size(141, 41);
            this.acces_inscription.TabIndex = 0;
            this.acces_inscription.Text = "Inscription";
            this.acces_inscription.UseVisualStyleBackColor = true;
            this.acces_inscription.Click += new System.EventHandler(this.acces_inscription_Click);
            // 
            // panelAccueil1
            // 
            this.panelAccueil1.BackColor = System.Drawing.Color.Navy;
            this.panelAccueil1.Controls.Add(this.titre1);
            this.panelAccueil1.Location = new System.Drawing.Point(0, 2);
            this.panelAccueil1.Name = "panelAccueil1";
            this.panelAccueil1.Size = new System.Drawing.Size(1731, 129);
            this.panelAccueil1.TabIndex = 1;
            // 
            // titre1
            // 
            this.titre1.AutoSize = true;
            this.titre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre1.ForeColor = System.Drawing.SystemColors.Control;
            this.titre1.Location = new System.Drawing.Point(622, 37);
            this.titre1.Name = "titre1";
            this.titre1.Size = new System.Drawing.Size(413, 46);
            this.titre1.TabIndex = 0;
            this.titre1.Text = "Bienvenue chez AVA";
            // 
            // acces_connexion
            // 
            this.acces_connexion.Location = new System.Drawing.Point(1072, 137);
            this.acces_connexion.Name = "acces_connexion";
            this.acces_connexion.Size = new System.Drawing.Size(141, 41);
            this.acces_connexion.TabIndex = 2;
            this.acces_connexion.Text = "Connexion";
            this.acces_connexion.UseVisualStyleBackColor = true;
            this.acces_connexion.Click += new System.EventHandler(this.acces_connexion_Click);
            // 
            // imageAccueil1
            // 
            this.imageAccueil1.Image = ((System.Drawing.Image)(resources.GetObject("imageAccueil1.Image")));
            this.imageAccueil1.Location = new System.Drawing.Point(49, 137);
            this.imageAccueil1.Name = "imageAccueil1";
            this.imageAccueil1.Size = new System.Drawing.Size(839, 596);
            this.imageAccueil1.TabIndex = 3;
            this.imageAccueil1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // DescrAccueil1
            // 
            this.DescrAccueil1.AutoSize = true;
            this.DescrAccueil1.Location = new System.Drawing.Point(177, 147);
            this.DescrAccueil1.Name = "DescrAccueil1";
            this.DescrAccueil1.Size = new System.Drawing.Size(511, 20);
            this.DescrAccueil1.TabIndex = 5;
            this.DescrAccueil1.Text = "Connecte toi ou inscrit toi pour profiter de l\'Application vacances activité";
            // 
            // acces_deconnexion
            // 
            this.acces_deconnexion.Location = new System.Drawing.Point(1576, 137);
            this.acces_deconnexion.Name = "acces_deconnexion";
            this.acces_deconnexion.Size = new System.Drawing.Size(141, 41);
            this.acces_deconnexion.TabIndex = 6;
            this.acces_deconnexion.Text = "Deconnexion";
            this.acces_deconnexion.UseVisualStyleBackColor = true;
            this.acces_deconnexion.Visible = false;
            this.acces_deconnexion.Click += new System.EventHandler(this.acces_deconnexion_Click);
            // 
            // typeActivite
            // 
            this.typeActivite.FormattingEnabled = true;
            this.typeActivite.Location = new System.Drawing.Point(16, 117);
            this.typeActivite.Name = "typeActivite";
            this.typeActivite.Size = new System.Drawing.Size(150, 28);
            this.typeActivite.TabIndex = 7;
            // 
            // recherche
            // 
            this.recherche.Location = new System.Drawing.Point(402, 116);
            this.recherche.Name = "recherche";
            this.recherche.Size = new System.Drawing.Size(120, 28);
            this.recherche.TabIndex = 9;
            this.recherche.Text = "Rechercher";
            this.recherche.UseVisualStyleBackColor = true;
            this.recherche.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(108, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(474, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Rechercher des actvités à votre goût";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.Nom_act);
            this.panel1.Controls.Add(this.NomActivite);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.nbrParticipants);
            this.panel1.Controls.Add(this.dateAct);
            this.panel1.Controls.Add(this.titreDate);
            this.panel1.Controls.Add(this.TitretypeAct);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.lbActivite);
            this.panel1.Controls.Add(this.typeActivite);
            this.panel1.Controls.Add(this.recherche);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(909, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 540);
            this.panel1.TabIndex = 11;
            // 
            // Nom_act
            // 
            this.Nom_act.AutoSize = true;
            this.Nom_act.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Nom_act.Location = new System.Drawing.Point(159, 428);
            this.Nom_act.Name = "Nom_act";
            this.Nom_act.Size = new System.Drawing.Size(21, 20);
            this.Nom_act.TabIndex = 22;
            this.Nom_act.Text = "...";
            // 
            // NomActivite
            // 
            this.NomActivite.AutoSize = true;
            this.NomActivite.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NomActivite.Location = new System.Drawing.Point(47, 428);
            this.NomActivite.Name = "NomActivite";
            this.NomActivite.Size = new System.Drawing.Size(95, 20);
            this.NomActivite.TabIndex = 21;
            this.NomActivite.Text = "Nom activité";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "Voir mes reservations";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(219, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "nombres participants";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(539, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // nbrParticipants
            // 
            this.nbrParticipants.Location = new System.Drawing.Point(393, 425);
            this.nbrParticipants.Name = "nbrParticipants";
            this.nbrParticipants.Size = new System.Drawing.Size(100, 26);
            this.nbrParticipants.TabIndex = 18;
            this.nbrParticipants.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nbrParticipants_KeyPress);
            // 
            // dateAct
            // 
            this.dateAct.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateAct.Location = new System.Drawing.Point(191, 117);
            this.dateAct.Name = "dateAct";
            this.dateAct.Size = new System.Drawing.Size(185, 26);
            this.dateAct.TabIndex = 17;
            this.dateAct.Value = new System.DateTime(2020, 4, 20, 17, 32, 45, 0);
            // 
            // titreDate
            // 
            this.titreDate.AutoSize = true;
            this.titreDate.BackColor = System.Drawing.Color.Black;
            this.titreDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.titreDate.Location = new System.Drawing.Point(250, 94);
            this.titreDate.Name = "titreDate";
            this.titreDate.Size = new System.Drawing.Size(44, 20);
            this.titreDate.TabIndex = 14;
            this.titreDate.Text = "Date";
            // 
            // TitretypeAct
            // 
            this.TitretypeAct.AutoSize = true;
            this.TitretypeAct.BackColor = System.Drawing.Color.Black;
            this.TitretypeAct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TitretypeAct.Location = new System.Drawing.Point(28, 94);
            this.TitretypeAct.Name = "TitretypeAct";
            this.TitretypeAct.Size = new System.Drawing.Size(114, 20);
            this.TitretypeAct.TabIndex = 13;
            this.TitretypeAct.Text = "Types Activités";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(74, 470);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(373, 41);
            this.button2.TabIndex = 12;
            this.button2.Text = "Valider Activité";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbActivite
            // 
            this.lbActivite.FormattingEnabled = true;
            this.lbActivite.ItemHeight = 20;
            this.lbActivite.Location = new System.Drawing.Point(16, 161);
            this.lbActivite.Name = "lbActivite";
            this.lbActivite.Size = new System.Drawing.Size(507, 264);
            this.lbActivite.TabIndex = 11;
            this.lbActivite.SelectedIndexChanged += new System.EventHandler(this.lbActivite_SelectedIndexChanged);
            // 
            // Faccueil1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1737, 761);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.acces_deconnexion);
            this.Controls.Add(this.DescrAccueil1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageAccueil1);
            this.Controls.Add(this.acces_connexion);
            this.Controls.Add(this.panelAccueil1);
            this.Controls.Add(this.acces_inscription);
            this.Name = "Faccueil1";
            this.Text = "Accueil";
            this.panelAccueil1.ResumeLayout(false);
            this.panelAccueil1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageAccueil1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button acces_inscription;
        private System.Windows.Forms.Panel panelAccueil1;
        private System.Windows.Forms.Label titre1;
        private System.Windows.Forms.Button acces_connexion;
        private System.Windows.Forms.PictureBox imageAccueil1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DescrAccueil1;
        private System.Windows.Forms.Button acces_deconnexion;
        private System.Windows.Forms.ComboBox typeActivite;
        private System.Windows.Forms.Button recherche;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lbActivite;
        private System.Windows.Forms.Label titreDate;
        private System.Windows.Forms.Label TitretypeAct;
        private System.Windows.Forms.DateTimePicker dateAct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox nbrParticipants;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Nom_act;
        private System.Windows.Forms.Label NomActivite;
    }
}

