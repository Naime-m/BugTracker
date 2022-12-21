using BugTracker.Data;
using BugTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BugTracker.Pages.Bugs
{
    public class CreateModel : PageModel
    {
        private readonly BugTrackerDbContext _context;

        public CreateModel(BugTrackerDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid) return Page();

            Bug.Date= DateTime.Now;
            await _context.Bugs.AddAsync(Bug);
            await _context.SaveChangesAsync();

            return RedirectToPage("../Index");
            
        }

        [BindProperty]
        public Bug Bug { get; set; }
    }
}
