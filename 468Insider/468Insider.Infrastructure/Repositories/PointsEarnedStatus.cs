using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _468Insider.Infrastructure.Repositories;

[Table("Points_Earned_Status")]
public partial class PointsEarnedStatus
{
    [Key]
    [Column("Points_Earned_Status_ID")]
    public int PointsEarnedStatusId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Status { get; set; } = null!;

    [InverseProperty("PointsEarnedStatus")]
    public virtual ICollection<PointsEarned> PointsEarneds { get; } = new List<PointsEarned>();
}
