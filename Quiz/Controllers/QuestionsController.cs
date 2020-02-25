using Microsoft.AspNetCore.Mvc;

namespace Quiz.Controllers
{
    public class QuestionsController : Controller
    {
        // GET
        public IActionResult Index()
        {
            Models.Quiz quiz = new Models.Quiz( "Are you a cat?");

            return View(quiz);
        }
    }
}