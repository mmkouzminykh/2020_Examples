using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2020
{
    public class Group
    {
        public Group()
        {
            Students = new List<Student>();
        }
        [Key]
        public int GroupCode { get; set; }

        [StringLength(100)]
        [Required]
        [Column("GroupName")]
        public string Name { get; set; }

        public virtual ICollection<Student> Students { get; set; }

        public int SpecialityId { get; set; }

        [ForeignKey("SpecialityId")]
        public Speciality Speciality { get; set; }

    }
}
