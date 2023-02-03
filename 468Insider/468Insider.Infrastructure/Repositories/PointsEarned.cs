using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _468Insider.Infrastructure.Repositories;

[Table("Points_Earned")]
public partial class PointsEarned
{
    [Key]
    [Column("Points_Earned_ID")]
    public int PointsEarnedId { get; set; }

    [Column("Client_ID")]
    public int ClientId { get; set; }

    [Column("User_ID")]
    public int UserId { get; set; }

    [Column("Location_ID")]
    public int LocationId { get; set; }

    [Column("Points_Earned_Status_ID")]
    public int PointsEarnedStatusId { get; set; }

    [Column("TotalPoints_Earned")]
    public int TotalPointsEarned { get; set; }

    [Column("Points_Earned_Moment", TypeName = "datetime")]
    public DateTime PointsEarnedMoment { get; set; }

    [ForeignKey("ClientId")]
    [InverseProperty("PointsEarneds")]
    public virtual Client Client { get; set; } = null!;

    [ForeignKey("LocationId")]
    [InverseProperty("PointsEarneds")]
    public virtual Location Location { get; set; } = null!;

    [ForeignKey("PointsEarnedStatusId")]
    [InverseProperty("PointsEarneds")]
    public virtual PointsEarnedStatus PointsEarnedStatus { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("PointsEarneds")]
    public virtual User User { get; set; } = null!;
}
