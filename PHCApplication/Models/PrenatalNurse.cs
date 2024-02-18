namespace PHCApplication.Models
{
    public class PrenatalNurse
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string LicenseNumber { get; set; }

        public string Specialization { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string Certification { get; set; }

        // Other relevant properties

        // Relationships, if applicable
        // public List<PrenatalCarePlan> CarePlans { get; set; }
    }

}

