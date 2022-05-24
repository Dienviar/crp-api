using crp_api.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NodaTime;

namespace crp_api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> USERS { get; set; }

        public DbSet<Report> REPORTS { get; set; }
        public DbSet<ReportLog> REPORTLOGS { get; set; }
        public DbSet<ReportStatus> REPORTSTATUSES { get; set; }
        public DbSet<ReportType> REPORTTYPES { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("crp");

            var instantConverter = new ValueConverter<Instant, DateTime>(i => i.ToDateTimeUtc(), it => Instant.FromDateTimeOffset(it));

            modelBuilder
                .Entity<User>()
                .Property(u => u.DATE_CREATED)
                .HasConversion(instantConverter);
            modelBuilder
                .Entity<User>()
                .Property(u => u.DATE_UPDATED)
                .HasConversion(instantConverter);

            modelBuilder
                .Entity<Report>()
                .Property(u => u.DATE_CREATED)
                .HasConversion(instantConverter);
            modelBuilder
                .Entity<Report>()
                .Property(u => u.DATE_UPDATED)
                .HasConversion(instantConverter);

            modelBuilder
                .Entity<ReportLog>()
                .Property(u => u.DATE_CREATED)
                .HasConversion(instantConverter);
            modelBuilder
                .Entity<ReportLog>()
                .Property(u => u.DATE_UPDATED)
                .HasConversion(instantConverter);

            modelBuilder
                .Entity<ReportStatus>()
                .Property(u => u.DATE_CREATED)
                .HasConversion(instantConverter);
            modelBuilder
                .Entity<ReportStatus>()
                .Property(u => u.DATE_UPDATED)
                .HasConversion(instantConverter);

            modelBuilder
                .Entity<ReportType>()
                .Property(u => u.DATE_CREATED)
                .HasConversion(instantConverter);
            modelBuilder
                .Entity<ReportType>()
                .Property(u => u.DATE_UPDATED)
                .HasConversion(instantConverter);

            modelBuilder
                .Entity<crp_apiRole>()
                .Property(u => u.DATE_CREATED)
                .HasConversion(instantConverter);
            modelBuilder
                .Entity<crp_apiRole>()
                .Property(u => u.DATE_UPDATED)
                .HasConversion(instantConverter);

            modelBuilder
                .Entity<Proof>()
                .Property(u => u.DATE_CREATED)
                .HasConversion(instantConverter);
            modelBuilder
                .Entity<Proof>()
                .Property(u => u.DATE_UPDATED)
                .HasConversion(instantConverter);

            modelBuilder
                .Entity<User>()
                .Property(u => u.USER_ID)
                .HasDefaultValueSql("newsequentialid()");
            modelBuilder
                .Entity<Report>()
                .Property(t => t.REPORT_ID)
                .HasDefaultValueSql("newsequentialid()");
            modelBuilder
                .Entity<ReportLog>()
                .Property(t => t.REPORTLOG_ID)
                .HasDefaultValueSql("newsequentialid()");
            modelBuilder
                .Entity<ReportStatus>()
                .Property(t => t.REPORTSTATUS_ID)
                .HasDefaultValueSql("newsequentialid()");
            modelBuilder
                .Entity<ReportType>()
                .Property(t => t.REPORTTYPE_ID)
                .HasDefaultValueSql("newsequentialid()");
            modelBuilder
                .Entity<crp_apiRole>()
                .Property(t => t.ROLE_ID)
                .HasDefaultValueSql("newsequentialid()");
            modelBuilder
                .Entity<Proof>()
                .Property(t => t.PROOF_ID)
                .HasDefaultValueSql("newsequentialid()");

            modelBuilder
                .Entity<Report>()
                .HasOne(r => r.USER)
                .WithMany(r => r.REPORTS)
                .HasForeignKey(u => u.USER_ID);
            modelBuilder
                .Entity<Report>()
                .HasOne(r => r.USER)
                .WithMany(r => r.REPORTS)
                .OnDelete(DeleteBehavior.ClientNoAction);
            modelBuilder
                .Entity<Report>()
                .HasOne(r => r.REPORTTYPE)
                .WithMany(r => r.REPORTS)
                .HasForeignKey(r => r.REPORTTYPE_ID);
            modelBuilder
                .Entity<Report>()
                .HasOne(r => r.REPORTTYPE)
                .WithMany(r => r.REPORTS)
                .OnDelete(DeleteBehavior.ClientNoAction);
            modelBuilder
                .Entity<Report>()
                .HasOne(r => r.REPORTSTATUS)
                .WithMany(r => r.REPORTS)
                .HasForeignKey(r => r.REPORTSTATUS_ID);
            modelBuilder
                .Entity<Report>()
                .HasOne(r => r.REPORTSTATUS)
                .WithMany(r => r.REPORTS)
                .OnDelete(DeleteBehavior.ClientNoAction);

            modelBuilder
               .Entity<ReportLog>()
               .HasOne(r => r.REPORT)
               .WithMany(r => r.REPORTLOGS)
               .HasForeignKey(r => r.REPORT_ID);

            modelBuilder
               .Entity<Proof>()
               .HasOne(r => r.REPORT)
               .WithMany(r => r.UPLOADED_PROOFS)
               .HasForeignKey(r => r.REPORT_ID);

            modelBuilder
               .Entity<User>()
               .HasOne(r => r.ROLE)
               .WithMany(r => r.USERS)
               .HasForeignKey(r => r.ROLE_ID);


        }
        public Task<int> SaveSessionChangesAsync(CancellationToken cancellationToken = new(), Guid user = new())
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e =>
                    e.State == EntityState.Added
                    || e.State == EntityState.Modified);
            foreach (var entityEntry in entries)
            {
                entityEntry.Property("UPDATED_BY").CurrentValue = user;
                entityEntry.Property("DATE_UPDATED").CurrentValue = Instant.FromDateTimeUtc(DateTime.Now.ToUniversalTime());
                if (entityEntry.State == EntityState.Added)
                {
                    entityEntry.Property("CREATED_BY").CurrentValue = user;
                    entityEntry.Property("DATE_CREATED").CurrentValue = Instant.FromDateTimeUtc(DateTime.Now.ToUniversalTime());
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}