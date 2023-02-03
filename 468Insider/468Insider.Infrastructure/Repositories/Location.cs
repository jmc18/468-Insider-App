using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _468Insider.Infrastructure.Repositories;

public partial class Location
{
    [Key]
    [Column("Location_ID")]
    public int LocationId { get; set; }

    [Column("Client_ID")]
    public int ClientId { get; set; }

    [Column("Location_Status_ID")]
    public int LocationStatusId { get; set; }

    [Column("Location_Name")]
    public string? LocationName { get; set; }

    public string Description { get; set; } = null!;

    [Column("Map_GPS")]
    [StringLength(100)]
    [Unicode(false)]
    public string MapGps { get; set; } = null!;

    [Column("Point_Collection_Radius")]
    [StringLength(50)]
    [Unicode(false)]
    public string PointCollectionRadius { get; set; } = null!;

    public string? Photo { get; set; }

    [StringLength(255)]
    public string? Address1 { get; set; }

    [StringLength(255)]
    public string? Address2 { get; set; }

    [StringLength(50)]
    public string? City { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? State { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Zip { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? CountryCode { get; set; }

    [StringLength(50)]
    public string? Phone { get; set; }

    [StringLength(255)]
    public string? Email { get; set; }

    [Column("URL")]
    [StringLength(300)]
    public string? Url { get; set; }

    [Column("Facebook_URL")]
    [StringLength(300)]
    public string? FacebookUrl { get; set; }

    [Column("Pinterest_URL")]
    [StringLength(300)]
    public string? PinterestUrl { get; set; }

    [Column("Twitter_URL")]
    [StringLength(300)]
    public string? TwitterUrl { get; set; }

    [Column("InstaGram_URL")]
    [StringLength(300)]
    public string? InstaGramUrl { get; set; }

    [Column("Parent_Location")]
    public bool ParentLocation { get; set; }

    [Column("Category_ID")]
    public int? CategoryId { get; set; }

    [Column("Reward_Points_Earned")]
    public int? RewardPointsEarned { get; set; }

    [Column("Location_Type")]
    public int LocationType { get; set; }

    [Column("Reward_Description")]
    [Unicode(false)]
    public string? RewardDescription { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Created { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Updated { get; set; }

    [Column("Reward_Points_Required")]
    public int? RewardPointsRequired { get; set; }

    public double PointsCollectionResetPeriod { get; set; }

    public int CreatedById { get; set; }

    public string? InfoAndTips { get; set; }

    public bool DescriptionIsHtml { get; set; }

    [ForeignKey("ClientId")]
    [InverseProperty("Locations")]
    public virtual Client Client { get; set; } = null!;

    [ForeignKey("LocationStatusId")]
    [InverseProperty("Locations")]
    public virtual LocationStatus LocationStatus { get; set; } = null!;

    [ForeignKey("LocationType")]
    [InverseProperty("Locations")]
    public virtual LocationType LocationTypeNavigation { get; set; } = null!;

    [InverseProperty("ChildLocation")]
    public virtual ICollection<ParentChildRelationship> ParentChildRelationshipChildLocations { get; } = new List<ParentChildRelationship>();

    [InverseProperty("ParentLocation")]
    public virtual ICollection<ParentChildRelationship> ParentChildRelationshipParentLocations { get; } = new List<ParentChildRelationship>();

    [InverseProperty("Location")]
    public virtual ICollection<PointsEarned> PointsEarneds { get; } = new List<PointsEarned>();

    [InverseProperty("Location")]
    public virtual ICollection<PointsRedeemed> PointsRedeemeds { get; } = new List<PointsRedeemed>();

    [ForeignKey("LocationId")]
    [InverseProperty("Locations")]
    public virtual ICollection<Category> Categories { get; } = new List<Category>();
}
