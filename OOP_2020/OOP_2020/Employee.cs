using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2020
{
    public class Employee: Human
    {
        public Employee(string Name, string Patronymic, string Familyname, DateTime Birthday, string Address, string Position) :
            base(Name, Patronymic, Familyname, Birthday, Address)
        {
            this.Position = Position;
        }

        public string Position { get; set; }

        public override string GetInfo()
        {
            return "Вызван из Employee";
        }

        public override string GetInfoInt()
        {
            return "Вызван из Employee";
        }
    }
}
