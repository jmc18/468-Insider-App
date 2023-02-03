using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _468Insider.Infrastructure.Repositories;

[Table("User_Subscriptions")]
public partial class UserSubscription
{
    [Key]
    public int SubscriptionId { get; set; }

    public int UserId { get; set; }

    [StringLength(50)]
    public string TransactionNumber { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ExpiresDate { get; set; }

    [StringLength(20)]
    public string? CouponCodeUsed { get; set; }

    [Column(TypeName = "decimal(8, 2)")]
    public decimal AmountCharged { get; set; }

    public int GiftCertificateId { get; set; }
}
