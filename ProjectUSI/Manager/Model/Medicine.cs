using System;
using System.Collections.Generic;

namespace ProjectUSI.Manager.Model
{
    public class Medicine
    {
        public Medicine()
        {
            Name = "";
            Ingredients = new List<String>();
            WayOfUse = "";
        }

        public Medicine(string name, List<String> ingredients, string wayOfUse)
        {
            Name = name;
            Ingredients = ingredients;
            WayOfUse = wayOfUse;
        }
        
        public string Name { get; set; }
        public List<String> Ingredients { get; set; }
        public string WayOfUse { get; set; }

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
            return Name + "\t" + IngredientsToString() + "\t" + WayOfUse;
        }
    }
}