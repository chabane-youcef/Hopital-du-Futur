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
    public partial class PrendreRendezVous : Form
    {
        I_Infirmiere obj;
        private Patient SelectedPatient = null;
        private Medecin CurrentMedecinDispo = null;
        public PrendreRendezVous()
        {
            InitializeComponent();
            obj = (I_Infirmiere)Activator.GetObject(typeof(I_Infirmiere), "tcp://localhost:7474/ObjInfirmiere");
        }

        public PrendreRendezVous(Patient p)
        {
            this.SelectedPatient = p;
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

        private void ListMedecinsDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListMedecinsDisponibles.SelectedItems.Count > 0)
            {
                ListViewItem item = ListMedecinsDisponibles.SelectedItems[0];
                CurrentMedecinDispo = (Medecin)item.Tag;
            }
        }

        private void btnConsulterCreneaux_Click(object sender, EventArgs e)
        {
            if(CurrentMedecinDispo != null)
            {
                SelectionnerCreneaux selectionCreneau = new SelectionnerCreneaux(SelectedPatient,CurrentMedecinDispo);

                List<Creneaux> creneaux = obj.ListCreneauxMedecin(CurrentMedecinDispo.id);

                foreach(Creneaux c in creneaux)
                {
                    if (c.etat == true)
                    {
                        ListViewItem item = new ListViewItem(new string[] { c.id.ToString(), c.jour, c.date, c.debut, "reserve" });
                        item.SubItems[4].BackColor = Color.Red;

                        item.Tag = c;
                        selectionCreneau.listCreneauxMedecin.Items.Add(item);
                    }
                    else
                    {
                        ListViewItem item = new ListViewItem(new string[] { c.id.ToString(), c.jour, c.date, c.debut, "libre" });
                        item.SubItems[4].BackColor = Color.Green;

                        item.Tag = c;
                        selectionCreneau.listCreneauxMedecin.Items.Add(item);
                    }
                }

                this.Hide();
                selectionCreneau.ShowDialog();

            }
            else
            {
                MessageBox.Show("svp selectionner Medecin!");
                return;
            }
        }
    }
}
