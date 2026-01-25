namespace AlgorithmApp.Data
{
	public class Question
	{
		public int Id { get; set; }
		public string Text { get; set; } = "";
		public string CodeSnippet { get; set; } 
		public List<string> Options { get; set; } = new();
		public string CorrectAnswer { get; set; } = "";
	}

	public class LanguageData
	{
		public string LanguageName { get; set; } = "";
		public List<Question> Questions { get; set; } = new();
	}
}
