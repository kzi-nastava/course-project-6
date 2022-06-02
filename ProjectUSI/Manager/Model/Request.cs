using System;
using System.Collections.Generic;

namespace ProjectUSI.Manager.Model
{
    public class Request
    {
        public Request()
        {
            Name = "";
            Ingredients = new List<String>();
            WayOfUse = "";
            Status = Status;
        }

        public Request(string name, List<String> ingredients, string wayOfUse, Status status)
        {
            Name = name;
            Ingredients = ingredients;
            WayOfUse = wayOfUse;
            Status = status;
        }
        public string Name { get; set; }
        public List<String> Ingredients { get; set; }
        public string WayOfUse { get; set; }
        public Status Status { get; set; }
        
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
            return Name + "\t" + IngredientsToString() + "\t" + WayOfUse + "\t" + Status;
        }
    }

    public enum Status
    {
        NaCekanju,
        Prihvacen,
        Odbijen
    }
}