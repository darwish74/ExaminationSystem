using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class Teacher
    {
        public void SetUpExam(Exam exam)
        {
            Console.WriteLine("How many questions do you want to add?");
            int questionCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < questionCount; i++)
            {
                Console.WriteLine("Enter question type (1: True/False, 2: Multiple Choice, 3: Essay): ");
                QuestionType type = (QuestionType)(int.Parse(Console.ReadLine()) - 1);

                Console.WriteLine("Enter the question text:");
                string text = Console.ReadLine();

                Console.WriteLine("Enter marks for this question:");
                int marks = int.Parse(Console.ReadLine());

                Question question = new Question(text, type, marks, "");

                if (type == QuestionType.MultipleChoice)
                {
                    Console.WriteLine("Enter the number of choices for this question:");
                    int choiceCount = int.Parse(Console.ReadLine());

                    for (int j = 0; j < choiceCount; j++)
                    {
                        Console.WriteLine($"Enter choice {j + 1}:");
                        string choice = Console.ReadLine();
                        question.Choices.Add(choice);
                    }

                    Console.WriteLine("Enter the correct choice number:");
                    int correctChoiceNumber = int.Parse(Console.ReadLine());
                    question.Answer = question.Choices[correctChoiceNumber - 1];
                }
                else
                {
                    Console.WriteLine("Enter the correct answer:");
                    question.Answer = Console.ReadLine();
                }

                exam.AddQuestion(question);
            }
            Console.WriteLine("Enter the level of the exam:");
            exam.Level = Console.ReadLine();
            Console.WriteLine("Enter the duration of the exam (in minutes):");
            exam.Duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Exam setup is complete.");
        }

    }
}

