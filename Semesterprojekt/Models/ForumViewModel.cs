using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Models;

namespace Semesterprojekt.Models
{
    public class ForumViewModel : RenderModel
    {

        public ForumViewModel() : this(new UmbracoHelper(UmbracoContext.Current).TypedContent(UmbracoContext.Current.PageId)) {
        }
        public ForumViewModel(IPublishedContent content, CultureInfo culture) : base(content, culture) { }
        public ForumViewModel(IPublishedContent content) : base(content) { }

        public UForum StudentVm { get; set; }
        public UForumCat studentAdditionalInfoVm { get; set; }


        // Instansere (oprette instans) af listen BlogIndlaeg
        //public static List<BlogIndlaeg> blogList = new List<BlogIndlaeg>();

        //forumDB context = new forumDB();

        //private object listLock = new object();


        //public List<forumDB> BindForum()
        //{


        //    using (forumDB db = new forumDB())
        //    {
        //        var forum = (from f in context.UForums
        //                     join fc in context.UForumCats on f.ForumId equals fc.fk_ForumId
        //                     join ft in context.UForumThreads on fc.CatId equals ft.fk_CatId
        //                     join t in context.UForumTopics on ft.ThreadId equals t.fk_ThreadId
        //                     where f.ForumId == 2
        //                     select f).ToList();

        //        return forum;

        //    }
        //}

    }
}


