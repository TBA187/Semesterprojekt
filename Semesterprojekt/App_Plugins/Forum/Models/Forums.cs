using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Remoting.Contexts;
using Lucene.Net.Documents;
using System.ComponentModel.DataAnnotations.Schema;

namespace Semesterprojekt.Models
{
    public class Forums
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ForumId { get; set; }

        [Required]
        public string ForumName { get; set; }

        [Required]
        public DateTime ForumDate { get; set; }

        public int fk_UserId { get; set; }

    }

    //public class ForumsContext : Context
    //{
    //    public ForumsContext() : base("name=DefaultConnection")
    //    {
    //        base.Configuration.ProxyCreationEnabled = false;
    //    }
    //    public DbSet<Forums> Friends { get; set; }
    //}
}
