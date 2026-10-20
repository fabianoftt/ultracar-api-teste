using Microsoft.EntityFrameworkCore;
using Ultracar.Domain.Entities;

namespace Ultracar.Infrastructure.InfraBancoDados
{
    public class AppDbContext : DbContext
    {
        public DbSet<Peca> Pecas { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
