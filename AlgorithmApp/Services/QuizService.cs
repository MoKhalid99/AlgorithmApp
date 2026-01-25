using System.Text.Json;
using AlgorithmApp.Data;

namespace AlgorithmApp.Services;

public class QuizService
{
	private readonly IWebHostEnvironment _env;
	public QuizService(IWebHostEnvironment env) => _env = env;

	public async Task<List<Question>> GetRandomQuestionsAsync(string lang)
	{
		var path = Path.Combine(_env.WebRootPath, "questions.json");
		if (!File.Exists(path)) return new();

		var json = await File.ReadAllTextAsync(path);
		var allData = JsonSerializer.Deserialize<List<LanguageData>>(json);
		var langData = allData?.FirstOrDefault(l => l.LanguageName.Equals(lang, StringComparison.OrdinalIgnoreCase));

		return langData?.Questions.OrderBy(_ => Guid.NewGuid()).Take(5).ToList() ?? new();
	}
}