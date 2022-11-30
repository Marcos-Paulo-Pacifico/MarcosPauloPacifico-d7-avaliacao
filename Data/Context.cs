using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MarcosPauloPacifico_d7_avaliacao.Data;

public class Context: DbContext
{
    public Context(DbContextOptions<Context> options) : base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(GetUser());
        base.OnModelCreating(modelBuilder);
    }

    private static User GetUser()
    {
        return new User
        {
            UserId = Guid.NewGuid(),
            Email = "admin@email.com",
            Password = "admin123"
        };
    }
}
