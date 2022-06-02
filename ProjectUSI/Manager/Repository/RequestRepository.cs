using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using ProjectUSI.Doctor.Model;
using ProjectUSI.Manager.Model;

namespace ProjectUSI.Manager.Repository
{
    public class RequestRepository
    {
        private List<Request> requests;
        
        public RequestRepository()
        {
            string json = File.ReadAllText(@"..\..\Data\MedicineRequests.json");
            List<Request> request = JsonConvert.DeserializeObject<List<Request>>(json);
            requests = request;
        }
        public List<Request> GetRequests()
        {
            return this.requests;
        }
    }
}