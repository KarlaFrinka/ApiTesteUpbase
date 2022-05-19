using ApiTesteUpbase.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiTesteUpbase.Context
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options) => Database.EnsureCreated();

        public DbSet<Aluno> aluno { get; set; }
    }
}
