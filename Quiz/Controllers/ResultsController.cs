
using System.Web;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Quiz.Models;
using Microsoft.Extensions.Localization;
using System.Globalization;

namespace Quiz.Controllers
{
    public class ResultsController : Controller
    {
        private readonly IStringLocalizer<ResultsController> _localizer;
        private string _english = "en-US";
        private string _ukr = "uk";
        private string lang = "en-US";

        public ResultsController(IStringLocalizer<ResultsController> localizer)
        {
            _localizer = localizer;
        }

        // GET
        public IActionResult Index(int answer, int count)
        {
            var cookie = Request.Cookies["Lang"];
            if (cookie != null) lang = cookie;
            else lang = _english;
            CultureInfo.CurrentUICulture = new CultureInfo(lang);

            Result result = new Result();
            if (answer / (double) count > 0.5)
            {
                result.Image = "/Images/09a8def73311d379154b9bf6aaa5f6d8.jpg";
                if (CultureInfo.CurrentUICulture.Name.Equals(_english))
                    result.Text = "You are a cat!";
                else result.Text = "Ти кісьо!";
            }
            else
            {
                result.Image = "/Images/535-1000x830.jpg";
                if (CultureInfo.CurrentUICulture.Name.Equals(_english))
                    result.Text = "Sorry, but you are not a cat!";
                else result.Text = "Сорі, але ти не кісь!";
            }
            return View(result);
        }
        
    }
}