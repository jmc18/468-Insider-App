using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _468Insider.Infrastructure.Repositories;

[Table("App_Used")]
public partial class AppUsed
{
    [Key]
    [Column("App_Used_ID")]
    public int AppUsedId { get; set; }

    [Column("Client_ID")]
    public int ClientId { get; set; }

    [Column("User_ID")]
    public int? UserId { get; set; }

    [Column("App_Used_Moment", TypeName = "datetime")]
    public DateTime AppUsedMoment { get; set; }

    [ForeignKey("ClientId")]
    [InverseProperty("AppUseds")]
    public virtual Client Client { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("AppUseds")]
    public virtual User? User { get; set; }
}
