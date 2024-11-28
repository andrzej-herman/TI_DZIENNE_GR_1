using Quiz.Data;

namespace Quiz.Application.Endpoints
{
    public class Game : IGame
    {
        private readonly HttpClient _client;

        public Game(HttpClient client)
        {
            _client = client;
        }

        public async Task<CheckAnswerDto?> CheckAnswer(string answerId, int category)
        {
            return null;
        }

        public async Task<QuestionDto?> GetQuestion(int category)
        {
            var url = $"getQuestion?category={category}";
            var response = await _client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                return null;
            }
            else
                return null;

        }
    }
}
