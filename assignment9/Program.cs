using assignment9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Dicipline[] diciplines = new Dicipline[3]
            {
                new Programming(),
                new Mathematics(),
                new History()
            };

            Student[] students = new Student[5];

            Random random = new Random();
            Array values1 = Enum.GetValues(typeof(Names));

            for (int i = 0; i < students.Length; i++)
            {
                string randomName = ((Names)values1.GetValue(random.Next(values1.Length))).ToString();
                Dictionary<Dicipline, int> Practices = new Dictionary<Dicipline, int>()
                {
                    {diciplines[0], random.Next(0, 9) }
                };
                Dictionary<Dicipline, int> FinalControl = new Dictionary<Dicipline, int>()
                {
                    {diciplines[0], random.Next(0, 5) },
                    {diciplines[1], random.Next(0, 5) },
                };
                students[i] = new Student(randomName, Practices, FinalControl);

            }

            Console.WriteLine("\nHistory\n------------------");
            Console.WriteLine(diciplines[2].Check(students[0]));
            Console.WriteLine("\nMathematics\n------------------");
            foreach (Student student in students)
            {
                Console.WriteLine(diciplines[1].Check(student));
            }
            Console.WriteLine("\nProgramming\n------------------");
            foreach (Student student in students)
            {
                Console.WriteLine(diciplines[0].Check(student));
            }

        }
    }
}