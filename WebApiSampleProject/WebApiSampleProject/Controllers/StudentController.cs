using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiSampleProject.Models;
using WebApiSampleProject.Controllers;


namespace WebApiSampleProject.Controllers
{

    public class StudentController : ApiController
    {

        IList<Student> students = new List<Student>()
        {
            new Student()
            {
               StudentId = 1, StudentName = "Joan M. Lumagbas", StudentCourse = "BSIT", StudentYear = "4"  
            },
            new Student()
            {
               StudentId = 1, StudentName = "Giesel P. Dumalagan", StudentCourse = "BEED", StudentYear = "4"  
            },
            new Student()
            {
               StudentId = 1, StudentName = "Mary Ann Y. Lumictin", StudentCourse = "BEED", StudentYear = "3"  
            },
        };
        public IList<Student> GetAllStudents()
        {
            //Return list of all Student  
            return students;
        }
        public Student GetStudentDetails(int Studentid)
        {
            //Return a single Student detail  
            var student = students.FirstOrDefault(e => e.StudentId == Studentid);
            if (student == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }
            return student;
        }  

    }
        
}
