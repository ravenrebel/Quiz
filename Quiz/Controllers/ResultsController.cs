
using System.Web;
using System.IO;
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
                result.Image = "/Images/09a8def73311d379154b9bf6aaa5f6d8.jpg";
                result.Text = "You are a cat!";
            }
            else
            {
                result.Image = "/Images/535-1000x830.jpg";
                result.Text = "Sorry, but you are not a cat!";
            }
            return View(result);
        }
        
    }
}