using System;
using System.ComponentModel.DataAnnotations.Schema;
using DotBlog.Core.Contracts;

namespace DotBlog.Core.Objects
{
    public class List : EntityBase
    {
        public Guid ListTypeId { get; set; }


        [ForeignKey("ListTypeId")]
        public virtual ListType Type { get; set; }


        public string Content { get; set; }
    }
}