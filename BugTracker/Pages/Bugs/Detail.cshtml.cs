using BugTracker.Data;
using BugTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BugTracker.Pages.Bugs;

public class DetailModel : PageModel
{
    private readonly BugTrackerDbContext _context;

    public DetailModel(BugTrackerDbContext context)
    {
        _context = context;
    }

    public Bug? Bug { get; set; }
    public async Task OnGet(int id)
    {
        Bug = await _context.Bugs.FindAsync(id);
    }

    public async Task<IActionResult> OnPostDelete(int id)
    {
        var bug = await _context.Bugs.FindAsync(id);
            _context.Bugs.Remove(bug);
            await _context.SaveChangesAsync();

            return RedirectToPage("../Index");
        
    }
}
