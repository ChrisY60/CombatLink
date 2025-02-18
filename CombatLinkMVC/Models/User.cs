namespace CombatLinkMVC.Models
{
    public class User
    {
        string FirstName { get; set; }
        public string LastName { get; set; }
        int age { get; set; }
        int weight { get; set; }
        int height { get; set; }
        ICollection<Sport> Sports;
        int yearsOfExperience { get; set; }
        ICollection<Language> Languages;

    }
}
