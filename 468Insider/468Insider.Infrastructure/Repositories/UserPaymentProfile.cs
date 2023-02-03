using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _468Insider.Infrastructure.Repositories;

[Table("User_Payment_Profile")]
public partial class UserPaymentProfile
{
    [Key]
    public int UserPaymentProfileId { get; set; }

    public int UserId { get; set; }

    public int CustomerProfileId { get; set; }

    public int PaymentProfileId { get; set; }

    [Column("CCLast4")]
    [StringLength(4)]
    public string? Cclast4 { get; set; }

    [Column("CCExpiration")]
    [StringLength(7)]
    public string? Ccexpiration { get; set; }

    public int? FailedPaymentCount { get; set; }
}
