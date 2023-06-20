using System;
namespace EF7CodeFirst.Models
{
	public class User
	{
		public int Id { get; set; }

		public string? FirstName { get; set; }

		public string? LastName { get; set; }

		public int Balance { get; set; }

		public List<string>? Bussines { get; set; }	
		
	}
}