using ArchCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchBusiness.Services.Abstracts
{
    public interface IStudentService
    {
        void Create(Student student);
        Student GetById(int id);
        List<Student> GetAll();
        void Update(Student student);
        void Delete(int id);
    }
}
