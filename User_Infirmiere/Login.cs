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
    public partial class Login : Form
    {
        I_Infirmiere obj;
        public Login()
        {
            InitializeComponent();
            obj = (I_Infirmiere)Activator.GetObject(typeof(I_Infirmiere), "tcp://localhost:7474/ObjInfirmiere");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez vous quitter ?", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            Infirmiere inf = new Infirmiere(email, password);
            if (obj.Login(inf))
            {
                MainInfirmiere mainInf = new MainInfirmiere();
                this.Hide();
                mainInf.ShowDialog();
            }else
            {
                MessageBox.Show("email ou mot de passe erroné");
                return;
            }

        }
    }
}
