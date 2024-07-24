using Microsoft.EntityFrameworkCore;
using Picky.Application.Interfaces;
using Picky.Domain.Models;
using Picky.Persistence.EntityTypeConfigurations;

namespace Picky.Persistence
{
	public sealed class PickyDbContext : DbContext, IPickyDbContext
	{
        public DbSet<Picture> Pictures { get; set; }

        public PickyDbContext(DbContextOptions<PickyDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PickyConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}

