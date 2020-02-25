using System.Collections.Generic;

namespace Quiz.Models
{
    public class Question
    {
        public Question(string text, List<AnswerOption> answerOptions)
        {
            Text = text;
            AnswerOptions = answerOptions;
        }

        public string Text { get; set; }
        public List<AnswerOption> AnswerOptions; 
    }
}