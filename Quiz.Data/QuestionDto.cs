namespace Quiz.Data
{
    public class QuestionDto
    {
        public string? Id { get; set; }
        public int Category { get; set; }
        public string? Content { get; set; }
        public List<AnswerDto> Answers { get; set; } = [];
    }
}
