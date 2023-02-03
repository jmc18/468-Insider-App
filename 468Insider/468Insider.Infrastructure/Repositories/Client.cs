using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _468Insider.Infrastructure.Repositories;

public partial class Client
{
    [Key]
    [Column("Client_ID")]
    public int ClientId { get; set; }

    [Column("Client_Status_ID")]
    public int ClientStatusId { get; set; }

    [Column("Client_Name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ClientName { get; set; }

    [Column("App_Name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AppName { get; set; }

    [Column("Logo_Image")]
    [StringLength(300)]
    [Unicode(false)]
    public string? LogoImage { get; set; }

    [Column("Bkg_Image")]
    [StringLength(300)]
    [Unicode(false)]
    public string? BkgImage { get; set; }

    [Unicode(false)]
    public string Description { get; set; } = null!;

    [Column("Reward_Code")]
    public int RewardCode { get; set; }

    [Column("Map_GPS")]
    [StringLength(100)]
    [Unicode(false)]
    public string MapGps { get; set; } = null!;

    [Column("Map_Radius")]
    [StringLength(50)]
    [Unicode(false)]
    public string MapRadius { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Created { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Updated { get; set; }

    public double? DefaultPointsCollectionResetPeriod { get; set; }

    public bool MultiCategoryEnabled { get; set; }

    public bool HtmlDescriptionsEnabled { get; set; }

    [StringLength(255)]
    public string? NotificationCertificatePath { get; set; }

    [StringLength(20)]
    public string? NotificationChannel { get; set; }

    [InverseProperty("Client")]
    public virtual ICollection<Account> Accounts { get; } = new List<Account>();

    [InverseProperty("Client")]
    public virtual ICollection<AppUsed> AppUseds { get; } = new List<AppUsed>();

    [InverseProperty("Client")]
    public virtual ICollection<Category> Categories { get; } = new List<Category>();

    [ForeignKey("ClientStatusId")]
    [InverseProperty("Clients")]
    public virtual ClientStatus ClientStatus { get; set; } = null!;

    [InverseProperty("Client")]
    public virtual ICollection<Content> Contents { get; } = new List<Content>();

    [InverseProperty("Client")]
    public virtual ICollection<Location> Locations { get; } = new List<Location>();

    [InverseProperty("Client")]
    public virtual ICollection<PointsEarned> PointsEarneds { get; } = new List<PointsEarned>();

    [InverseProperty("Client")]
    public virtual ICollection<PointsRedeemed> PointsRedeemeds { get; } = new List<PointsRedeemed>();

    [InverseProperty("Client")]
    public virtual ICollection<User> Users { get; } = new List<User>();
}
