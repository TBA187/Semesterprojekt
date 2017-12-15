using Semesterprojekt.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Semesterprojekt.Controllers
{
    public class ForumViewController : Controller
    {
        private ForumViewModel forum = new ForumViewModel();

        forumDB context = new forumDB();

        //public ActionResult Index()
        //{
        //    var _forums = from f in context.UForums.AsEnumerable()
        //                  select f;
        //    //return context.UForums;

        //    return View(_forums);
        //}


        //public ActionResult Index()
        //{
        //    var studentViewModel = from s in context.UForums
        //                           join st in context.UForumCats on s.ForumId equals st.fk_ForumId into st2
        //                           from st in st2.DefaultIfEmpty()
        //                           select new ForumViewModel { StudentVm = s, studentAdditionalInfoVm = st };
        //    return View(studentViewModel);
        //}


        public ActionResult Index()
        {

            string record = "asfdasd";

            return View(record);
        }

    }
}