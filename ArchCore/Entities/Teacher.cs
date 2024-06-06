using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchCore.Entities
{
    public class Teacher : BaseEntity
    {
        public string Fullname { get; set; }
        public double Salary { get; set; }
        public List<Student> Students { get; set; }
    }
}
