using System;

namespace ExamProctor
{
    class ExamMenu
    {
        public static void Start()
        {
            ExamUtility exam = new ExamUtility();
            int choice;

            do
            {
                Console.WriteLine("\n===== Online Exam Menu =====");
                Console.WriteLine("1. Visit Question");
                Console.WriteLine("2. Submit Answer");
                Console.WriteLine("3. Show Last Visited Question");
                Console.WriteLine("4. Submit Exam & Calculate Score");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Question ID: ");
                        int qid = int.Parse(Console.ReadLine());
                        exam.VisitQuestion(qid);
                        break;

                    case 2:
                        Console.Write("Enter Question ID: ");
                        int aqid = int.Parse(Console.ReadLine());

                        Console.Write("Enter Answer (A/B/C/D): ");
                        string ans = Console.ReadLine();

                        exam.SubmitAnswer(aqid, ans);
                        break;

                    case 3:
                        exam.ShowLastVisitedQuestion();
                        break;

                    case 4:
                        int score = exam.CalculateScore();
                        Console.WriteLine("Final Score: " + score);
                        break;

                    case 5:
                        Console.WriteLine("Exiting Exam System...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 5);
        }
    }
}
