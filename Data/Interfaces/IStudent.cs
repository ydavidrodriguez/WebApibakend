using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IStudent
    {
        public List<MStudent> GetStudents();
        public bool CreateStudents(MStudent student);
        public bool UpadateStudent(MStudent StudentId);
        public bool DeleteStudent(MStudent StudentId);
        public MStudent Getstudent(Guid id);


    }
}
