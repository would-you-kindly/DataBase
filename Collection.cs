//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DateBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Collection
    {
        public Collection()
        {
            this.Objects = new HashSet<Object>();
            this.Comments = new HashSet<Comment>();
            this.Marks = new HashSet<Mark>();
            this.Users = new HashSet<User>();
            this.Categories = new HashSet<Category>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<double> AverageMark { get; set; }
        public System.DateTime CreatingDate { get; set; }
    
        public virtual ICollection<Object> Objects { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Mark> Marks { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
    }
}