using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_2.Classes
{
    internal class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Bouns { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
        public int HourRate { get; set; }

        [InverseProperty("instructor")]
        public ICollection<Department> departments{ get;set; }=new HashSet<Department>();

        [InverseProperty("instructors")]
        [ForeignKey("Dept_ID")]
        [DeleteBehavior(DeleteBehavior.Cascade)]
        public Department department { get; set; }
    }
}
