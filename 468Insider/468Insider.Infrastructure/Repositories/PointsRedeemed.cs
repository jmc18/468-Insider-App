using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _468Insider.Infrastructure.Repositories;

[Table("Points_Redeemed")]
public partial class PointsRedeemed
{
    [Key]
    [Column("Points_Redeemed_ID")]
    public int PointsRedeemedId { get; set; }

    [Column("Client_ID")]
    public int ClientId { get; set; }

    [Column("User_ID")]
    public int UserId { get; set; }

    [Column("Location_ID")]
    public int LocationId { get; set; }

    [Column("Points_Redeemed_Status_ID")]
    public int PointsRedeemedStatusId { get; set; }

    [Column("Total_Points_Redeemed")]
    public int TotalPointsRedeemed { get; set; }

    [Column("Points_Redeemed_Moment", TypeName = "datetime")]
    public DateTime PointsRedeemedMoment { get; set; }

    [ForeignKey("ClientId")]
    [InverseProperty("PointsRedeemeds")]
    public virtual Client Client { get; set; } = null!;

    [ForeignKey("LocationId")]
    [InverseProperty("PointsRedeemeds")]
    public virtual Location Location { get; set; } = null!;

    [ForeignKey("PointsRedeemedStatusId")]
    [InverseProperty("PointsRedeemeds")]
    public virtual PointsRedeemedStatus PointsRedeemedStatus { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("PointsRedeemeds")]
    public virtual User User { get; set; } = null!;
}
