using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace Semesterprojekt.App_Plugins.Forum.Object
{
    [TableName("Forum")]
    public class Forum
    {
        public Forum()
        {

        }

        [PrimaryKeyColumn(AutoIncrement = true)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }


    }
}