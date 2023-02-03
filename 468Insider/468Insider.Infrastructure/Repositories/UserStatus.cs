using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _468Insider.Infrastructure.Repositories;

[Table("User_Status")]
public partial class UserStatus
{
    [Key]
    [Column("User_Status_ID")]
    public int UserStatusId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Status { get; set; } = null!;

    [InverseProperty("UserStatus")]
    public virtual ICollection<User> Users { get; } = new List<User>();
}
