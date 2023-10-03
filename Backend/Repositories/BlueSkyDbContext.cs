using Microsoft.EntityFrameworkCore;

namespace Backend.Repositories;

public class BlueSkyDbContext:DbContext
{
    public BlueSkyDbContext(DbContextOptions<BlueSkyDbContext> options) : base(options)
    {
    }
}