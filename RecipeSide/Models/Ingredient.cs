using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeSide.Models
{
    public class Ingredient
    {
        public string NameID { get; set; }
        public int Amount { get; set; }
        public enum Unit
        {
            g = 0,
            kg = 1,
            dl = 2,
            tsk = 3
        };
    }
}
