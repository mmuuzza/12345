namespace YourProjectNamespace.Models
{
    public class Answer : BaseClass
    {
        public string AnswerText { get; set; }
        public bool IsCorrect { get; set; }
        public Question Question { get; set; }

        public Answer(string answerText, bool isCorrect) : base()
        {
            AnswerText = answerText;
            IsCorrect = isCorrect;
        }
    }
}