using System;
namespace EF7CodeFirst.Models
{
	public class News
	{
	
		public int Id { get; set; }

		public string ChannelName { get; set; } = string.Empty;

		public int ChannelFrequencyNumber { get; set; }

		public int ChannelRatio { get; set; }

		public string? ChannelMediaOwner { get; set; }
	}
}

