using BugTracker.Data;
using BugTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BugTracker.Pages.Bugs;

public class EditModel : PageModel
{
    private readonly BugTrackerDbContext _context;

    public EditModel(BugTrackerDbContext context)
    {
        _context = context;
    }

    public async Task OnGet(int id)
    {
        Bug = await _context.Bugs.FindAsync(id);
    }

    public async Task<IActionResult> OnPost()
    {
        if (!ModelState.IsValid) return Page();

        _context.Attach(Bug).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return RedirectToPage("../Index");
    }

    [BindProperty]
    public Bug Bug { get; set; }

}
