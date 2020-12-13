using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2020
{
    public class Group: IEnumerable<Student>, IDisposable
    {
        public Group()
        {
            Students = new List<Student>();
        }

        ~Group()
        {

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

        public void Dispose()
        {
            System.Windows.Forms.MessageBox.Show("Is disposing");
        }

        public IEnumerator<Student> GetEnumerator()
        {
            //return this.Students.GetEnumerator();
            //return new GroupEnumerator((List<Student>)this.Students);
            foreach(var s in Students)
            {
                yield return s;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            //return this.Students.GetEnumerator();
            //return new GroupEnumerator((List<Student>)this.Students);
            foreach (var s in Students)
            {
                yield return s;
            }
        }
    }
}
