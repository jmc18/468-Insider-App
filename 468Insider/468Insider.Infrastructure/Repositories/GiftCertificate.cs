using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _468Insider.Infrastructure.Repositories;

[Table("Gift_Certificates")]
public partial class GiftCertificate
{
    [Key]
    public int GiftCertificateId { get; set; }

    [StringLength(32)]
    public string GiftCertificateCode { get; set; } = null!;

    [StringLength(40)]
    public string? GiftGiverName { get; set; }

    [StringLength(255)]
    public string? GiftGiverEmail { get; set; }

    [Column(TypeName = "decimal(6, 2)")]
    public decimal? PurchasePrice { get; set; }

    [StringLength(15)]
    public string? TransactionNumber { get; set; }

    [StringLength(30)]
    public string? CouponCodeUsed { get; set; }

    public bool IsValid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string? RedeemedByEmail { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RedemptionDate { get; set; }
}
