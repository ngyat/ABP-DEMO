using System;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace Blog.Entities
{
  /// <summary>
  /// Represents a T_User.
  /// NOTE: This class is generated from a T4 template - you should not modify it manually.
  /// </summary>
  public class TUser:Entity<string>,IHasCreationTime
  {
	public TUser (string creator)
	{
		this.CreationTime=DateTime.Now;
		this.ModifyDateTime=DateTime.Now;
		this.IsValid=true;
		this.Creator=creator;
	}
	public TUser ()
	{}
    public virtual string ObjId { get; set; }

    public virtual string PassWord { get; set; }

    public virtual string RoleID { get; set; }

    public virtual string NickName { get; set; }

    public virtual string Contact { get; set; }

    public virtual string Image { get; set; }

    public virtual DateTime LastLoginTime { get; set; }

    public virtual string Profile { get; set; }

    public virtual string Email { get; set; }

    public virtual char Gender { get; set; }

    public virtual string Creator { get; set; }

    public virtual DateTime CreationTime { get; set; }

    public virtual string Modifier { get; set; }

    public virtual DateTime ModifyDateTime { get; set; }

    public virtual bool IsValid { get; set; }
  }
}
