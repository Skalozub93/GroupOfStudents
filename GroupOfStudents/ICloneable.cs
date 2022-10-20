using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOfStudents
{
    internal interface ICloneable<T> where T : ICloneable<T>
    {
        T Clone();
    }
}
