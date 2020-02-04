using System;
using EFCorePropertyAccessMode.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EFCorePropertyAccessMode
{
  class Program
  {
    private static void Main(string[] args)
    {
      var serviceProvider = new ServiceCollection()
        .AddDbContext<MyDbContext>(options =>
          options.UseSqlServer(
            "Server=(localdb)\\mssqllocaldb;Database=EFCorePropertyAccessMode;Trusted_Connection=True;MultipleActiveResultSets=true"))
        .BuildServiceProvider();

      var dbContext = serviceProvider.GetRequiredService<MyDbContext>();

      dbContext.Database.Migrate();

      var myEntity = new MyEntity(Guid.NewGuid(), "keyField2");
      // Next line of code fails with System.InvalidOperationException:
      // 'Unable to track an entity of type 'MyOwnedEntityType' because primary key property 'MyEntityKeyField2' is null.'
      dbContext.Add(myEntity);
    }
  }
}