using BugTracker.Data;
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
    public void OnGet()
    {
    }
}
