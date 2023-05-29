using Azure.Core;

namespace StudentSystem.Data.Model
{
	public class Resource
	{
		public int ResourceId { get; set; }
		public string Name { get; set; } = null!;
		public string Url { get; set; } = null!;
		public ResourceTypes ResourceType { get; set; }


		public enum ResourceTypes
		{
			Video,
			Document,
			Audio,
			Presentation
		}
	}
}
