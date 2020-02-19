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
    public partial class Urgences : Form
    {
        int currentIdMedecin=0;
        I_Medecin objMedecin;
        Patient currentPatient = null;
        public Urgences(int idMedecin)
        {
            this.currentIdMedecin = idMedecin;
            
            objMedecin = (I_Medecin)Activator.GetObject(typeof(I_Medecin), "tcp://localhost:4747/ObjMedecin");
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez vous quitter ?", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MainMedecin mainMed = new MainMedecin(currentIdMedecin);
                this.Hide();
                mainMed.ShowDialog();
            }
        }

        private void listViewUrgences_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewUrgences.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewUrgences.SelectedItems[0];
                currentPatient = (Patient)item.Tag;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(currentPatient != null)
            {
                GestionUrgence gestionUrgence = new GestionUrgence(currentIdMedecin, currentPatient.idUrgence);
                gestionUrgence.textBoxNom.Text = currentPatient.nom;
                gestionUrgence.textBoxPrenom.Text = currentPatient.prenom;
                gestionUrgence.textBoxAge.Text = currentPatient.age.ToString();
                gestionUrgence.textBoxMaladie.Text = currentPatient.maladie;

                this.Hide();
                gestionUrgence.ShowDialog();
            }
            else
            {
                MessageBox.Show("svp selectionner un patient!");
                return;
            }
            

        }
    }
}
