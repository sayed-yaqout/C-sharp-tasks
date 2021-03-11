using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_System
{
    class Exam
    {
        public TimeSpan Time { get; set; }
        public Dictionary<Questions,Answer> MyExam { get; set; }
        public virtual void Show()
        {

        }
        public Exam()
        {
            MyExam = new Dictionary<Questions, Answer>();
        }
    }
    class Practice:Exam
    {
        public override void Show()
        {
            foreach (var item in MyExam)
            {
                Console.WriteLine($"{item.Key}, Ans: {item.Value.Ans}");
            }
        }
    }
    class Final : Exam
    {
        public override void Show()
        {
            foreach (var item in MyExam)
            {
                Console.WriteLine($"{item.Key}");
            }
        }
    }
}
