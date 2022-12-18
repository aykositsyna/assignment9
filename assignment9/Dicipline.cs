using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment9
{
    abstract class Dicipline
    {
        public string Name { get; set; }
        public abstract string Check(Student student);
        public Dicipline()
        { }
    }
}
