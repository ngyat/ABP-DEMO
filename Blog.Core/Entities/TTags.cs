using System;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace Blog.Entities
{
  /// <summary>
  /// Represents a T_Tags.
  /// NOTE: This class is generated from a T4 template - you should not modify it manually.
  /// </summary>
  public class TTags:Entity<string>,IHasCreationTime
  {
	public TTags (string creator)
	{
		this.CreationTime=DateTime.Now;
		this.ModifyDateTime=DateTime.Now;
		this.IsValid=true;
		this.Creator=creator;
	}
	public TTags ()
	{}
    public virtual string ObjId { get; set; }

    public virtual string Name { get; set; }

    public virtual string Creator { get; set; }

    public virtual DateTime CreationTime { get; set; }

    public virtual string Modifier { get; set; }

    public virtual DateTime ModifyDateTime { get; set; }

    public virtual bool IsValid { get; set; }
  }
}
