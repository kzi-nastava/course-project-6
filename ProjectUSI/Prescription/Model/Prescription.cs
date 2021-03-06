namespace ProjectUSI.Doctor.Model
{
    /// <summary>
    /// This class represents one prescription.
    /// </summary>
    public class Prescription
        {
            public string PatientEmail { get; set; }
            public string Medication { get; set; }
            public string Instruction { get; set; }
            public string Time { get; set; }
        
            public override string ToString()
            {
                return PatientEmail + "\t" + Medication + "\t" + Instruction + "\t" + Time;
            }

        }
    
}