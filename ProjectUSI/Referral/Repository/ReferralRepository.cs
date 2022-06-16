using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using ProjectUSI.Doctor.Model;

namespace ProjectUSI.Doctor.Repository
{
    /// <summary>
    /// This class gets referrals from file.
    /// </summary>
    public class ReferralRepository
    {
        public List<Referral> referrals;
        
        public ReferralRepository()
        {
            string json = File.ReadAllText(@"..\..\Data\Referrals.json");
            List<Referral> referral = JsonConvert.DeserializeObject<List<Referral>>(json);
            referrals = referral;
        }
        public List<Referral> GetReferrals()
        {
            return this.referrals;
        }
        public void Save()
        {
            File.WriteAllText(@"..\..\Data\Referalls.json", 
                JsonConvert.SerializeObject(referrals));
        }
    }
}