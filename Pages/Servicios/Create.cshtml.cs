using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RostrosFelices.Data;
using RostrosFelices.Models;

namespace RostrosFelices.Pages.Servicios
{
    public class CreateModel : PageModel
    {

        private readonly RostrosContext _context;

        public CreateModel(RostrosContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Servicio Servicio { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if ( _context.Servicios == null || Servicio == null)
            {
                return Page();
            }

            _context.Servicios.Add(Servicio);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
