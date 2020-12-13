using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2020
{
    public class GroupEnumerator : IEnumerator<Student>
    {
        private List<Student> students;

        private int currentPosition = -1;
        public GroupEnumerator(List<Student> students)
        {
            this.students = students;
        }
        public Student Current => students[currentPosition];

        object IEnumerator.Current => students[currentPosition];

        public void Dispose()
        {            
        }

        public bool MoveNext()
        {
            if (currentPosition < students.Count - 1)
            {
                currentPosition++;
                return true;
            }
            else
            {
                return false;
            }
                
        }

        public void Reset()
        {
            currentPosition = -1;
        }

     
    }
}
