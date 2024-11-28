using Quiz.Data;

namespace Quiz.Api.Services
{
    public interface IQuizService
    {
        Task<QuestionDto?> GetQuestion(int category);
        Task<CheckAnswerDto?> CheckAnswer(string answerId, int category);
    }
}
