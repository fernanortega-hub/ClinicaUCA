using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Parcial02.Context;
using Parcial02.Models.Users;

namespace Parcial02
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCreateUser newfrmCreate = new frmCreateUser();
            
                newfrmCreate.ShowDialog();
                
        }


        private void btnChangePass_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmchange = new frmChangePass();
            frmchange.ShowDialog();
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            txtUser.ForeColor = Color.Black;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.ForeColor = Color.Black;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Obteniendo a los usuarios registrados en la db
            var db = new ParcialContext();
            List<User> users = db.Users.ToList();
            
            // Variables para validar al usuario
            string carnetid = txtUser.Text;
            string password = txtPassword.Text;

            // Comparando datos ingresados con datos almacenados
            List<User> result = users
                .Where(us => us.CarnetId == carnetid &&
                             us.Pass == password).ToList();
            
            // validaciones
            if (result.Count() > 0)
            {
                MessageBox.Show($"Bienvenido {carnetid}", "Sesión iniciada",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
		frmPrincipal principal = new frmPrincipal(result[0]);
                principal.Show();
                this.Hide();	
            }
            else
            {
                MessageBox.Show("El carnet ingresado no es correcto o no existe!", "Clínica UCA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtUser_Enter(object sender, EventArgs e)
        {
            txtUser.Clear();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            var window = MessageBox.Show(
                "¿Está seguro que desea salir?", 
                "Salir", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            e.Cancel = (window == DialogResult.No);


        }
    }
}