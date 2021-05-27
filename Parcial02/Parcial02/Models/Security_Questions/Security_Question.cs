namespace Parcial02.Models.Security_Questions
{
    public class Security_Question
    {
        public int Id { get; set; }
        public string Question { get; set; }

        public Security_Question()
        {
        }

        public Security_Question(int Id, string Question)
        {
            this.Id = Id;
            this.Question = Question;
        }
    }
}