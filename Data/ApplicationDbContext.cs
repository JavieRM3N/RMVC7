using ResidenciaMVC.Data.Configurations.Entities;
using Microsoft.EntityFrameworkCore;
using ResidenciaMVC.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;



namespace ResidenciaMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext<Empleado>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in base.ChangeTracker.Entries<BaseEntity>().Where(q => q.State == EntityState.Added || q.State == EntityState.Modified))
            {
                entry.Entity.DateModified = DateTime.Now;

                if (entry.State == EntityState.Added)
                {
                    entry.Entity.DateCreated = DateTime.Now;
                }
            }   

            return base.SaveChangesAsync(cancellationToken);
        }

        public DbSet<TipoEntrada> TipoEntradas { get; set; }
        public DbSet<AsignarEntrada> AsignarEntradas { get; set; }
        public DbSet<SolicitarEntrada> SolicitarEntradas{ get; set; }
    }
}
