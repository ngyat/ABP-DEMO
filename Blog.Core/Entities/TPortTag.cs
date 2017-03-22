using System;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace Blog.Entities
{
  /// <summary>
  /// Represents a T_PortTag.
  /// NOTE: This class is generated from a T4 template - you should not modify it manually.
  /// </summary>
  public class TPortTag:Entity<string>,IHasCreationTime
  {
	public TPortTag (string creator)
	{
		this.CreationTime=DateTime.Now;
		this.ModifyDateTime=DateTime.Now;
		this.IsValid=true;
		this.Creator=creator;
	}
	public TPortTag ()
	{}
    public virtual string ObjId { get; set; }

    public virtual string TagId { get; set; }

    public virtual string PortId { get; set; }

    public virtual string Creator { get; set; }

    public virtual DateTime CreationTime { get; set; }

    public virtual string Modifier { get; set; }

    public virtual DateTime ModifyDateTime { get; set; }

    public virtual bool IsValid { get; set; }
  }
}
