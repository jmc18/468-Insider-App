using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _468Insider.Infrastructure.Repositories;

public partial class Account
{
    [Key]
    [Column("Account_ID")]
    public int AccountId { get; set; }

    [StringLength(255)]
    public string Email { get; set; } = null!;

    [StringLength(255)]
    public string Password { get; set; } = null!;

    [StringLength(100)]
    public string Name { get; set; } = null!;

    [Column("Client_ID")]
    public int ClientId { get; set; }

    [Column("Account_Type_ID")]
    public int AccountTypeId { get; set; }

    public bool IsDisabled { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [ForeignKey("AccountTypeId")]
    [InverseProperty("Accounts")]
    public virtual AccountType AccountType { get; set; } = null!;

    [ForeignKey("ClientId")]
    [InverseProperty("Accounts")]
    public virtual Client Client { get; set; } = null!;
}
