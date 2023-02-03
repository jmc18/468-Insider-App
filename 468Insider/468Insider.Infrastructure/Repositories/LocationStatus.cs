using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _468Insider.Infrastructure.Repositories;

[Table("Location_Status")]
public partial class LocationStatus
{
    [Key]
    [Column("Location_Status_ID")]
    public int LocationStatusId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Status { get; set; } = null!;

    [InverseProperty("LocationStatus")]
    public virtual ICollection<Location> Locations { get; } = new List<Location>();
}
