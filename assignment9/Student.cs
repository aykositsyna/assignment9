﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment9
{
    internal class Student
    {
        public string Name;
        public Dictionary<Dicipline, int> Practice;

        public Dictionary<Dicipline, int> FinalControl;

        public Student(string name, Dictionary<Dicipline, int> practice, Dictionary<Dicipline, int> finalControl)
        {
            Name = name;
            Practice = practice;
            FinalControl = finalControl;
        }
    }
}
