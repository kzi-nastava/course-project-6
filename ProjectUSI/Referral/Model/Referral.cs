namespace ProjectUSI.Doctor.Model
{
    /// <summary>
    /// This class represents one referral.
    /// </summary>
    public class Referral
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string LBO { get; set; }
        public string Phone { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string PreviousIllnesses { get; set; }
        public string Allergens { get; set; }
        public string Anamnesis { get; set; }
        public string ChosenDoctor { get; set; }
        
        public override string ToString()
        {
            return Name + "\t" + Surname + "\t" + Email + "\t" + LBO + "\t" + Phone + "\t" + Height + "\t" + Weight + "\t" + 
                   PreviousIllnesses + "\t" + Allergens + "\t" + Anamnesis + "\t" + ChosenDoctor;
        }
        
    }
}