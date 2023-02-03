using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _468Insider.Infrastructure.Repositories;

[Table("Points_Redeemed_Status")]
public partial class PointsRedeemedStatus
{
    [Key]
    [Column("Points_Redeemed_Status_ID")]
    public int PointsRedeemedStatusId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Status { get; set; }

    [InverseProperty("PointsRedeemedStatus")]
    public virtual ICollection<PointsRedeemed> PointsRedeemeds { get; } = new List<PointsRedeemed>();
}
