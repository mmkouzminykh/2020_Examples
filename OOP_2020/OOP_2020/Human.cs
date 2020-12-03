using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2020
{
    public class Human
    {
        public readonly string testVar;
        protected string _Name;
        private string _Patronymic;        
        private string _FamilyName;
        private DateTime _Birthday;
        
        private static int _Count;

        static Human()
        {
            _Count = 0;
        }

        public Human(string Name, string Patronymic, string FamilyName, DateTime Birthday, string Address)
        {
            this.Name = Name;
            this.Patronymic = Patronymic;
            this.FamilyName = FamilyName;
            this.Birthday = Birthday;
            this.Address = Address;

            this.testVar = "Test value";

            _Count++;
        }

        public Human(string Name, string Patronymic, string FamilyName): this(Name, Patronymic, FamilyName, DateTime.Now, "")
        {
            this.testVar = "Another value";
        }

        public Human(): this("Иван", "Иванович", "Иванов", DateTime.Now, "")
        { }
                
        public int ID { get; set; }

        [Required]
        [StringLength(50)]

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (value.Length > 50)
                    _Name = value.Substring(0, 50);
                else
                    _Name = value;                
            }
        }
        [Required]
        [StringLength(50)]
        public string Patronymic
        {
            get => _Patronymic;
            set => _Patronymic = value;
        }

        [Required]
        [StringLength(50)]
        public string FamilyName
        {
            get
            {
                return _FamilyName;
            }
            set
            {
                _FamilyName = value;
            }
        }

        public string Address { get; set; }

        public DateTime Birthday
        {
            get 
            { 
                return _Birthday; 
            }
            set
            {
                if (DateTime.Now.Year - value.Year > 100)
                    _Birthday = new DateTime();
                else
                {
                    if (value > DateTime.Now)
                    {
                        _Birthday = new DateTime();
                    }
                    else
                    {
                        _Birthday = value;
                    }
                }                    
            }
        }

        [NotMapped]
        public string testProperty { get; set; }
        
        public string this[string propName]
        {
            get
            {
                switch (propName)
                {
                    case "Name":
                        return this.Name;
                    case "Patronymic":
                        return this.Patronymic;
                    case "FamilyName":
                        return this.FamilyName;
                    default:
                        return "";
                }
            }
        }

        public int GetAge()
        {
            return DateTime.Now.Year - _Birthday.Year;
        }

        public static int Count
        {
            get => _Count;
        }

        public override string ToString()
        {
            return Name + " " + Patronymic + " " + FamilyName;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Human h = obj as Human;
            if (h == null)
                return false;

            if (Name != h.Name)
                return false;
            if (Patronymic != h.Patronymic)
                return false;
            if (FamilyName != h.FamilyName)
                return false;
            return true;
        }

        public static bool operator==(Human first, Human second)
        {
            if ((object)first == null && (object)second != null)
                return false;
            if ((object)first != null && (object)second == null)
                return false;
            if ((object)first == null && (object)second == null)
                return true;

            if (first.Name != second.Name)
                return false;
            if (first.Patronymic != second.Patronymic)
                return false;
            if (first.FamilyName != second.FamilyName)
                return false;
            return true;
        }

        public static bool operator!=(Human first, Human second)
        {
            return !(first == second);
        }
        
    }
}
