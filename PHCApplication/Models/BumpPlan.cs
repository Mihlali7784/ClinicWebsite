namespace PHCApplication.Models
{
    public class BumpPlan
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string MedicalCondition { get; set; }
        public string Medications { get; set; } // Current medications
        public string Allergies { get; set; } // Known allergies
        public bool Smoker { get; set; } // Smoking status
        public bool AlcoholConsumption { get; set; } // Alcohol consumption status
        public bool SubstanceAbuse { get; set; } // Substance abuse history
        public List<string> Surgeries { get; set; } // List of past surgeries
        public List<string> FamilyMedicalHistory { get; set; } // Family medical history
        public List<string> PreviousPregnancies { get; set; } // Details of previous pregnancies
    }
}

