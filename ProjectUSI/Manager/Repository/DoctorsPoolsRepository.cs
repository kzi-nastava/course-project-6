using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Patients.Models;

namespace ProjectUSI.Manager.Repository
{
    public class DoctorsPoolsRepository
    {
        private List<DoctorQuery> _doctorQueries;
        
        public DoctorsPoolsRepository()
        {
            string json = File.ReadAllText(@"..\..\Data\doctorQueries.json");
            List<DoctorQuery> doctorQueries = JsonConvert.DeserializeObject<List<DoctorQuery>>(json);
            _doctorQueries = doctorQueries;
        }

        public List<DoctorQuery> GetPools()
        {
            return _doctorQueries;
        }
        public void Save()
        {
            File.WriteAllText(@"..\..\Data\doctorQueries.json", JsonConvert.SerializeObject(_doctorQueries));
        }
    }
}