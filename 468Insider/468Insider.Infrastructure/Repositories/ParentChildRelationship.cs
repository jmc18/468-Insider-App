using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _468Insider.Infrastructure.Repositories;

[Table("Parent_Child_Relationships")]
public partial class ParentChildRelationship
{
    [Key]
    [Column("Parent_Child_Relationship_ID")]
    public int ParentChildRelationshipId { get; set; }

    [Column("Parent_Location_ID")]
    public int ParentLocationId { get; set; }

    [Column("Child_Location_ID")]
    public int ChildLocationId { get; set; }

    [ForeignKey("ChildLocationId")]
    [InverseProperty("ParentChildRelationshipChildLocations")]
    public virtual Location ChildLocation { get; set; } = null!;

    [ForeignKey("ParentLocationId")]
    [InverseProperty("ParentChildRelationshipParentLocations")]
    public virtual Location ParentLocation { get; set; } = null!;
}
