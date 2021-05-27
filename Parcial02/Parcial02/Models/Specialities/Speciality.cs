

namespace Parcial02.Models.Specialities
{
    public class Speciality
    {
        public int id { get; set; }
        public string SpecialityName { get; set; }

        public Speciality()
        {
            
        }

        public Speciality(int id, string specialityName)
        {
            this.id = id;
            this.SpecialityName = SpecialityName;
        }
    }
}