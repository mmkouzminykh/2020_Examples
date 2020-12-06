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

        public override string GetInfo()
        {
            return "Вызвана из Magister";
        }

        public override string GetInfoInt()
        {
            return "Вызвана из Magister";
        }


        public new string GetInfo2()
        {
            return "Вызвана из Magister";
        }
    }
}
