using System;
using System.ComponentModel;
using System.Windows.Forms;

using Parcial02.Context;
using Parcial02.Models.Security_Questions;
using Parcial02.Models.Users;
using System.Linq;

using Microsoft.EntityFrameworkCore;


namespace Parcial02
{
    public partial class frmChangePass : Form
    {
        
        public frmChangePass()
        {
            InitializeComponent();
        }

        public User newUserGlobal;
        
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void frmChangePass_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLogin showLogin = new frmLogin();
            showLogin.Show();
        }


        private void txtcarnet_Validating(object sender, CancelEventArgs e)
        {
            
            string idCarnet = txtcarnet.Text;
            var db = new ParcialContext();

            var users = db.Users
                .Include(u => u.questionFK)
                .ToList();
            var validate = users.Where(u => u.CarnetId.Equals(idCarnet)).ToList();
            bool result = validate.Count() > 0;
            
            
            if (result)
            {
                Security_Question sq = validate[0].questionFK;
                lblQuestion.Text = sq.Question;
                newUserGlobal = validate[0];
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            bool verify = txtNewPass.Text.Length > 6 && (txtNewPass.Text == txtRepeat.Text);
            var db = new ParcialContext();
            
            if (verify)
            {
                newUserGlobal.Pass = txtNewPass.Text;
                db.Update(newUserGlobal);
                db.SaveChanges();
                MessageBox.Show("¡Contraseña actualizada!", "Clínica UCA",
                    MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden. Deben ser de más de 6 caracteres", "Clínica UCA",
                    MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            
        }
    }
}