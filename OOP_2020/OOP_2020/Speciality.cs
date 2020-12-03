using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2020
{
    public class Speciality
    {
        public Speciality()
        {
            Groups = new List<Group>();
            Disciplines = new List<Discipline>();
        }
        public int SpecialityId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Group> Groups { get; set; }

        public virtual ICollection<Discipline> Disciplines {get; set;}
    }
}
