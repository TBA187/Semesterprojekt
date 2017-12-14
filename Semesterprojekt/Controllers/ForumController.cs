using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Umbraco.Web.WebApi;

namespace Semesterprojekt.Controllers
{
    public class ForumController : UmbracoAuthorizedApiController
    {
        //GET api/forum
        public IEnumerable<UForum> Get()
        { 
            forumDB context = new forumDB();

            var _forums = from f in context.UForums.AsEnumerable()
                           select f;
            //return context.UForums;
            return _forums;
        }

        //POST api/forum 
        [HttpPost]
        public HttpResponseMessage Post(UForum f)
        {
            if (f == null)
                return new HttpResponseMessage(HttpStatusCode.BadRequest);

            forumDB context = new forumDB();
            context.UForums.Add(f);
            context.SaveChanges();
            return new HttpResponseMessage(HttpStatusCode.Created);
        }

        //PUT api/forum
        [HttpPut]
        public HttpResponseMessage PutForum(UForum f)
        {
            forumDB context = new forumDB();
            UForum _f = context.UForums.Find(f.ForumId);
            if (_f == null)
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            _f.ForumName = f.ForumName;
            _f.ForumDate = f.ForumDate;

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        //DELETE api/forum
        [HttpDelete]
        public HttpResponseMessage DeleteForum(int id)
        {
            forumDB context = new forumDB();
            UForum _f = context.UForums.Find(id);
            if (_f == null)
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            context.UForums.Remove(_f);
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}