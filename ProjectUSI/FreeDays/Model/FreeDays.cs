namespace ProjectUSI.Doctor.Model
{
    public class FreeDays
    {
        public string Doctor { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Reason { get; set; }
        public Status Status { get; set; }

        public override string ToString()
        {
            return Doctor + "\t" + StartDate + "\t" + EndDate + "\t" + Reason + "\t" + Status;
        }
    }
    public enum Status
    {
        Accepted,
        OnHold,
        Rejected
    }
}