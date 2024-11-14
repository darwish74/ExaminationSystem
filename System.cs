using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class System
    {
        private Exam exam = new Exam();
        private Teacher teacher = new Teacher();
        private Student student = new Student();

        public void Start()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("Welcome to the University Examination System");
                Console.WriteLine("Select mode: Teacher or Student (or type 'exit' to quit)");
                string mode = Console.ReadLine().Trim().ToLower();

                switch (mode)
                {
                    case "teacher":
                        teacher.SetUpExam(exam);
                        break;

                    case "student":
                        if (exam.Questions.Count == 0)
                        {
                            Console.WriteLine("No questions available. Please contact the teacher.");
                        }
                        else
                        {
                            student.TakeExam(exam);
                        }
                        break;

                    case "exit":
                        running = false;
                        Console.WriteLine("Exiting the examination system.");
                        break;

                    default:
                        Console.WriteLine("Invalid mode selected.");
                        break;
                }
            }
        }
    }
}
