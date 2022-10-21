using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace TreatFlavor.Models
{
  public class TreatFlavorContextFactory : IDesignTimeDbContextFactory<TreatFlavorContext>
  {

    TreatFlavorContext IDesignTimeDbContextFactory<TreatFlavorContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<TreatFlavorContext>();

      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

      return new TreatFlavorContext(builder.Options);
    }
  }
}