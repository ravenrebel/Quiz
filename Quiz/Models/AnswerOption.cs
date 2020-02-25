namespace Quiz.Models
{
    public class AnswerOption
    {
        public AnswerOption(string text, bool isCorrect)
        {
            Text = text;
            IsCorrect = isCorrect;
        }

        public string Text { get; set; }
        public bool IsCorrect { get; set; }
    }
}