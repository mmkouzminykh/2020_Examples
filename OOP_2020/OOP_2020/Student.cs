using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2020
{
    public class Student: Human
    {
        public Student(string Name, string Patronymic, string Familyname, DateTime Birthday, string Address): base(Name, Patronymic, Familyname, Birthday, Address)
        {
            Course = 1;            
        }

        public int Course { get; private set; }

        public int? GroupCode { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("GroupCode")]
        public Group Group { get; set; }
    }
}
