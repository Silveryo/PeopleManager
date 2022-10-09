namespace PeopleManager.Ui.WebApp.Models
{
    public class Person
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Description { get; set; }
        public string Email { get; set; } = null!;
    }
}
