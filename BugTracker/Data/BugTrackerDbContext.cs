using BugTracker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BugTracker.Data;

public class BugTrackerDbContext : DbContext
{
    public BugTrackerDbContext(DbContextOptions options) : base(options)
    { }

    public DbSet<Bug> Bugs { get; set; }
}
