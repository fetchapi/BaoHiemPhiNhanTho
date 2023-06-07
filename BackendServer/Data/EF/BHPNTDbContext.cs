using BaoHiemPhiNhanTho.BackendServer.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendServer.Data.EF;

public class BHPNTDbContext : DbContext
{
    public BHPNTDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AnnexContract>().HasKey(ac => ac.HDPL);
        modelBuilder.Entity<Branch>().HasKey(ac => ac.BranchCode);
        modelBuilder.Entity<Collateral>().HasKey(ac => ac.Ref);
        modelBuilder.Entity<Customer>().HasKey(ac => ac.Cif);
        modelBuilder.Entity<InfoCBNV>().HasKey(ac => ac.TVTTCode);
        modelBuilder.Entity<InsuranceContract>().HasKey(ac => ac.HDBH);
        modelBuilder.Entity<Partner>().HasKey(ac => ac.PartnerCode);
        modelBuilder.Entity<InfoCBNV>()
        .HasMany(i => i.AnnexContracts)
        .WithOne(ac => ac.InfoCBNV)
        .HasForeignKey(ac => ac.TVTTCode);
    }

    public DbSet<AnnexContract> AnnexContracts { get; set; }
    public DbSet<Branch> Branches { get; set; }
    public DbSet<Collateral> Collaterals { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<InfoCBNV> InfoCBNVs { get; set; }
    public DbSet<InsuranceContract> InsuranceContracts { get; set; }
    public DbSet<Partner> Partners { get; set; }
    public DbSet<PaymentPeriod> PaymentPeriods { get; set; }
}