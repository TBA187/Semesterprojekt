//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Semesterprojekt
{
    using System;
    using System.Collections.Generic;
    
    public partial class UForumCat
    {
        public int CatId { get; set; }
        public string CatName { get; set; }
        public string CatDesc { get; set; }
        public Nullable<System.DateTime> CatDate { get; set; }
        public Nullable<int> fk_ForumId { get; set; }
        public Nullable<int> fk_UserId { get; set; }
    }
}
