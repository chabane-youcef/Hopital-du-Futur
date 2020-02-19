using RemoteAdministrateur;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrateur
{
    public partial class UpdatePatient : Form
    {
        I_Administrateur obj;
        public UpdatePatient()
        {
            InitializeComponent();
            obj = (I_Administrateur)Activator.GetObject(typeof(I_Administrateur), "tcp://localhost:1099/ObjAdministrateur");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            GestionPatient gestionPatient = new GestionPatient();
            List<Patient> patients = obj.ListPatients();
            gestionPatient.lvPatients.Items.Clear();

            foreach (Patient p in patients)
            {
                ListViewItem item = new ListViewItem(new string[] { p.idPatient.ToString(), p.nomPatient, p.prenomPatient, p.agePatient.ToString(), p.maladiePatient });
                item.Tag = p;

                gestionPatient.lvPatients.Items.Add(item);
            }

            this.Hide();
            gestionPatient.ShowDialog();
        }

        private void btnModifierPatient_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxId.Text);
            string nom = textBoxNom.Text;
            string prenom = textBoxPrenom.Text;
            int age = int.Parse(textBoxAge.Text);
            int maladie = int.Parse(comboBoxSpecialite.SelectedValue.ToString());

            Patient p = new Patient(id, nom, prenom, age, maladie);

            if (obj.updatePersonne(p))
            {
                if (obj.updatePatient(p))
                {
                    GestionPatient gestionPatient = new GestionPatient();
                    List<Patient> patients = obj.ListPatients();
                    gestionPatient.lvPatients.Items.Clear();

                    foreach (Patient pt in patients)
                    {
                        ListViewItem item = new ListViewItem(new string[] { pt.idPatient.ToString(), pt.nomPatient, pt.prenomPatient, pt.agePatient.ToString(), pt.maladiePatient });
                        item.Tag = pt;

                        gestionPatient.lvPatients.Items.Add(item);
                    }

                    this.Hide();
                    gestionPatient.ShowDialog();
                }
            }else
            {
                MessageBox.Show("modification n'etait pas effectuer!");
                return;
            }


        }
    }
}
