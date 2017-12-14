//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;


//namespace Semesterprojekt.Controllers
//{
//    public class PersonsController : ApiController
//    {
//        //GET api/person
//        //For retrieving all the people
//        public IEnumerable<Person> GetPeople()
//        {
//            alphajob_dk_dbEntities context = new alphajob_dk_dbEntities();
//            var _persons = from p in context.People.AsEnumerable()
//                           select p;
//            return _persons;
//        }

//        //POST api/person 
//        //For creating new person
//        [HttpPost]
//        public HttpResponseMessage PostPerson(Person p)
//        {
//            if (p == null)
//                return new HttpResponseMessage(HttpStatusCode.BadRequest);
//            alphajob_dk_dbEntities context = new alphajob_dk_dbEntities();
//            context.People.Add(p);
//            context.SaveChanges();
//            return new HttpResponseMessage(HttpStatusCode.Created);
//        }
//    }
//}