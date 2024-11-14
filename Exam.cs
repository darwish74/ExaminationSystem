using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class Exam
    {
        public List<Question> Questions { get; set; } = new List<Question>();
        public string Level { get; set; }
        public int Duration { get; set; }

        public int TotalMarks => Questions.Sum(q => q.Marks);

        public void AddQuestion(Question question)
        {
            Questions.Add(question);
        }
    }
}
