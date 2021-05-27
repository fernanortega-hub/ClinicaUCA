using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Parcial02.Models.Security_Questions;

namespace Parcial02.Models.Users
{
    public class User
    {
        [Key] public string CarnetId { get; set; }
        public string Name { get; set; }
        public string Pass { get; set; }
        public Security_Question questionFK { get; set; }
        public string Answer { get; set; }

        public User()
        {
            
        }

        public User(string CarnetId, string Name, string Pass, Security_Question questionFk, string Answer)
        {
            this.CarnetId = CarnetId;
            this.Name = Name;
            this.Pass = Pass;
            this.questionFK = questionFk;
            this.Answer = Answer;
        }
    }
    
    
    
    
}