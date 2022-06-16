using System;
using System.Collections.Generic;
using ProjectUSI.Manager.Model;
using ProjectUSI.Manager.Repository;
using ProjectUSI.Manager.View;

namespace ProjectUSI.Manager.Controller
{
    public class RequestController
    {
        private RequestRepository _requestRepository;

        public RequestController(RequestRepository requestRepository)
        {
            this._requestRepository = requestRepository;
        }

        public void AddRequest(string name, string wayOfUse, string ingeredientsString, string reason)
        {
            List<string> ingredients = GetIngredientsFromString(ingeredientsString);
            Request request = new Request(name, ingredients, wayOfUse, Status.OnHold, reason);
            _requestRepository.AddRequest(request);
        }

        public void DeleteRequest(Request request)
        {
            _requestRepository.DeleteRequest(request);
        }

        public List<string> GetIngredientsFromString(string ingredientsString)
        {
            List<string> ingredients = new List<string>();
            string[] ingredient = ingredientsString.Split(',');
            foreach (var word in ingredient)
            {
                ingredients.Add(word);
            }

            return ingredients;
        }
    }
}