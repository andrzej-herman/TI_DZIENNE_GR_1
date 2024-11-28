using Quiz.Data;

namespace Quiz.Application.Endpoints
{
    public interface IGame
    {
        Task<QuestionDto?> GetQuestion(int category);
        Task<CheckAnswerDto?> CheckAnswer(string answerId, int category);
    }
}
