using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment9
{
    internal class Mathematics : Dicipline
    {
        public override string Check(Student student)
        {
            int studentExam;
            student.FinalControl.TryGetValue(this, out studentExam);

            if (studentExam >= IHaveFinalControl.PassingScore)
            {
                return (student.Name + " scored enough points and gets autopass for " + this.Name);
            }
            else
            {
                return (student.Name + " didn't score enough points and doesn't get autopass for " + this.Name + " :(");
            }
        }
    }
}
