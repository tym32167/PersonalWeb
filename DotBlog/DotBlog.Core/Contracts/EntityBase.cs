using System;
using System.ComponentModel.DataAnnotations;

namespace DotBlog.Core.Contracts
{
    public abstract class EntityBase : IIdentity<Guid>
    {
        public EntityBase()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }
    }
}