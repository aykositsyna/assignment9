using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment9
{
    internal class Programming : Dicipline, IHavePractice, IHaveFinalControl
    {
        public int PracticeCount { get; set; }
        public int PassingScore { get; set; }
        public Programming()
        {
            PracticeCount = 9;
            PassingScore = 3;
            Name = "Programming";
        }


        public override string Check(Student student)
        {
            int studentPractice;
            student.Practices.TryGetValue(this, out studentPractice);

            if (studentPractice >= PracticeCount)
            {
                return (student.Name + " submitted enough assignments and gets autopass for " + this.Name);
            }
            else
            {
                return (student.Name + " didn't submit enough assignments and doesn't get autopass for " + this.Name + " :(");
            }

            int studentExam;
            student.FinalControl.TryGetValue(this, out studentExam);

            if (studentExam >= PassingScore)
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
