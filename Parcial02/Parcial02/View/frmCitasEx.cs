using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Parcial02.Context;
using User = Parcial02.Models.Users.User;

namespace Parcial02
{
    public partial class frmCitasEx : Form
    
    {
        private User user { get; set; }
        public frmCitasEx(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void frmCitasEx_Load(object sender, EventArgs e)
        {
            var db = new ParcialContext();
          
            //Rellenando el dataGridview
            var listaReservas = db.Reservations.Include(r => r.UserFk)
                .Include(r => r.SpecialityFk)
                .Select(r => new{Carnet = r.UserFk.CarnetId,Nombre = r.UserFk.Name, 
                    Especialidad = r.SpecialityFk.SpecialityName, Fecha = r.MyDate})
                .ToList();
            
                //Mostrar datos
                   dataGridView1.DataSource = null;
                   dataGridView1.DataSource = listaReservas;
        }

        private void frmCitasEx_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmPrincipal showPrincipal = new frmPrincipal(user);
            showPrincipal.ShowDialog();
        }
    }
}