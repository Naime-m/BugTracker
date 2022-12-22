using BugTracker.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BugTracker.Pages.Bugs;

public class EditModel : PageModel
{
    private readonly BugTrackerDbContext _context;

    public EditModel(BugTrackerDbContext context)
        {
        _context = context;
    }

    public void OnGet()
    {
    }

}
