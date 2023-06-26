using System;
namespace EF7CodeFirst.Models
{
	public class Vehicle
	{
		public int Id { get; set; }

		public List<string>? VehicleType { get; set; } 

		public string Model { get; set; } = string.Empty;

		public string PurposeOfUsage { get; set; } = string.Empty;

		public string Brand { get; set; } = string.Empty;

		public string Company { get; set; } = string.Empty;

		public int CreationYear{ get; set; }

		public string Country { get; set; } = string.Empty;
    }
}