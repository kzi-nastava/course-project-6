using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Patients.Models;
using ProjectUSI.Manager.Model;

namespace ProjectUSI.Manager.Repository
{
    public class HospitalPoolsRepository
    {
        private List<HospitalQuery> _hospitalQueries;
        
        public HospitalPoolsRepository()
        {
            string json = File.ReadAllText(@"..\..\Data\hospitalQueries.json");
            List<HospitalQuery> hospitalQueries = JsonConvert.DeserializeObject<List<HospitalQuery>>(json);
            _hospitalQueries = hospitalQueries;
        }

        public List<HospitalQuery> GetPools()
        {
            return _hospitalQueries;
        }
        public void Save()
        {
            File.WriteAllText(@"..\..\Data\hospitalQueries.json", JsonConvert.SerializeObject(_hospitalQueries));
        }
    }
}