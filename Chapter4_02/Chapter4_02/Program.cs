using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_02
{
    class Program
    {
        static void Main()
        {

            Exam exam = new Exam();
            exam.InsertAfter(null, 1);
            exam.InsertAfter(exam.head, 2);
            exam.InsertAfter(exam.head.Next, 3);

            exam.Delete(exam.head.Next);

            exam.DisplayList();

        }
    }
}
