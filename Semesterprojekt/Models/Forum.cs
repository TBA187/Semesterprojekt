using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Semesterprojekt.Models
{
    public class Forum
    {
        public int forumId { get; set; }

        [Required]
        public string forumTitle { get; set; }

        [Required]
        public string forumSubject { get; set; }
    }
}