using System;
using System.Collections.Generic;

namespace ProjectUSI.Medicine.Model
{
    public class Request
    {
        public Request()
        {
            Name = "";
            Ingredients = new List<String>();
            WayOfUse = "";
            Status = Status;
            Reason = "";
        }

        public Request(string name, List<String> ingredients, string wayOfUse, Status status, string reason)
        {
            Name = name;
            Ingredients = ingredients;
            WayOfUse = wayOfUse;
            Status = status;
            Reason = reason;
        }
        public string Name { get; set; }
        public List<String> Ingredients { get; set; }
        public string WayOfUse { get; set; }
        public Status Status { get; set; }
        public string Reason { get; set; }
        
        private String IngredientsToString()
        {
            String ingredients = "";
            foreach (String ingredient in Ingredients)
            {
                ingredients += ingredient + " ";
            }

            return ingredients;
        }
        public override string ToString()
        {
            return Name + "\t" + IngredientsToString() + "\t" + WayOfUse + "\t" + Status + "\t" + Reason;
        }
    }

    public enum Status
    {
        OnHold,
        Rejected
    }
}