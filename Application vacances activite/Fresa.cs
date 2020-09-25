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
    public partial class Fresa : Form
    {
        public Fresa()
        {
            InitializeComponent();
            
            
            user.Text = Donnees.getUtilistauer();
            AccesBd.connexion();
            //MessageBox.Show(AccesBd.RechercheID_ACT().ToString());
            
            if (FformulaireCo.connecte == true)
            {
                foreach(Reservation resa in AccesBd.VoirMesResa())
                {
                    ListMesResa.Items.Add(resa);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            Reservation r = (Reservation)ListMesResa.SelectedItem;
           
            AccesBd.SuprimmerResa(r.GetID_RESA());
            ListMesResa.Items.Remove(ListMesResa.SelectedItem);
            MessageBox.Show("vous avez supprimé la réservation");

        }
    }
}
