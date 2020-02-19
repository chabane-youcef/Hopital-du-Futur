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
    public partial class UpdateInfirmiere : Form
    {
        I_Administrateur obj;
        public UpdateInfirmiere()
        {
            InitializeComponent();
            obj = (I_Administrateur)Activator.GetObject(typeof(I_Administrateur), "tcp://localhost:1099/ObjAdministrateur");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            GestionInfirmiere gestionInf = new GestionInfirmiere();
            this.Hide();
            List<Infirmiere> infirmiers = obj.ListInfirmiere();
            gestionInf.LvInfirmiere.Items.Clear();

            foreach (Infirmiere n in infirmiers)
            {
                ListViewItem item = new ListViewItem(new string[] { n.IdInfirmiere.ToString(), n.Nom, n.Prenom, n.Email });
                item.Tag = n;

                gestionInf.LvInfirmiere.Items.Add(item);
            }
            gestionInf.ShowDialog();
        }

        private void BtnModifierInfirmiere_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxId.Text);
            string nom = textBoxNom.Text;
            string prenom = textBoxPrenom.Text;
            string email = textBoxEmail.Text;

            Infirmiere infermiere = new Infirmiere(id, nom, prenom, email);
            if (obj.ModifierInfirmiere(infermiere))
            {
                GestionInfirmiere gestionInfirmiere = new GestionInfirmiere();
                List<Infirmiere> infirmiers = obj.ListInfirmiere();
                gestionInfirmiere.LvInfirmiere.Items.Clear();

                foreach (Infirmiere n in infirmiers)
                {
                    ListViewItem item = new ListViewItem(new string[] { n.IdInfirmiere.ToString(), n.Nom, n.Prenom, n.Email });
                    item.Tag = n;

                    gestionInfirmiere.LvInfirmiere.Items.Add(item);
                }
                this.Hide();
                gestionInfirmiere.ShowDialog();
            }
            else
            {
                MessageBox.Show("voulez vous ressayer ?");
                return;
            }
        }
    }
}
