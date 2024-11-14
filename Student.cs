using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class Student
    {
        public void TakeExam(Exam exam)
        {
            Console.WriteLine($"Exam Level: {exam.Level}");
            Console.WriteLine($"Number of Questions: {exam.Questions.Count}");
            Console.WriteLine($"Duration: {exam.Duration} minutes");
            Console.WriteLine("Are you ready to start the exam? (yes/no)");

            if (Console.ReadLine().Trim().ToLower() != "yes")
            {
                Console.WriteLine("Exiting the exam.");
                return;
            }

            int score = 0;

            foreach (var question in exam.Questions)
            {
                question.DisplayQuestion();
                Console.Write("Your Answer: ");
                string studentAnswer;

                if (question.Type == QuestionType.MultipleChoice && question.Choices.Count > 0)
                {
                    int answerIndex = int.Parse(Console.ReadLine()) - 1;
                    studentAnswer = question.Choices[answerIndex];
                }
                else
                {
                    studentAnswer = Console.ReadLine();
                }

                if (question.CheckAnswer(studentAnswer))
                {
                    score += question.Marks;
                }
            }

            Console.WriteLine($"Your total score: {score}/{exam.TotalMarks}");
            Console.WriteLine(score >= exam.TotalMarks * 0.6 ? "Passed" : "Failed");
        }

    }
}
