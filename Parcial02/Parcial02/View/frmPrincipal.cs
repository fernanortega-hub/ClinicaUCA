using System;
using System.Windows.Forms;
using Parcial02.Models.Users;


namespace Parcial02
{
    public partial class frmPrincipal : Form
    {
        private User user { get; set; }
        public frmPrincipal(User user)
        {
            InitializeComponent();
            this.user = user; 
        }


        private void btnDoReservation_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReservation reservation = new frmReservation(user);
            reservation.ShowDialog();
           
        }
        
        private void btnShowR_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCitasEx showCitas = new frmCitasEx(user); 
            showCitas.ShowDialog();
            
        }

        private void tabDate_MouseEnter(object sender, EventArgs e)
        {
            this.Hide();
            frmReservation reservation = new frmReservation(user);
            reservation.ShowDialog();
           
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("¿Seguro que deseas salir?", "Clínica UCA",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        }

      
        private void tabView_Enter(object sender, EventArgs e)
        {
            this.Hide();
            frmCitasEx citas = new frmCitasEx(user);
            citas.ShowDialog();
        }

        private void btnUpdateANDCancel_Click(object sender, EventArgs e)
        {   
            this.Hide();
            frmDatesUpdate frmDatesUpdate = new frmDatesUpdate(user);
            frmDatesUpdate.ShowDialog();
        }

        private void tabUpdate_Enter(object sender, EventArgs e)
        {
            this.Hide();
            frmDatesUpdate frmDatesUpdate = new frmDatesUpdate(user);
            frmDatesUpdate.ShowDialog();
        }
    }
}