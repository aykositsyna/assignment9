using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment9
{
    abstract class Dicipline
    {
        public string Name;
        public abstract string Check(Student student);
    }
}
