using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EF7CodeFirst.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext>options) :base(options)
		{

		}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("Host=localhost ; Port=5432; Database= postgres; Username= softsamed; Password= 123AsD987; Integrated Security = true");
            //optionsBuilder.UseNpgsql("Server:localhost ;User Id: softsamed; Password: 123AsD987;Database: postgres; Port:5432; Integrated Security = true");
        }

        public DbSet<WeatherForecast> Forecasts { get; set; }
    }

    public class MyDbContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            throw new NotImplementedException();
        }

        DataContext IDesignTimeDbContextFactory<DataContext>.CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<DataContext>();
            var connectionString = "Server:localhost ;User Id: softsamed; Password: 123AsD987;Database: postgres; Port:5432; Integrated Security = true";

            builder.UseNpgsql(connectionString);

            return new DataContext(builder.Options);
        }
    }
}