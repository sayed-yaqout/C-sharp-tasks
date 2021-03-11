using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Examination_System
{
    class Choices
    {
        public string choice { get; set; }
        public Choices(string _choice)
        {
            choice = _choice;
        }
    }
    class choicesList : List<Choices>
    {

    }
}
