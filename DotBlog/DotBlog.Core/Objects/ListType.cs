using System;
using System.Collections.Generic;
using DotBlog.Core.Contracts;

namespace DotBlog.Core.Objects
{
    public class ListType : EntityBase
    {
        public string Name { get; set; }
        public virtual ICollection<List> Lists { get; set; }
    }
}