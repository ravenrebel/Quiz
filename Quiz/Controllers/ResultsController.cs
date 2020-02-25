
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
                result.Image = "~/Images/tenor.gif";
                result.Text = "You are a cat!";
            }
            else
            {
                result.Image = "~/Images/535-1000x830.jpg";
                result.Text = "Sorry, but you are not a cat!";
            }
            return View(result);
        }
        
        public FileResult GetImage()
        {
            var bytes = System.IO.File.ReadAllBytes("~/Images/535-1000x830.jpg");
            return File(bytes, "image/jpg");
        }
    }
}