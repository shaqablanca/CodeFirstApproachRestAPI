using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using EF7CodeFirst.Models;


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
            optionsBuilder.UseNpgsql();
            //optionsBuilder.UseNpgsql("Host=localhost ; Port=5432; Database= postgres; Username= softsamed; Password= 123AsD987; Integrated Security = true");
        }

        public DbSet<Vehicle> Vehicles { get; set; }

    }

 
}