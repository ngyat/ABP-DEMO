using System;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Authorization.Users;
using Blog.Users;
using Microsoft.AspNet.Identity;

namespace Blog.Entities
{
    /// <summary>
    /// Represents a T_RortReply.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    [Table("T_RortReply")]
    public class TRortReply:Entity<string>,IHasCreationTime
  {
	public TRortReply (string creator)
	{
		this.CreationTime=DateTime.Now;
		this.ModifyDateTime=DateTime.Now;
		this.IsValid=true;
		this.Creator=creator;
	}
	public TRortReply ()
	{}
    public virtual string ReplyID { get; set; }

    public virtual string ReplyUserID { get; set; }

    public virtual string Content { get; set; }

    public virtual string Creator { get; set; }

    public virtual DateTime CreationTime { get; set; }

    public virtual string Modifier { get; set; }

    public virtual DateTime ModifyDateTime { get; set; }

    public virtual bool IsValid { get; set; }

       
    }
}
