using YourProjectNamespace.Models;
using System.Collections.Generic;
using System.Linq;

namespace YourProjectNamespace.Services
{
    public static class QuestionService
    {
        private static List<Question> questions = new List<Question>();

        public static void AddQuestion(Question question)
        {
            questions.Add(question);
        }

        public static Question? GetQuestionById(int questionId)
        {
            return questions.FirstOrDefault(q => q.Id == questionId);
        }

        public static List<Question> GetQuestions()
        {
            return questions;
        }
    }
}