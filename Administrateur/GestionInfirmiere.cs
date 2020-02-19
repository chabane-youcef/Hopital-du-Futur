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
    public partial class GestionInfirmiere : Form
    {
        private Infirmiere currentInfirmiere;
        I_Administrateur obj;
        public GestionInfirmiere()
        {
            InitializeComponent();
            obj = (I_Administrateur)Activator.GetObject(typeof(I_Administrateur), "tcp://localhost:1099/ObjAdministrateur");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez vous quitter ?", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MainAdmin mainAdmin = new MainAdmin();
                this.Hide();
                mainAdmin.ShowDialog();
            }
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if (LvInfirmiere.SelectedItems.Count > 0)
            {
                int id = int.Parse(LvInfirmiere.SelectedItems[0].SubItems[0].Text);
                string nom = LvInfirmiere.SelectedItems[0].SubItems[1].Text;
                string prenom = LvInfirmiere.SelectedItems[0].SubItems[2].Text;
                string email = LvInfirmiere.SelectedItems[0].SubItems[3].Text;


                UpdateInfirmiere updateInf = new UpdateInfirmiere();

                updateInf.textBoxId.Text = id.ToString();
                updateInf.textBoxNom.Text = nom;
                updateInf.textBoxPrenom.Text = prenom;
                updateInf.textBoxEmail.Text = email;

                this.Hide();
                updateInf.ShowDialog();

            }
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            AjouterInfirmiere ajouterInf = new AjouterInfirmiere();
            this.Hide();
            ajouterInf.ShowDialog();
        }

        private void LvInfirmiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LvInfirmiere.SelectedItems.Count > 0)
            {
                ListViewItem item = LvInfirmiere.SelectedItems[0];
                currentInfirmiere = (Infirmiere) item.Tag;
            }
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            if(currentInfirmiere == null)
            {
                MessageBox.Show("vous n'avez pas selectioner une infirmiere !");
                return;
            }else
            {
                if(MessageBox.Show("voulez vous supprimer cette infirmiere ?","supprimer infirmiere", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    obj.SupprimerInfirmiere(currentInfirmiere);

                    List<Infirmiere> infirmiers = obj.ListInfirmiere();
                    LvInfirmiere.Items.Clear();

                    foreach (Infirmiere n in infirmiers)
                    {
                        ListViewItem item = new ListViewItem(new string[] { n.IdInfirmiere.ToString(), n.Nom, n.Prenom, n.Email });
                        item.Tag = n;

                        LvInfirmiere.Items.Add(item);
                    }
                    
                    
                }else
                {
                    MessageBox.Show("infirmiere n'a pas été supprimer", "Remove row", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MainAdmin mainAdmin = new MainAdmin();
            this.Hide();
            mainAdmin.ShowDialog();
        }
    }
}
