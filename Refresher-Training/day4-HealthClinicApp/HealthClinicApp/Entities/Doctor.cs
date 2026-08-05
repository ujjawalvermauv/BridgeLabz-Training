namespace HealthClinicApp.Entities
{
    public class Doctor
    {
        public int DoctorID { get; set; }

        public string Name { get; set; }

        public string Specialty { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public int ExperienceYears { get; set; }
    }
}