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
    public class StudentService : IStudentService
    {
        public void Create(Student student)
        {
            ArchDatabase.Students.Add(student);
        }

        public void Delete(int id)
        {

            ArchDatabase.Students.Remove(ArchDatabase.Students.FirstOrDefault(student => student.Id == id));
        }

        public List<Student> GetAll()
        {
            return ArchDatabase.Students;
        }

        public Student GetById(int id)
        {
            return ArchDatabase.Students.FirstOrDefault(student => student.Id == id);
        }

        public void Update(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
