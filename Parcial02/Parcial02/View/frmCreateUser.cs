using System;
using System.Linq;
using System.Windows.Forms;
using Parcial02.Context;
using Parcial02.Models.Security_Questions;
using Parcial02.Models.Users;

namespace Parcial02
{
    public partial class frmCreateUser : Form
    {
        public frmCreateUser()
        {
            InitializeComponent();
        }

        private void frmCreateUser_Load(object sender, EventArgs e)
        {
            var db = new ParcialContext();
            cmbQuestions.DataSource = db.SecurityQuestions.ToList();
            cmbQuestions.DisplayMember = "question";
            cmbQuestions.ValueMember = "id";
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            bool validation = //validaciones para aceptar datos 
                txtPass.Text.Length > 6 &&
                (txtPass.Text == txtRPass.Text);

            if (validation)
            {
                string id = txtCarnet.Text;
                string user = txtUsername.Text.Trim();
                string password = txtPass.Text;
                string answer = txtAnwser.Text;
                Security_Question sqRef = (Security_Question) cmbQuestions.SelectedItem;
                
                //Como base se tiene la ref a la pregunta de seguridad
                // obtendremos la pregunta de la database
                var dbU = new ParcialContext();
                Security_Question question = dbU.Set<Security_Question>()
                    .SingleOrDefault(sq => sq.Id == sqRef.Id);

                //Crear al usuario y subir los datos a la database
                // Manejo de excepciones al querer ingresar un usuario ya existente
                try
                {
                    User newUser = new User(id, user, password, question, answer);
                    dbU.Add(newUser);
                    dbU.SaveChanges();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("El perfil que se desea crear ya existe. Intenta con otro", "Clínica UCA - Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                
                
                // Notificando al usuario
                MessageBox.Show("El perfil fue creado exitosamente", "Clínica UCA",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

            }
            else
            {
                MessageBox.Show("Datos invalidos", "Clínica UCA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void frmCreateUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            var showLogin = new frmLogin();
            showLogin.Show();
        }
    }
}