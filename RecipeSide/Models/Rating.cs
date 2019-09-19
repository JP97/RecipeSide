using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeSide.Models
{
    public class Rating
    {
        [Range(1, 5)]
        public int Character { get; set; }
    }
}
