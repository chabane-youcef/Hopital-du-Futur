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
    public partial class Historique : Form
    {
        I_Medecin objMedecin;
        int currentIdMedecin;
        Patient currentPatient;
        public Historique(int currentIdMedecin, Patient currentPatient)
        {
            this.currentPatient = currentPatient;
            this.currentIdMedecin = currentIdMedecin;
            InitializeComponent();
            objMedecin = (I_Medecin)Activator.GetObject(typeof(I_Medecin), "tcp://localhost:4747/ObjMedecin");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez vous retourner vers acceuil ?", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                historiqueConsultations historique = new historiqueConsultations(currentIdMedecin);
                List<Patient> patients = objMedecin.listPatients(currentIdMedecin);

                historique.listPatients.Items.Clear();

                foreach (Patient p in patients)
                {
                    ListViewItem item = new ListViewItem(new string[] { p.id.ToString(), p.nom, p.prenom, p.age.ToString(), p.countConsutlations.ToString() });
                    item.Tag = p;
                    historique.listPatients.Items.Add(item);
                }
                this.Hide();
                historique.ShowDialog();
            }
                
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            historiqueConsultations historique = new historiqueConsultations(currentIdMedecin);
            List<Patient> patients = objMedecin.listPatients(currentIdMedecin);

            historique.listPatients.Items.Clear();

            foreach (Patient p in patients)
            {
                ListViewItem item = new ListViewItem(new string[] { p.id.ToString(), p.nom, p.prenom, p.age.ToString(), p.countConsutlations.ToString() });
                item.Tag = p;
                historique.listPatients.Items.Add(item);
            }
            this.Hide();
            historique.ShowDialog();
        }
    }
}
