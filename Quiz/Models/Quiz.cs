using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Quiz.Models
{
    public class Quiz: IEnumerable<Question>
    {
        public Quiz(string title, List<Question> questions)
        {
            Title = title;
            Questions = questions;
        }
        
        public string Title { get; set; }

        public List<Question> Questions { get; set; }
        
        public IEnumerator<Question> GetEnumerator()
        {
            return Questions.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}