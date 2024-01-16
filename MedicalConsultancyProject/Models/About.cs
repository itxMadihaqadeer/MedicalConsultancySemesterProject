namespace MedicalConsultancyProject.Models
{
    public class About
    {

        public string FullName { get; set; }
        public string Bio { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        // Add any other properties you need for your About page

        // Constructor to initialize the model
        public About(string fullName, string bio, DateTime birthDate, string email, string website)
        {
            FullName = fullName;
            Bio = bio;
            BirthDate = birthDate;
            Email = email;
            Website = website;
        }
    }
}
