namespace AlgorithmApp.Models
{
	public class QuizData
	{
		public Dictionary<string, Dictionary<string, List<string>>> NORMAL_QUESTIONS { get; set; }
		public Dictionary<string, List<string>> HARD_GAMEOVER_QUESTIONS { get; set; }
	}

	public class QuestionModel
	{
		public string QuestionText { get; set; }
		public List<string> Choices { get; set; }
		public string CorrectAnswer { get; set; }
	}

	public enum GameState { Start, Playing, Paused, Quiz, LevelUp, GameOver, RescueQuiz }
}
