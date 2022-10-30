using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOfStudents
{
    internal class MyEnumerator
    {   
        /// <summary>
        /// 
        /// </summary>
        SortedSet<Student> massive;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="massive"></param>
        public MyEnumerator(SortedSet<Student> massive)
        {
            this.massive=massive;
        }

        /// <summary>
        /// 
        /// </summary>
        public object Current
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        int index;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            if(index >= massive.Count)
            {
                return false;
            }
            Current = massive.ElementAt<Student>(index++);
            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        public void Reset()
        {
            massive.Clear();
        }
    }
}
