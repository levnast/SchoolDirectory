using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SchoolSystem
{
    public class StudentInterface: GeneralInterface
    {
        public Student Student;

        public void AddAnswerHomework()
        {
            var answer = Console.ReadLine();
        }
    }
}

