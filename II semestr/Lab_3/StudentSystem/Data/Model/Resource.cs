using Azure.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentSystem.Data.Model
{
	public class Resource
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ResourceId { get; set; }
		public string Name { get; set; } = null!;
		public string Url { get; set; } = null!;
		public ResourceTypes ResourceType { get; set; }


		//connections
		public int CourseId { get; set; }
		public Course Course { get; set; }


		//enum
		public enum ResourceTypes
		{
			Video,
			Document,
			Audio,
			Presentation
		}
	}
}
