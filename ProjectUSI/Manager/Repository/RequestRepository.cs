using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using ProjectUSI.Doctor.Model;
using ProjectUSI.Manager.Model;

namespace ProjectUSI.Manager.Repository
{
    public class RequestRepository
    {
        private List<Request> _requests;
        
        public RequestRepository()
        {
            string json = File.ReadAllText(@"..\..\Data\MedicineRequests.json");
            List<Request> request = JsonConvert.DeserializeObject<List<Request>>(json);
            _requests = request;
        }
        public List<Request> GetRequests()
        {
            return this._requests;
        }

        public void AddRequest(Request request)
        {
            this._requests.Add(request);
        }

        public void DeleteRequest(Request request)
        {
            this._requests.Add(request);
        }
        public void Save()
        {
            File.WriteAllText(@"..\..\Data\MedicineRequests.json", JsonConvert.SerializeObject(_requests));
        }
    }
}