using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2020
{
    public class Discipline
    {
        public Discipline()
        {
            Specialities = new List<Speciality>();
        }
        public int DisciplineId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Speciality> Specialities { get; set; }
    }
}
