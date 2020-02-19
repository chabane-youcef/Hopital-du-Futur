using RemoteInfirmiere;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Infirmiere
{
    public partial class AffichagePatients : Form
    {
        I_Infirmiere obj;
        private Patient CurrentPatient = null;
        public AffichagePatients()
        {
            InitializeComponent();
            obj = (I_Infirmiere)Activator.GetObject(typeof(I_Infirmiere), "tcp://localhost:7474/ObjInfirmiere");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MainInfirmiere mainInf = new MainInfirmiere();
            if (MessageBox.Show("voulez vous retourner vers acceul ?", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                this.Hide();
                mainInf.ShowDialog();
            }
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPatients.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewPatients.SelectedItems[0];
                CurrentPatient = (Patient)item.Tag;
            }
        }

        private void ConsulterRendezVous_Click(object sender, EventArgs e)
        {
            PrendreRendezVous prendreRendezvous = new PrendreRendezVous(CurrentPatient);
            prendreRendezvous.txtBoxNomPatient.Text = CurrentPatient.nom;
            prendreRendezvous.txtBoxPrenomPatient.Text = CurrentPatient.prenom;
            prendreRendezvous.txtBoxAgePatient.Text = CurrentPatient.age.ToString();

            List<Medecin> MedecinsDispo = obj.MedecinsDiponibles();

            prendreRendezvous.ListMedecinsDisponibles.Items.Clear();

            foreach(Medecin m in MedecinsDispo)
            {
                ListViewItem item = new ListViewItem(new String[] { m.id.ToString(), m.nom, m.prenom, m.specialite });
                item.Tag = m;
                prendreRendezvous.ListMedecinsDisponibles.Items.Add(item);
            }

            this.Hide();
            prendreRendezvous.ShowDialog();
        }
    }
}
