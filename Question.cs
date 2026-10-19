namespace GitHubQuiz;

/// <summary>Вопрос викторины: текст, варианты ответа и номер правильного варианта (считая с 1).</summary>
public record Question(string Text, string[] Options, int Correct);
