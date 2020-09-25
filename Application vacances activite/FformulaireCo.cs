using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_vacances_activite
{
    public partial class FformulaireCo : Form
    {
        public static bool connecte = false;

        Faccueil1 recupForm1;
        public FformulaireCo(Faccueil1 uneF)
        {
            InitializeComponent();
            recupForm1 = uneF;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void validerFco_Click(object sender, EventArgs e)
        {
            if (Sutilisateur.Text == "")
            {
                MessageBox.Show("saisir les champs");
            }
            else
            {
                if (AccesBd.connexion())
                {
                    if (AccesBd.verifCo(Sutilisateur.Text, Smdp.Text))
                    {
                        MessageBox.Show("vous etes connecté "+ Sutilisateur.Text);
                        string newTitre = "utilisateur: " + Sutilisateur.Text + " ";
                        recupForm1.Text = newTitre;
                        recupForm1.GetBtConnexion().Visible = false;
                        FformulaireCo.connecte = true;
                        recupForm1.GetBtInscription().Visible = false;
                        recupForm1.GetBtDeconnexion().Visible = true;
                        recupForm1.GetBtTitreAccueil().Text = "Bienvenue " + Sutilisateur.Text + " chez VVA ";
                        Donnees.setUtilisateur(Sutilisateur.Text);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("erreur lors de la connection");
                    }
                }
            }
        }

      
    }
}
