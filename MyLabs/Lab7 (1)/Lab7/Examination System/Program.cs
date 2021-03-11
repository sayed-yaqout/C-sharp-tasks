using System;

namespace Examination_System
{
    class Program
    {
        static void Main(string[] args)
        {
            choicesList TectChoices = new choicesList();
            TectChoices.Add(new Choices("Ahmed"));
            TectChoices.Add(new Choices("Sobhy"));
            TectChoices.Add(new Choices("ronaldo"));
            TectChoices.Add(new Choices("messi"));
            TectChoices.Add(new Choices("matic"));
            TectChoices.Add(new Choices("dist"));
            questionList TestList
                = new questionList();
            TestList.Add(new MCQ(1, "WHAT IS YOUR NAME", TectChoices));
            //myList.Add()
            Final E1= new Final();
            E1.MyExam.Add(new MCQ(1, "WHAT IS YOUR NAME", TectChoices), new Answer("Sarah"));
            E1.MyExam.Add(new MCQ(1, "can u speak english", TectChoices), new Answer("Sarah"));
            E1.MyExam.Add(new MCQ(1, "how old are u", TectChoices), new Answer("Sarah"));
            E1.MyExam.Add(new MCQ(1, "WHAT IS YOUR nationality", TectChoices), new Answer("Sarah"));
            E1.Show();

          
        }
    }
}
