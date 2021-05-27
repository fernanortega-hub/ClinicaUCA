using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Parcial02.Context;
using Parcial02.Models.Reservations;
using Parcial02.Models.Specialities;
using Parcial02.Models.Users;

namespace Parcial02
{
    public partial class frmReservation : Form
    {
        private User user { get; set; }
        public frmReservation(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        
        private void frmReservation_Load(object sender, EventArgs e)
        {
            var db = new ParcialContext();
            cmbSpecialities.DataSource = db.Specialities.ToList();
            cmbSpecialities.DisplayMember = "SpecialityName";
            cmbSpecialities.ValueMember = "id";
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            txtUser.ForeColor = Color.Black;
        }
        
        private void btnDoRes_Click(object sender, EventArgs e)
        {
            // Pasando el usuario y especialidad por referencia
            User usrRf = user;
            Speciality spclityRf = (Speciality) cmbSpecialities.SelectedItem;
            
            // Obteniendo los datos existentes
            var db = new ParcialContext();
            User usdb = db.Set<User>()
                .SingleOrDefault(u => u.CarnetId == usrRf.CarnetId);
            Speciality spedb = db.Set<Speciality>()
                .SingleOrDefault(s => s.id == spclityRf.id);
            
            
            DateTime myDate = dtpDate.Value.Date + dtpTime.Value.TimeOfDay;
            dtpTime.Format = DateTimePickerFormat.Custom;
            dtpTime.CustomFormat = "hh:mm tt";
            
            
            // Crear nueva cita y almacenarla en la db
            Reservation reservation = new Reservation(usdb,spedb,myDate);
            db.Add(reservation);
            db.SaveChanges();
            
            MessageBox.Show("La cita fue reservada!", "Clínica UCA",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }


        private void frmReservation_FormClosing(object sender, FormClosingEventArgs e)
        {
            var frmPrincipal = new frmPrincipal(user);
            frmPrincipal.ShowDialog();
        }
    }
}