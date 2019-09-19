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
    public class DeleteModel : PageModel
    {
        private readonly RecipeSide.Models.RecipeSideContext _context;

        public DeleteModel(RecipeSide.Models.RecipeSideContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Ingredient Ingredient { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Ingredient = await _context.Ingredient.FirstOrDefaultAsync(m => m.NameID == id);

            if (Ingredient == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Ingredient = await _context.Ingredient.FindAsync(id);

            if (Ingredient != null)
            {
                _context.Ingredient.Remove(Ingredient);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
