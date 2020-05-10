using System.Collections.Generic;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Quiz.Models;

namespace Quiz.Controllers
{
    public class QuestionsController : Controller
    {
        private readonly IStringLocalizer<QuestionsController> _localizer;
        private string _english = "en-US";
        private string _ukr = "uk";

        public QuestionsController(IStringLocalizer<QuestionsController> localizer)
        {
            _localizer = localizer;
        }

        // GET
        public IActionResult Index(string lang)
        {
           
            if (lang != null) 
            { 
                CultureInfo.CurrentUICulture = new CultureInfo(lang);
                Response.Cookies.Append("Lang", lang);
            }
            else
            {
                var cookie = Request.Cookies["Lang"];
                if (cookie != null) lang = cookie;
                else lang = _english;
                CultureInfo.CurrentUICulture = new CultureInfo(lang);
            }

            ViewData["Title"] = _localizer["Title"];
            ViewData["Lang"] = _localizer["Lang"];
            Models.Quiz quiz = new Models.Quiz("", new List<Question>());

            if (CultureInfo.CurrentUICulture.Name.Equals(_english))
            {
                 quiz= new Models.Quiz("Are you a cat?",
                    new List<Question>  {
            new Question("Do you like fish?", new List<AnswerOption>
            {
                new AnswerOption("Yeah", true), new AnswerOption("No",false)
            }),
            new Question("And what about sushi?", new List<AnswerOption>
            {
                new AnswerOption("I like it", true), new AnswerOption("Nope", false)
            }),
            new Question("Are you a dog person or a cat person?", new List<AnswerOption>
            {
                new AnswerOption("Dogs forever!", false), new AnswerOption("Cats one love", true)
            }),
            new Question("How much time you spend sleeping?", new List<AnswerOption>
            {
                new AnswerOption("8 hours per day", false),
                new AnswerOption("10-12 hours per day or even more!", true),
                new AnswerOption("less than 8 hours", false),
                new AnswerOption("I never sleep", false)
            }),
            new Question("When are you more effective?", new List<AnswerOption>
            {
                new AnswerOption("During the day", false),
                new AnswerOption("At night", true)
            }),
            new Question("Describe yourself:", new List<AnswerOption>
            {
                new AnswerOption("strong and dangerous", false),
                new AnswerOption("smart and pretty", false),
                new AnswerOption("very cute and playful", false),
                new AnswerOption("I'm awesome!", true)
            }),
            new Question("Are you lazy?", new List<AnswerOption>
            {
                new AnswerOption("Yes", true),
                new AnswerOption("I's not about me", false),
                new AnswerOption("Sometimes", false),
            }),
            new Question("Do you have a sweet tooth?", new List<AnswerOption>
            {
                new AnswerOption("Not really", false),
                new AnswerOption("Where is my chocolate?", true),
            }),
            new Question("Cold weather or hot one?", new List<AnswerOption>
            {
                new AnswerOption("Always waiting for hot summer days", true),
                new AnswerOption("I like the cold", false),
                new AnswerOption("Never mind", false),
            }),
            new Question("Really want to be a cat?", new List<AnswerOption>
            {
                new AnswerOption("It's my dream", false),
                new AnswerOption("Not for me", false),
                new AnswerOption("I'm a cat", true),
            })
            });
            }
            else
            {
                quiz = new Models.Quiz("Чи ти кісьо?",
                 new List<Question>  {
            new Question("Любиш рибу?", new List<AnswerOption>
            {
                new AnswerOption("Тя", true), new AnswerOption("Неа",false)
            }),
            new Question("А суші любиш?", new List<AnswerOption>
            {
                new AnswerOption("Люблю", true), new AnswerOption("Ні", false)
            }),
            new Question("Котики чи песики?", new List<AnswerOption>
            {
                new AnswerOption("Песики назавжди!", false), new AnswerOption("Кісьо ван лав", true)
            }),
            new Question("Скільки часу ти спиш?", new List<AnswerOption>
            {
                new AnswerOption("8 год на день", false),
                new AnswerOption("10-12 год на день або більше!", true),
                new AnswerOption("менше 8 год на день", false),
                new AnswerOption("Я ніколи не сплю", false)
            }),
            new Question("Коли ти найбільш ефективний?", new List<AnswerOption>
            {
                new AnswerOption("Вдень", false),
                new AnswerOption("Вночі", true)
            }),
            new Question("Опиши себе:", new List<AnswerOption>
            {
                new AnswerOption("сильний та небезпечний", false),
                new AnswerOption("розумний красавчік", false),
                new AnswerOption("грайлива няшка", false),
                new AnswerOption("Я надзвичайний!", true)
            }),
            new Question("Ти лінивий?", new List<AnswerOption>
            {
                new AnswerOption("Тя", true),
                new AnswerOption("Це не про мене", false),
                new AnswerOption("Інколи", false),
            }),
            new Question("Любиш солодощі?", new List<AnswerOption>
            {
                new AnswerOption("Не сказав би", false),
                new AnswerOption("Де мій шоколад?", true),
            }),
            new Question("Холодна чи жарка погода?", new List<AnswerOption>
            {
                new AnswerOption("Завжди чекаю теплих літніх днів", true),
                new AnswerOption("Люблю холод", false),
                new AnswerOption("Байдуже", false),
            }),
            new Question("Справді хочеш бути кісьом?", new List<AnswerOption>
            {
                new AnswerOption("Це моя мрія", false),
                new AnswerOption("Не для мене", false),
                new AnswerOption("Я кісь", true),
            })
         });
         }

            return View(quiz);
        }


    }
}