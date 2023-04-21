using Data.Interfaces;
using Data.Models;
using Data.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly IStudent StudentService;

        public StudentController(IStudent Student)
        {
            StudentService = Student;
        }

        [HttpGet]
        [Route("ListByStudent")]
        public List<MStudent> ListByBodega()
        {
            try
            {
                var Response = StudentService.GetStudents();

                if (Response == null)
                    throw new Exception();

                return Response;
            }
            catch (Exception)
            {
                return null;
            }
        }
        [HttpGet]
        [Route("ByStudent/{Id}")]
        public MStudent ByStudent(Guid Id)
        {
            try
            {
                var Response = StudentService.Getstudent(Id);

                if (Response == null)
                    throw new Exception();

                return Response;
            }
            catch (Exception)
            {
                return null;
            }
        }


        [HttpPost]
        [Route("CreateStudent")]
        public bool CreateStudent(MStudent? student)
        {
            try
            {
                var Response = StudentService.CreateStudents(student);

                if (Response == null)
                    throw new Exception();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        [HttpPut]
        [Route("UpadateStudent")]
        public bool UpadateStudent(MStudent StudentId)
        {
            try
            {
                var Response = StudentService.UpadateStudent(StudentId);

                if (Response == false)
                    throw new Exception();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        [HttpPut]
        [Route("DeleteStudent")]
        public bool DeleteStudent(MStudent StudentId)
        {
            try
            {
                var Response = StudentService.DeleteStudent(StudentId);

                if (Response == null)
                    throw new Exception();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
