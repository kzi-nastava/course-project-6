using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ProjectUSI.Data
{
    public class Medicine
    {
        public Medicine()
        {
            Name = "";
            Ingredients = new Dictionary<string, double>();
        }

        public Medicine(string name, Dictionary<string, double> ingredients)
        {
            Name = name;
            Ingredients = ingredients;
        }

        public string Name { get; set; }
        public Dictionary<string, double> Ingredients { get; set; }
    }
}