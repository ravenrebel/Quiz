
using Microsoft.AspNetCore.Mvc;
using Quiz.Models;


namespace Quiz.Controllers
{
    public class ResultsController : Controller
    {
        // GET
        public IActionResult Index(int answer, int count)
        {

            Result result = new Result();
            if (answer / (double) count > 0.5)
            {
                result.Image = "/images/tenor.gif";
                result.Text = "You are a cat!";
            }
            else
            {
                result.Image = "/images/535-1000x830.jpg";
                result.Text = "Sorry, but you are not a cat!";
            }
            return View(result);
        }
        
    }
}