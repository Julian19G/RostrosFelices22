using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RostrosFelices.Data;
using RostrosFelices.Models;

namespace RostrosFelices.Pages.Servicios
{
    public class DeleteModel : PageModel
    {
        private readonly RostrosContext _context;

        public DeleteModel(RostrosContext context)
        {
            _context = context;
        }

        [BindProperty]

        public Servicio Servicio { get; set; } = default!;
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Servicios == null)
            {
                return NotFound();
            }

            var servicio = await _context.Servicios.FirstOrDefaultAsync(m => m.Id == id);

            if (servicio == null)
            {
                return NotFound();
            }
            else
            {
                Servicio = servicio;
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Servicios == null)
            {
                return NotFound();
            }
            var servicio = await _context.Servicios.FindAsync(id);
            if (servicio != null)
            {
                Servicio = servicio;
                _context.Servicios.Remove(Servicio);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("./Index");
        }
    }
}
