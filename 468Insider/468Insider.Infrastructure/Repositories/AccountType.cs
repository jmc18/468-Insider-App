using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _468Insider.Infrastructure.Repositories;

[Table("Account_Types")]
public partial class AccountType
{
    [Key]
    [Column("Account_Type_ID")]
    public int AccountTypeId { get; set; }

    [Column("Account_Type_Status")]
    [StringLength(100)]
    [Unicode(false)]
    public string AccountTypeStatus { get; set; } = null!;

    [InverseProperty("AccountType")]
    public virtual ICollection<Account> Accounts { get; } = new List<Account>();
}
