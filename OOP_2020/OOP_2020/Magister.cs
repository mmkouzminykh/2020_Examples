using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2020
{
    public class Magister: Student
    {
        public Magister(string Name, string Patronymic, string Familyname, DateTime Birthday, string Address): 
            base (Name, Patronymic, Familyname, Birthday, Address)
        {

        }
    }
}
