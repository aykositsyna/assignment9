using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment9
{
    internal class Programming : Dicipline
    {
        public override string Check(Student student)
        {
            int studentPractice;
            student.Practices.TryGetValue(this, out studentPractice);

            if (studentPractice >= IHavePractice.PracticeCount)
            {
                return (student.Name + " submitted enough assignments and gets autopass for " + this.Name);
            }
            else
            {
                return (student.Name + " didn't submit enough assignments and doesn't get autopass for " + this.Name + " :(");
            }
        }

    }
}
