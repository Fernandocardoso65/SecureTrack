using Microsoft.EntityFrameworkCore;
using SecureTrack.Api.Models;

namespace SecureTrack.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Incident> Incidents => Set<Incident>();
}
