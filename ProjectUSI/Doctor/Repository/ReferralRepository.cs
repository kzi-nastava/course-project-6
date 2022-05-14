using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using ProjectUSI.Doctor.Model;

namespace ProjectUSI.Doctor.Repository
{
    public class ReferralRepository
    {
        public List<Referral> referrals;
        
        public ReferralRepository()
        {
            string json = File.ReadAllText(@"..\..\Doctor\Data\Referrals.json");
            List<Referral> referral = JsonConvert.DeserializeObject<List<Referral>>(json);
            referrals = referral;
        }
        public List<Referral> GetReferrals()
        {
            return this.referrals;
        }
    }
}