using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Examination_System
{
    abstract class Questions
    {
        public int Mark { get; set; }
        public string Body { get; set; }
        public choicesList Choices { get; set; }
       
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in Choices)
            {
                sb.Append($"{item.choice} ");
            }

            return $"Mark:{Mark}, Body:{Body}, Choices: {sb}";
        }

    }
    class MCQ:Questions
    {
        public MCQ(int _mark, string _body, choicesList _choices)
        {
            Mark = _mark;
            Body = _body;
            Choices = _choices;
        }

    }
    class TF : Questions
    {
        public TF(int _mark, string _body)
        {
            Mark = _mark;
            Body = _body;
            Choices.Add(new Choices("True"));
            Choices.Add(new Choices("False"));

        }
    }
    class questionList:List<Questions>
    {
        public void Add(Questions obj)
        {
            base.Add(obj);
            //any external functionality
            string path = @"C:\Users\sayed_boody\source\repos\Lab7\Questions.txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(obj);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(obj);
                }
            }
        }
    }
}
