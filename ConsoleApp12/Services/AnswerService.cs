using YourProjectNamespace.Models;
using System.Collections.Generic;
using System.Linq;

namespace YourProjectNamespace.Services
{
    public static class AnswerService
    {
        private static List<Answer> answers = new List<Answer>();

        public static void AddAnswer(Answer answer)
        {
            answers.Add(answer);
        }

        public static Answer? GetAnswerById(int answerId)
        {
            return answers.FirstOrDefault(a => a.Id == answerId);
        }

        public static List<Answer> GetAnswers()
        {
            return answers;
        }
    }
}