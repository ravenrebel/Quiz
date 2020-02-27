using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Quiz.Models;

namespace Quiz.Controllers
{
    public class QuestionsController : Controller
    {
        // GET
        public IActionResult Index()
        {
            Models.Quiz quiz = new Models.Quiz( "Are you a cat?",
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
            new Question("When are you more affective?", new List<AnswerOption>
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

            return View(quiz);
        }
    }
}