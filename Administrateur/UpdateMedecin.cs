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
    public partial class UpdateMedecin : Form
    {
        I_Administrateur obj;
        public UpdateMedecin()
        {
            InitializeComponent();
            obj = (I_Administrateur)Activator.GetObject(typeof(I_Administrateur), "tcp://localhost:1099/ObjAdministrateur");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GestionMedecin gestion = new GestionMedecin();
            List<Medecin> medecins = obj.ListMedecins();
            gestion.LvMedecins.Items.Clear();

            foreach (Medecin m in medecins)
            {
                ListViewItem item = new ListViewItem(new string[] { m.IdMedecin.ToString(), m.Nom, m.Prenom, m.Email, m.SpecialiteNom });
                item.Tag = m;

                gestion.LvMedecins.Items.Add(item);
            }

            this.Hide();
            gestion.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxId.Text);
            string nom = textBoxNom.Text;
            string prenom = textBoxPrenom.Text;
            string email = textBoxEmail.Text;
            int idSpecialite = int.Parse(comboBoxSpecialite.SelectedValue.ToString());

            if (string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(prenom) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("input est vide");
                return;
            }

            Medecin med = new Medecin(id, nom, prenom, email, idSpecialite);
            if (obj.ModifierPersonne(med))
            {
                if (obj.ModifierMedecin(med))
                {
                    GestionMedecin gestionMedecin = new GestionMedecin();

                    List<Medecin> medecins = obj.ListMedecins();
                    gestionMedecin.LvMedecins.Items.Clear();

                    foreach (Medecin m in medecins)
                    {
                        ListViewItem item = new ListViewItem(new string[] { m.IdMedecin.ToString(), m.Nom, m.Prenom, m.Email, m.SpecialiteNom, m.Password });
                        item.Tag = m;

                        gestionMedecin.LvMedecins.Items.Add(item);
                    }
                    this.Hide();
                    gestionMedecin.ShowDialog();
                }
            }else
            {
                MessageBox.Show("SVP voulez vous essayer un autre fois ?");
                return;
            }
        }
    }
}
