using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Parcial02.Context;
using System.Linq;
using Parcial02.Models.Reservations;
using Parcial02.Models.Specialities;
using Parcial02.Models.Users;

namespace Parcial02
{
    public partial class frmDatesUpdate : Form
    {
        private User user { get; set; }
        public frmDatesUpdate(User user)
        {
            InitializeComponent();
            this.user = user;
        }
        
        private void ChargeDate()
        {
            var db = new ParcialContext();
           
            cmbEspecialidad.DataSource = db.Specialities.ToList();
            cmbEspecialidad.DisplayMember = "SpecialityName";
            cmbEspecialidad.ValueMember = "id";
            //Rellenando el dataGridview
            var listaReservas = db.Reservations.Include(r => r.UserFk)
                .Include(r => r.SpecialityFk)
                .Select(r => new{Id = r.Id,Carnet = r.UserFk.CarnetId,Nombre = r.UserFk.Name, 
                    Especialidad = r.SpecialityFk.SpecialityName, Fecha = r.MyDate})
                .ToList();
            
            //Mostrar datos
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaReservas;
        }

        private void frmDatesUpdate_Load(object sender, EventArgs e)
        {
            var db = new ParcialContext();
           
            cmbEspecialidad.DataSource = db.Specialities.ToList();
            cmbEspecialidad.DisplayMember = "SpecialityName";
            cmbEspecialidad.ValueMember = "id";
            //Rellenando el dataGridview
            ChargeDate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var box = MessageBox.Show("¿Seguro que desea eliminar esta cita?", "Clínica UCA",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                
            var db = new ParcialContext();

            if (box == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtIdDate.Text);
                var reservation = db.Reservations
                    .Where(r => r.Id.Equals(id)).ToList();
                db.Remove(reservation[0]);
                db.SaveChanges();
                ChargeDate();
            }
            else
            {
                ChargeDate();
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var db = new ParcialContext();
            int id = Convert.ToInt32(txtIdDate.Text);
            List<Reservation> reservations = db.Reservations
                .Include(us => us.UserFk)
                .Include(sp => sp.SpecialityFk)
                .ToList();
            
            // Buscando el id de la cita
            List<Reservation> result = reservations
                .Where(r => r.Id == id)
                .ToList();

            if (result.Count()>0)
            {
                Reservation res = (from vare in db.Reservations
                    where vare.Id == id
                    select vare).First();
                lblSpecial.Text = (res.SpecialityFk.SpecialityName);
                
                Speciality speciality = (Speciality) cmbEspecialidad.SelectedItem;

                Speciality spec = db.Set<Speciality>()
                    .SingleOrDefault(s => s.id == speciality.id);
                res.SpecialityFk = spec;

                res.MyDate = dtpTime.Value;
                db.SaveChanges();

                MessageBox.Show("Cita actualizada", "Clínica UCA",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                ChargeDate();
            }

            
        }

        private void frmDatesUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmPrincipal frmPrincipal = new frmPrincipal(user);
            frmPrincipal.ShowDialog();
        }
    }
}