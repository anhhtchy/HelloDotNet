using System;
using System.IO;
using HelloDotNet.Utilities.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace HelloDotNet.Data.EntityFramework
{
    public class EShopDbContextFactory : IDesignTimeDbContextFactory<EShopDbContext>
    {
        public EShopDbContextFactory()
        {
        }

        public EShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration
                .GetConnectionString(SystemConstants.DbName);
            var optionsBuilder = new DbContextOptionsBuilder<EShopDbContext>();
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            return new EShopDbContext(optionsBuilder.Options);
        }
    }
}
