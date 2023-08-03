using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StudentIntelisenceApi.Business_Layer;
using StudentIntelisenceApi.Models;
namespace StudentIntelisenceApi.Controllers
{
    public class StudentController : ApiController
    {
        public StudentBL datalayer=new StudentBL();
        [HttpGet]
        [Route("GetAllStudents")]
        public List<Student> GetAllStudents()
        {
            try
            
            {
                List<Student> students = new List<Student>();
                students = datalayer.GetAllStudents();
                return students;
            }
            catch (Exception exception)
            {
                throw new Exception("An exception of type " + exception.GetType().ToString()
                   + " is encountered in GetListOfStudents due to "
                   + exception.Message, exception.InnerException);
            }
        }

        [HttpGet]
        [Route("FetchbyName")]
        public List<Student> GetbyName(string str)
        {
            if (str!=null)
            {
                try

                {
                    List<Student> students = new List<Student>();
                    students = datalayer.GetbyName(str);
                    return students;
                }
                catch (Exception exception)
                {
                    throw new Exception("An exception of type " + exception.GetType().ToString()
                       + " is encountered in GetListOfStudents due to "
                       + exception.Message, exception.InnerException);
                }
            }
            else
            {
                List<Student> emptystudent = new List<Student>();
                return emptystudent;
            }
        }
    }
}