using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Patients.Models;

namespace ProjectUSI.Polls.Repository
{
    public class DoctorsPollsRepository
    {
        private List<DoctorQuery> _doctorQueries;
        
        public DoctorsPollsRepository()
        {
            string json = File.ReadAllText(@"..\..\Data\doctorQueries.json");
            List<DoctorQuery> doctorQueries = JsonConvert.DeserializeObject<List<DoctorQuery>>(json);
            _doctorQueries = doctorQueries;
        }

        public List<DoctorQuery> GetPolls()
        {
            return _doctorQueries;
        }
        public void Save()
        {
            File.WriteAllText(@"..\..\Data\doctorQueries.json", JsonConvert.SerializeObject(_doctorQueries));
        }
    }
}