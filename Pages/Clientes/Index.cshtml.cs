using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RostrosFelices.Data;
using RostrosFelices.Models;

namespace RostrosFelices.Pages.Clientes
{
    [Authorize]
    public class IndexModel : PageModel
    {
        public readonly RostrosContext _context;

        public IndexModel(RostrosContext context)
        {
            _context = context;
        }

        public IList<Cliente> Clientes { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Clientes != null)
            {
                Clientes = await _context.Clientes.ToListAsync();
            }
        }
    }
}
