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
    public partial class Finscription : Form
    {
        
        public Finscription()
        {
            InitializeComponent();
            
        }

        private void Vinscr_Click(object sender, EventArgs e)
        {
            if (AccesBd.connexion())
            {
                if(Sutilisateur.Text!= "" && Smdp.Text!="" && Snom.Text!="" && Sprenom.Text!="")
                {
                    GroupBox sexe = new GroupBox();
                    sexe.Controls.Add(Smasculin);
                    sexe.Controls.Add(Sfeminin);
                    //... Propriété GoupBox... ajout dans Controls... 
                    string checke = string.Empty;
                    foreach (RadioButton RB in sexe.Controls)
                    {
                        if (RB.Checked == true)
                            checke += RB.Text;
                    }
                    AccesBd.inscription(Sutilisateur.Text, Smdp.Text, Snom.Text, Sprenom.Text, checke, "V", Snaissance.Value.ToString("MM-dd-yyyy"));

                    MessageBox.Show("Vous êtes inscrit !, veuillez vous connecter maintenant "+ Sutilisateur.Text);
                
                }
                else
                {
                    MessageBox.Show("Saisir tous les champs");
                }
                
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }
    }
}