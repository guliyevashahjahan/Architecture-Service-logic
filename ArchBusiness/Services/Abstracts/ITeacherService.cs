using ArchCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchBusiness.Services.Abstracts
{
    public interface ITeacherService
    {
        void Create(Teacher teacher);
        Student GetById(int id);
        List<Teacher> GetAll();
        void Update(Teacher student);
        void Delete(int id);
    }
}
