using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchCore.Entities
{
    public class Student : BaseEntity
    {
        public string Fullname { get; set; }
        public double Grade { get; set; }
        public int TeacherId { get; set; }

    }
}
