namespace PHCApplication.Models
    {
        public class PrenatalCarePlan
        {
            public int Id { get; set; }
            public string PatientName { get; set; }
            public DateTime DueDate { get; set; }
            //public string SelectedVitamin { get; set; }
            public List<Assessment> Assessments { get; set; }
            public string Vitamins { get; set; }
            // Other properties
        }

        public class Assessment
        {
            public int Id { get; set; }
            public string Description { get; set; }
            public DateTime Date { get; set; }
            // Other properties
        }
    }
