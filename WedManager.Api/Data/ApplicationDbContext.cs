using System;
using Microsoft.EntityFrameworkCore;
using WedManager.Api.Models;


namespace WedManager.Api.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Prestataire> Prestataires => Set<Prestataire>();
}
