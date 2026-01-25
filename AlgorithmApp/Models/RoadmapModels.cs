namespace AlgorithmApp.Models
{
	public class RoadmapModels
	{
		public record RoadmapCategory(string Id, string Title, string Description, string Icon);
		public record RoadmapPath(string Id, string Title, string Description, string CategoryId);
		public record RoadmapStep(string Title, string Description, string Type = "recommended"); // recommended, alternative, optional
	}
}
