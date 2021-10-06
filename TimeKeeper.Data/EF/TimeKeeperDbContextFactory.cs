using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TimeKeeper.Data.EF
{
    public class TimeKeeperDbContextFactory : IDesignTimeDbContextFactory<TimeKeeperDbContext>
    {
        public TimeKeeperDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("TimeKeeperDb");

            var optionsBuilder = new DbContextOptionsBuilder<TimeKeeperDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new TimeKeeperDbContext(optionsBuilder.Options);
        }
    }
}
