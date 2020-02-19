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
    public partial class GestionUrgence : Form
    {
        int currentIdMedecin;
        int idUrgence;
        I_Medecin objMedecin;

        public GestionUrgence(int currentIdMedecin, int idUrgence)
        {
            this.currentIdMedecin = currentIdMedecin;
            this.idUrgence = idUrgence;
            objMedecin = (I_Medecin)Activator.GetObject(typeof(I_Medecin), "tcp://localhost:4747/ObjMedecin");
            InitializeComponent();
        }

        

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            List<Patient> urgences = objMedecin.ListUrgence(currentIdMedecin);
            Urgences FormUrgences = new Urgences(currentIdMedecin);

            FormUrgences.listViewUrgences.Items.Clear();

            foreach (Patient p in urgences)
            {
                ListViewItem item = new ListViewItem(new string[] { p.idUrgence.ToString(), p.nom, p.prenom, p.age.ToString(), p.maladie });
                item.Tag = p;
                FormUrgences.listViewUrgences.Items.Add(item);
            }

            this.Hide();
            FormUrgences.ShowDialog();
        }

        private void btnEnreegistrer_Click(object sender, EventArgs e)
        {
            if (objMedecin.ConsultedUrgence(idUrgence))
            {
                List<Patient> urgences = objMedecin.ListUrgence(currentIdMedecin);
                Urgences FormUrgences = new Urgences(currentIdMedecin);

                FormUrgences.listViewUrgences.Items.Clear();

                foreach (Patient p in urgences)
                {
                    ListViewItem item = new ListViewItem(new string[] { p.idUrgence.ToString(), p.nom, p.prenom, p.age.ToString(), p.maladie });
                    item.Tag = p;
                    FormUrgences.listViewUrgences.Items.Add(item);
                }

                this.Hide();
                FormUrgences.ShowDialog();
            }
            else
            {
                MessageBox.Show("voulez vous ressayer!");
                return;
            }
        }
    }
}
