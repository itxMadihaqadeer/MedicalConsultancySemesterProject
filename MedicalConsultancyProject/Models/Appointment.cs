namespace MedicalConsultancyProject.Models
{
    public class Appointment
    {

        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public int DoctorId { get; set; }
        public DateTime SelectedDate { get; set; }
        public DateTime SelectedTime { get; set; }
        public string ProblemDescription { get; set; }
    }
}
