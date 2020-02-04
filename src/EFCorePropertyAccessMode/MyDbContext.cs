using EFCorePropertyAccessMode.Model;
using Microsoft.EntityFrameworkCore;

namespace EFCorePropertyAccessMode
{
  public class MyDbContext : DbContext
  {
    public MyDbContext()
    {
    }

    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
    {
    }

    public DbSet<MyEntity> MyEntities { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(
        "Server=(localdb)\\mssqllocaldb;Database=EFCorePropertyAccessMode;Trusted_Connection=True;MultipleActiveResultSets=true");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<MyEntity>(builder =>
      {
        builder.HasKey(myEntity => new {myEntity.KeyField1, myEntity.KeyField2});
        builder.OwnsOne(myEntity => myEntity.MyOwnedEntity);
      });
    }
  }
}