namespace PHCApplication.Models
{
    public class NurseMonitoring
    {
        public int Id { get; set; }
        public string PatientId { get; set; }
        public DateTime Timestamp { get; set; }
        public decimal Temperature { get; set; }
        public int HeartRate { get; set; }
        // Add more vital sign parameters
    }

}

