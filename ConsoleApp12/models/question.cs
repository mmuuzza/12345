using System.Collections.Generic;

namespace YourProjectNamespace.Models
{
    public class Question : BaseClass
    {
        public string QuestionText { get; set; }
        public List<Answer> Answers { get; private set; }

        public Question(string questionText) : base()
        {
            QuestionText = questionText;
            Answers = new List<Answer>();
        }

        // Method to add an answer to the question
        public void AddAnswer(Answer answer)
        {
            answer.Question = this; // Set the reference to this question
            Answers.Add(answer);    // Add the answer to the list
        }
    }
}