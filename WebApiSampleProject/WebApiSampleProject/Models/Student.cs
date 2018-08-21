using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WebApiSampleProject.Models
{
    public class Student
    {
        public int StudentId
        {
            get;
            set;
        }
        public string StudentName
        {
            get;
            set;
        }
        public string StudentCourse
        {
            get;
            set;
        }
        public string StudentYear
        {
            get;
            set;
        }
    }
}