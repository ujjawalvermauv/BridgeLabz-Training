using System;
using System.Collections.Generic;

namespace ExamProctor
{
    class ExamUtility : IExamSystem
    {
        // Stack for navigation
        private Stack<int> navigationStack = new Stack<int>();

        // Dictionary for answers (HashMap)
        private Dictionary<int, string> answers = new Dictionary<int, string>();

        // Correct answers (mock data)
        private Dictionary<int, string> correctAnswers = new Dictionary<int, string>()
        {
            {1, "A"},
            {2, "B"},
            {3, "C"},
            {4, "D"}
        };

        public void VisitQuestion(int questionId)
        {
            navigationStack.Push(questionId);
            Console.WriteLine("Visited Question: " + questionId);
        }

        public void SubmitAnswer(int questionId, string answer)
        {
            answers[questionId] = answer.ToUpper();
            Console.WriteLine("Answer saved successfully.");
        }

        public void ShowLastVisitedQuestion()
        {
            if (navigationStack.Count == 0)
            {
                Console.WriteLine("No question visited yet.");
                return;
            }

            Console.WriteLine("Last Visited Question: " + navigationStack.Peek());
        }

        public int CalculateScore()
        {
            int score = 0;

            foreach (var q in correctAnswers)
            {
                if (answers.ContainsKey(q.Key) &&
                    answers[q.Key] == q.Value)
                {
                    score++;
                }
            }
            return score;
        }
    }
}
