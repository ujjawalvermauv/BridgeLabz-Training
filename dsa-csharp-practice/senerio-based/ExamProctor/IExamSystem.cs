namespace ExamProctor
{
    interface IExamSystem
    {
        void VisitQuestion(int questionId);
        void SubmitAnswer(int questionId, string answer);
        int CalculateScore();
        void ShowLastVisitedQuestion();
    }
}
