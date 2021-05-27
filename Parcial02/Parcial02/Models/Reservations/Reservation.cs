using System;

using Parcial02.Models.Specialities;
using Parcial02.Models.Users;
namespace Parcial02.Models.Reservations
{
    public class Reservation
    {
        public int Id { get; set; }
        public User UserFk { get; set; }
        public Speciality SpecialityFk { get; set; }
        
        public DateTime MyDate { get; set; }
        
        public Reservation()
        {
            
        }

        public Reservation(User UserFk, Speciality SpecialityFk, DateTime MyDate)
        {
            this.UserFk = UserFk;
            this.SpecialityFk = SpecialityFk;
            this.MyDate = MyDate;
        }
    }
}