using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//librairie Mysql ajouté
using System.Text;
using MySql.Data.MySqlClient;

namespace Application_vacances_activite
{
    public partial class Faccueil1 : Form
    {
        public Faccueil1()
        {
            InitializeComponent();
            typeActivite.DropDownStyle = ComboBoxStyle.DropDownList; // empeche la saisie dans comboBox
            AccesBd.connexion();
            foreach (TypeActivite typeAct in AccesBd.GetListeTypeAct())
            {
                typeActivite.Items.Add(typeAct);
            }
            //if (lbActivite.SelectedItem != null)
            //{
            //    Activite activite1 = (Activite)lbActivite.SelectedItem;
            //    Nom_act.Text = activite1.GetNomAct();
            //    Nom_act.Text = "ana";
            //}

        }

        public Button GetBtConnexion()
        {
            return acces_connexion;
        }

        public Button GetBtDeconnexion()
        {
            return acces_deconnexion;
        }

        public Button GetBtInscription()
        {
            return acces_inscription;
        }

        public Label GetBtTitreAccueil()
        {
            return titre1;
        }

        
       
        private void acces_connexion_Click(object sender, EventArgs e)
        {
            FformulaireCo f2 = new FformulaireCo(this);
            f2.Show();
            
        }

        private void acces_inscription_Click(object sender, EventArgs e)
        {
            Finscription Finscription = new Finscription();
            Finscription.Show();
            
        }

        private void acces_deconnexion_Click(object sender, EventArgs e)
        {
            acces_deconnexion.Visible = false;
            if(FformulaireCo.connecte == true)
            {
                AccesBd.deconnexion();
                FformulaireCo.connecte = false;
                Faccueil1 f1 = new Faccueil1();
                f1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Vous devez etre connecté");
            }
        }

        public string getTypeAct()
        {
            return typeActivite.SelectedItem.ToString();
        }

        
        
        private void button1_Click(object sender, EventArgs e) // recherche actvité
        {
            AccesBd.connexion();
            

            //lbActivite.Items.AddRangeAccesBd.GetToutesActivites().ToArray<Activite>());

            if (typeActivite.SelectedItem.ToString() == "toutesActivites")
            {
                lbActivite.Items.Clear();

                foreach (Activite activite in AccesBd.GetToutesActivites())
                {
                    lbActivite.Items.Add(activite);                  
                }
            }
            else if (typeActivite.SelectedItem.ToString() == "Sport")
            {
                lbActivite.Items.Clear();
                foreach (Activite activite in AccesBd.GetRechercheAct(typeActivite.SelectedItem.ToString()))
                {
                    lbActivite.Items.Add(activite);
                }
            }
            else if (typeActivite.SelectedItem.ToString() == "Sport Extreme")
            {
                lbActivite.Items.Clear();
                foreach (Activite activite in AccesBd.GetRechercheAct(typeActivite.SelectedItem.ToString()))
                {
                    lbActivite.Items.Add(activite);
                }
            }
            else if (typeActivite.SelectedItem.ToString() == "Detente")
            {
                lbActivite.Items.Clear();
                foreach (Activite activite in AccesBd.GetRechercheAct(typeActivite.SelectedItem.ToString()))
                {
                    lbActivite.Items.Add(activite);
                }
            }
            else if (typeActivite.SelectedItem.ToString() == "Culture")
            {
                lbActivite.Items.Clear();
                foreach (Activite activite in AccesBd.GetRechercheAct(typeActivite.SelectedItem.ToString()))
                {
                    lbActivite.Items.Add(activite);
                }
            }
            else if (typeActivite.SelectedItem.ToString() == "Creatif")
            {
                lbActivite.Items.Clear();
                foreach (Activite activite in AccesBd.GetRechercheAct(typeActivite.SelectedItem.ToString()))
                {
                    lbActivite.Items.Add(activite);
                }
            }
            else
            {
                MessageBox.Show("Saisir un type d'actvité");
            }

        }

        private void button2_Click(object sender, EventArgs e) // valider resa
        {
            
            if (FformulaireCo.connecte == true)
            {
                
                if (lbActivite.SelectedIndex==-1)
                {
                    MessageBox.Show("Choisir une actvité");
                }
                else
                {                   
                    AccesBd.connexion();                   
                    //int Place_disponible = activite.GetnbrPersoMax() - nbrTotal;
                    //PlaceDisponible.Text = Convert.ToString(Place_disponible);
                    Activite activite = (Activite)lbActivite.SelectedItem;
                    Donnees.SetNomAct(activite.GetNomAct());
                    int reste = activite.GetnbrPersoMax()- int.Parse(nbrParticipants.Text);
                    

                    if(reste>=0)
                    {
                        if (AccesBd.resa(activite.GetID_ACT(), Donnees.getUtilistauer(), int.Parse(nbrParticipants.Text)))
                        {
                            reste-= int.Parse(nbrParticipants.Text);
                            
                            
                            Donnees.setDateActivite(dateAct.Text);
                            
                            MessageBox.Show(" vous avez réservé !");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Place complete");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vous devez être connecté afin de réserver une activité");
            }
        }

        public void verif_entier(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void nbrParticipants_KeyPress(object sender, KeyPressEventArgs e)
        {
            verif_entier(e);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (FformulaireCo.connecte == true)
            {
                Fresa f4 = new Fresa();
                f4.Show();
            }
            else
            {
                MessageBox.Show("Vous devez être connecté");
            }
                
        }

        private void lbActivite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbActivite.SelectedItem != null)
            {
                Activite activite1 = (Activite)lbActivite.SelectedItem;
                Nom_act.Text = activite1.GetNomAct();
            }
               
        }
    }
}
