using System;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blog.Entities
{
    /// <summary>
    /// Represents a T_PortTag.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    [Table("T_PortTag")]
    public class TPortTag : Entity<string>, IHasCreationTime
    {
        public TPortTag(string creator)
        {
            this.CreationTime = DateTime.Now;
            this.ModifyDateTime = DateTime.Now;
            this.IsValid = true;
            this.Creator = creator;
        }
        public TPortTag()
        { }

        [ForeignKey("Tag")]
        public virtual string TagId { get; set; }

        [ForeignKey("Port")]
        public virtual string PortId { get; set; }

        public virtual string Creator { get; set; }

        public virtual DateTime CreationTime { get; set; }

        public virtual string Modifier { get; set; }

        public virtual DateTime ModifyDateTime { get; set; }

        public virtual bool IsValid { get; set; }

        public virtual TPort Port { get; set; }

        public virtual TTag Tag { get; set; }
    }
}
