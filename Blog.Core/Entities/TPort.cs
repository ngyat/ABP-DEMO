using System;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Entities
{
  /// <summary>
  /// Represents a T_Ports.
  /// NOTE: This class is generated from a T4 template - you should not modify it manually.
  /// </summary>
  [Table("T_Ports")]
  public class TPort:Entity<string>,IHasCreationTime
  {
	public TPort (string creator)
	{
		this.CreationTime=DateTime.Now;
		this.ModifyDateTime=DateTime.Now;
		this.IsValid=true;
		this.Creator=creator;
	}
	public TPort ()
	{}

    public virtual string Title { get; set; }

    public virtual string Article { get; set; }

    public virtual string Posts { get; set; }

    public virtual string Creator { get; set; }

    public virtual DateTime CreationTime { get; set; }

    public virtual string Modifier { get; set; }

    public virtual DateTime ModifyDateTime { get; set; }

    public virtual bool IsValid { get; set; }

    public virtual int Views { get; set; }
  }
}
