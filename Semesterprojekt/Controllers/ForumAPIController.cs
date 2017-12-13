using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Semesterprojekt.Controllers
{
    public class ForumAPIController : ApiController
    {
    

        public class StudentsApiController : ApiController
        {

            Data Source = myServerAddress; Initial Catalog = myDataBase; Integrated Security = SSPI;
            User ID = myDomain\myUsername;Password=myPassword;


            private StudentsContext db = new StudentsContext();

            // GET api/StudentsApi
            public IQueryable<Student> GetStudents()
            {
                return db.Students;
            }

            // GET api/StudentsApi/2
            [ResponseType(typeof(Student))]
            public IHttpActionResult GetStudent(int id)
            {
                //try to find the student in the Students db table
                Student student = db.Students.Find(id);
                //if there is no student with that ID, return Not found
                if (student == null)
                {
                    return NotFound();
                }
                //if there is a student with that ID, return it
                return Ok(student);
            }
        }
}

