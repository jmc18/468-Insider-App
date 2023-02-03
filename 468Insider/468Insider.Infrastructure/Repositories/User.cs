using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _468Insider.Infrastructure.Repositories;

public partial class User
{
    [Key]
    [Column("User_ID")]
    public int UserId { get; set; }

    [Column("Client_ID")]
    public int ClientId { get; set; }

    [Column("User_Status_ID")]
    public int UserStatusId { get; set; }

    [StringLength(255)]
    public string Email { get; set; } = null!;

    [StringLength(255)]
    public string Password { get; set; } = null!;

    [Column("First_Name")]
    [StringLength(50)]
    [Unicode(false)]
    public string FirstName { get; set; } = null!;

    [Column("Last_Name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? LastName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Phone { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Country { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? State { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? City { get; set; }

    public bool Enabled { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Created { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Updated { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PostalCode { get; set; }

    public bool PasswordEncrypted { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<AppUsed> AppUseds { get; } = new List<AppUsed>();

    [ForeignKey("ClientId")]
    [InverseProperty("Users")]
    public virtual Client Client { get; set; } = null!;

    [InverseProperty("User")]
    public virtual ICollection<PointsEarned> PointsEarneds { get; } = new List<PointsEarned>();

    [InverseProperty("User")]
    public virtual ICollection<PointsRedeemed> PointsRedeemeds { get; } = new List<PointsRedeemed>();

    [ForeignKey("UserStatusId")]
    [InverseProperty("Users")]
    public virtual UserStatus UserStatus { get; set; } = null!;
}
