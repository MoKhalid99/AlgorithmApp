using System.ComponentModel.DataAnnotations;

namespace Algorithm.Models
{
	public class QuestionItem
	{
		public int Id { get; set; }

		[Required]
		public string Language { get; set; } = string.Empty; // e.g., "C#"

		[Required]
		public string QuestionText { get; set; } = string.Empty;

		public string OptionA { get; set; } = string.Empty;
		public string OptionB { get; set; } = string.Empty;
		public string OptionC { get; set; } = string.Empty;
		public string OptionD { get; set; } = string.Empty;

		[Required]
		public string CorrectAnswer { get; set; } = string.Empty; // "A", "B", "C", or "D"
	}
}
