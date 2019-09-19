using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecipeSide.Models;

namespace RecipeSide.Pages.Ingredients
{
    public class IndexModel : PageModel
    {
        private readonly RecipeSide.Models.RecipeSideContext _context;

        public IndexModel(RecipeSide.Models.RecipeSideContext context)
        {
            _context = context;
        }

        public IList<Ingredient> Ingredient { get;set; }

        public async Task OnGetAsync()
        {
            Ingredient = await _context.Ingredient.ToListAsync();
        }
    }
}
