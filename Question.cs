using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    //Represents each question,
    //including its text, type, marks, and the correct answer.
    //It also has a method to check if a student's answer is correct.
    public enum QuestionType
    {
        TrueFalse,
        MultipleChoice,
        Essay
    }
    public class Question
    {
        public string Text { get; set; }
        public QuestionType Type { get; set; }
        public int Marks { get; set; }
        public string Answer { get; set; }
        public List<string> Choices { get; set; }

        public Question(string text, QuestionType type, int marks, string answer)
        {
            Text = text;
            Type = type;
            Marks = marks;
            Answer = answer;
            Choices = new List<string>();
        }

        public bool CheckAnswer(string studentAnswer)
        {
            return studentAnswer.Trim().ToLower() == Answer.Trim().ToLower();
        }

        public void DisplayQuestion()
        {
            Console.WriteLine($"Question: {Text}");

            if (Type == QuestionType.MultipleChoice && Choices.Count > 0)
            {
                for (int i = 0; i < Choices.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {Choices[i]}");
                }
            }
        }
    }
}
