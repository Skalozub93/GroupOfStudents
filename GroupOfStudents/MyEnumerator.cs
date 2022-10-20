using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOfStudents
{
    internal class MyEnumerator
    {
        ArrayList arr;

        public MyEnumerator(ArrayList arr)
        {
           this.arr = arr;
        }

        public object Current
        {
            get;
            set;
        }

        int index;

        public bool MoveNext()
        {
            if(index < 0 || index >= arr.Count)
                return false;

            Current = arr[index++];
            return true;

        }

        public void Reset()
        {
            index = 0;
        }
    }
}
