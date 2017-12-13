using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Semesterprojekt.Models
{
    public class Forums
    {
        public int forumId { get; set; }

        [Required]
        public string ForumName { get; set; }

        [Required]
        public DateTime ForumDate { get; set; }

        public int Fk_userid { get; set; }


        //public class ForumsDBContext : DbContext
        //{
        //    public DbSet<Forums> Forums { get; set; }
        //}
    }
}
