using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _468Insider.Infrastructure.Repositories;

[Table("LimitedAccount")]
public partial class LimitedAccount
{
    [Key]
    public int Id { get; set; }

    [Column("Location_Id")]
    public int? LocationId { get; set; }

    [StringLength(255)]
    public string? EmailAddress { get; set; }

    public bool? IsActive { get; set; }

    public Guid? LocationGuid { get; set; }
}
