using ArchBusiness.Services.Abstracts;
using ArchCore.Entities;
using ArchData.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchBusiness.Services.Concretes
{
    public class TeacherService : ITeacherService
    {
        public void Create(Teacher teacher)
        {
            ArchDatabase.Teachers.Add(teacher);
        }

        public void Delete(int id)
        {
            ArchDatabase.Teachers.Remove(ArchDatabase.Teachers.FirstOrDefault(teacher => teacher.Id == id));
        }

        public List<Teacher> GetAll()
        {
            return ArchDatabase.Teachers;
        }

        public Student GetById(int id)
        {
            return ArchDatabase.Students.FirstOrDefault((teacher => teacher.Id == id));
        }

        public void Update(Teacher student)
        {
            throw new NotImplementedException();
        }
    }
}
