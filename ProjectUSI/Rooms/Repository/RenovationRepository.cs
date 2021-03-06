using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using ProjectUSI.Rooms.Model;

namespace ProjectUSI.Rooms.Repository
{
    public class RenovationRepository
    {
        private List<Renovation> _renovation;

        public RenovationRepository()
        {
            string json = File.ReadAllText(@"..\..\Data\Renovation.json");
            List<Renovation> renovation = JsonConvert.DeserializeObject<List<Renovation>>(json);
            _renovation = renovation;
        }

        public void Add(Renovation renovation)
        {
            _renovation.Add(renovation);
            this.SetRenovation(_renovation);
        }

        
        public List<Renovation> GetRenovation()
        {
            return this._renovation;
        }
        public void SetRenovation(List<Renovation> renovation)
        {
            this._renovation = renovation;
        }


        public void Save()
        {
            File.WriteAllText(@"..\..\Data\Renovation.json", JsonConvert.SerializeObject(_renovation));
        }
    }
}