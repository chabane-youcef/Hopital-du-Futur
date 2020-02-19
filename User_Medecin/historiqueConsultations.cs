using RemoteMedecin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Medecin
{
    
    public partial class historiqueConsultations : Form
    {
        I_Medecin objMedecin;
        int currentIdMedecin;
        Patient currentPatient = null;
        public historiqueConsultations(int currentIdMedecin)
        {
            this.currentIdMedecin = currentIdMedecin;
            InitializeComponent();
            objMedecin = (I_Medecin)Activator.GetObject(typeof(I_Medecin), "tcp://localhost:4747/ObjMedecin");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez vous retourner vers acceuil ?", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               
                    MainMedecin mainMed = new MainMedecin(currentIdMedecin);
                    this.Hide();
                    mainMed.ShowDialog();
                
            }
        }

        private void listPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPatients.SelectedItems.Count > 0)
            {
                ListViewItem item = listPatients.SelectedItems[0];
                currentPatient = (Patient)item.Tag;
            }
        }

        private void btnHistorique_Click_1(object sender, EventArgs e)
        {
            if (currentPatient == null)
            {
                MessageBox.Show("svp selectionner un patient!");
                return;
            }
            else
            {
                Historique historique = new Historique(currentIdMedecin, currentPatient);
                List<EtatPatient> etats = objMedecin.listEtat(currentPatient.idPatient);

                historique.ListEtatsPatient.Items.Clear();

                foreach(EtatPatient ep in etats)
                {
                    ListViewItem item = new ListViewItem(new string[] { ep.idEtatPatient.ToString(), ep.traitement.ToString(), ep.date, ep.note});
                    item.Tag = ep;
                    historique.ListEtatsPatient.Items.Add(item);
                }

                this.Hide();
                historique.ShowDialog();

            }
        }
    
    }
}
