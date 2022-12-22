
using BugTracker.Data;
using BugTracker.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BugTracker.Pages;

public class IndexModel : PageModel
{
    private readonly BugTrackerDbContext _context;

    public IndexModel(BugTrackerDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Bug> Bugs { get; set; } = Enumerable.Empty<Bug>();

    public async Task OnGet()
    {
        Bugs = await _context.Bugs.Where(b => b.Status != Status.Closed).ToListAsync();
    }
}