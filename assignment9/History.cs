using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static assignment9.Dicipline;

namespace assignment9
{
    internal class History : Dicipline, IHaveAngryTeacher
    {
        public override string Check(Student student)
        {
            return (this.Name + IHaveAngryTeacher.fu);
        }
    }
}
