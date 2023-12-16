using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BlueBirdSnowboardingApp.Data;
using BlueBirdSnowboardingApp.models;

namespace BlueBirdSnowboardingApp.Pages.Marcas
{
    public class DetailsModel : PageModel
    {
        private readonly BlueBirdSnowboardingApp.Data.SnowboardingDbContext _context;

        public DetailsModel(BlueBirdSnowboardingApp.Data.SnowboardingDbContext context)
        {
            _context = context;
        }

      public Marca Marca { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Marca == null)
            {
                return NotFound();
            }

            var marca = await _context.Marca.FirstOrDefaultAsync(m => m.MarcaId == id);
            if (marca == null)
            {
                return NotFound();
            }
            else 
            {
                Marca = marca;
            }
            return Page();
        }
    }
}
