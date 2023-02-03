using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _468Insider.Infrastructure.Repositories;

[Table("Location_Type")]
public partial class LocationType
{
    [Key]
    [Column("Location_Type_ID")]
    public int LocationTypeId { get; set; }

    [Column("Location_Type_Description")]
    [StringLength(100)]
    [Unicode(false)]
    public string LocationTypeDescription { get; set; } = null!;

    [InverseProperty("LocationTypeNavigation")]
    public virtual ICollection<Location> Locations { get; } = new List<Location>();
}
