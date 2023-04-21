using Data.Database;
using Data.Interfaces;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services
{
    public class SStudent:IStudent
    {
        ContextDb Db = new ContextDb();

        public List<MStudent> GetStudents() 
        {
            try
            {
               return Db.Student.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        
        }
        public bool CreateStudents(MStudent? student)
        {
            try
            {
                student.Id = Guid.NewGuid();
                 Db.Student.Add(student);
                 Db.SaveChanges();  
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool UpadateStudent(MStudent StudentId)
        {
            try
            {
                Db.Student.Update(StudentId);
                Db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }


        
        }
        public bool DeleteStudent(MStudent StudentId)
        {
            try
            {
                Db.Student.Remove(StudentId);
                Db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }



        }

        public MStudent Getstudent(Guid id) 
        {
            try
            {
                return Db.Student.Where(x=> x.Id == id).FirstOrDefault();  


            }
            catch (Exception)
            {

                return null;
            }
        
        
        }



    }
}
