
namespace ProjectUSI.Doctor.Model
{
    /// <summary>
    /// This class represents one appointment.
    /// </summary>
    public class Appointments
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Patient { get; set; }
        public string PatientEmail { get; set; }
        public string Doctor { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string EndTime { get; set; }
        
        public override string ToString()
        {
            return Id + "\t" + Type + "\t" + Patient + "\t" + PatientEmail + "\t" + Doctor + "\t" + Date + "\t" + Time +
                   "\t" + EndTime;
        }

    }
}