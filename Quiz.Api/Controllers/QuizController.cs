using Microsoft.AspNetCore.Mvc;
using Quiz.Api.Services;

namespace Quiz.Api.Controllers
{
	[ApiController]
	public class QuizController : ControllerBase
	{
        private readonly IQuizService _service;

        public QuizController(IQuizService service)
		{
            _service = service;
        }

        // pobieranie pytania z danej kategorii
        // url: https://localhost:7000/getquestion
        [HttpGet]
		[Route("getquestion")]
        public async Task<IActionResult> GetQuestion(int category)
        { 
            var result = await _service.GetQuestion(category);
            return result != null ? Ok(result) : BadRequest("Nieprawid³owa kategoria");
        }



        // sprawdzanie czy odpowiedz o danym: answerId jest prawid³owa oraz nastepn¹ kategoriê
        // url: https://localhost:7000/checkanswer
        [HttpGet]
        [Route("checkanswer")]
        public async Task<IActionResult> CheckAnswer(string answerId, int category)
        {
            var result = await _service.CheckAnswer(answerId, category);
            return Ok(result);
        }


    }
}
