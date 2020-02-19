
using RemoteMedecin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Medecin
{
    public partial class Login : Form
    {
        //I_Infirmiere_Events objEvent;
        I_Medecin objMedecin;
        public Login()
        {
            InitializeComponent();
            objMedecin = (I_Medecin)Activator.GetObject(typeof(I_Medecin), "tcp://localhost:4747/ObjMedecin");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez vous quitter ?", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;
           
            Medecin medecin = new Medecin(email, password);
            int idMedecin = objMedecin.Login(medecin);
            if (idMedecin !=0)
            {

                MainMedecin main = new MainMedecin(idMedecin);
                if (objMedecin.verifyUrgence(idMedecin))
                {
                    main.btnUrgence.Visible = true;
                    main.btnUrgence.BringToFront();
                }
                else
                {
                    main.btnUrgence.Visible = false;
                    main.btnUrgence.SendToBack();
                }
                this.Hide();
                main.ShowDialog();
            }
            else
            {
                MessageBox.Show("email ou mot de passe erroné !");
            }


        }
    }
}
